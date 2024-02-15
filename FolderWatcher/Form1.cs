using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.Storage.AccessCache;
using Microsoft.VisualBasic;

namespace FolderWatcher
{


    public partial class FolderWatcher : Form
    {
        private int folderTimerValue = Properties.Settings.Default.timerValue; //Time in seconds
        private int changeDateTimerValue = Properties.Settings.Default.changeDate; //Time in seconds
        public static String settingsFilePath = "settings.xml";
        private List<Button> buttonsAdded = new List<Button>();
        System.Timers.Timer timer = new System.Timers.Timer();


        [DllImport("user32.dll")]
        public static extern int FlashWindow(IntPtr Hwnd, bool Revert);

        public FolderWatcher()
        {
            InitializeComponent();
        }


        /*********************************************************************************
         * Form loading and closing
         * Gets triggered wehen the form first loads
         * ******************************************************************************/

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load settings
            Globals.fwi = ReadFromXmlFile<List<FolderWatcherInfo>>(settingsFilePath);

            notifyIcon1.Icon = new System.Drawing.Icon(@"notifyIcon.ico");
            notifyIcon1.Text = "Folder Watcher";
            notifyIcon1.Visible = true;

            StartAllChecks();

            //Starts folder checks again after X Minutes
            timer.Interval = folderTimerValue * 1000; //Convert time to milliseconds
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIcon1.Visible = true;
                this.Hide();
                e.Cancel = true;
            }
        }

        /*********************************************************************************
         * Timer
         * Functions that get triggered, when a timer elapses
         * ******************************************************************************/
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            StartAllChecks();
        }






        /*********************************************************************************
         * Checks
         * Main program logic
         * ******************************************************************************/

        public void StartAllChecks()
        {
            RemoveAddedButtons();

            CheckForFilesInFolder();
            CheckForFileChangeDate();

            //Add a smiley button, if there are no errors. :)
            if (buttonsAdded.Count == 0)
            {
                Invoke(new MethodInvoker(delegate {
                    AddNewButton(10, 50, "Derzeit gibt es keine Probleme!" + Environment.NewLine + Environment.NewLine + "😀", 300, Color.Green);
                }));
                
            }

            //Write the current date to a label on the gui
            LastUpdatedLabel.BeginInvoke(new MethodInvoker(() =>
            {
                LastUpdatedLabel.Text = "Letztes Update:  " + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine +
                "Nächstes Update: " + DateTime.Now.AddSeconds(folderTimerValue).ToString("HH:mm:ss");
            }));
        }



        private void CheckForFilesInFolder()
        {
            try
            {
                int i = 0;
                int j = 0;

                foreach (FolderWatcherInfo f in Globals.fwi)
                {
                    if (f.watchMethod == "folder")
                    {
                        string[] files = Directory.GetFiles(f.filePath, f.searchString, SearchOption.TopDirectoryOnly);

                        if (files.Count() != 0)
                        {
                            if (i == 5) { j++; i -= 5; }
                            Invoke(new MethodInvoker(delegate { AddNewButton(i * 100 + i * 10 + 10, j * 100 + 50, f.filePath, 100, Color.Red); }));

                            i++;

                            new ToastContentBuilder()
                            .AddText("Im folgenden Ordner befinden sich Fehlerdateien:" + Environment.NewLine + f.filePath)
                            .AddButton(new ToastButton()
                            .SetContent("Betroffenen Ordner öffnen")
                            .AddArgument(f.filePath))
                            .Show();
                            ToastNotificationManagerCompat.OnActivated += toastArgs =>
                            {
                                System.Diagnostics.Process.Start(toastArgs.Argument);
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        private void CheckForFileChangeDate()
        {
            int i = buttonsAdded.Count;
            int j = 0;
            foreach (FolderWatcherInfo f in Globals.fwi)
            {
                if (f.watchMethod == "file")
                {
                    DateTime modification = File.GetLastWriteTime(@f.filePath);
                    DateTime currentDateTime = DateTime.Now;
                    TimeSpan duration = currentDateTime - modification;

                    if(duration.TotalSeconds > changeDateTimerValue)
                    {
                        while(i >= 5) { j++; i -= 5; } //Calculate current button position
                        Invoke(new MethodInvoker(delegate { AddNewButton(i * 100 + i * 10 + 10, j * 100 + 50, f.filePath, 100, Color.Red); }));

                        new ToastContentBuilder()
                            .AddText("Die folgende Datei wurde seit über " + changeDateTimerValue + " Sekunden nicht aktualisiert:" 
                            + Environment.NewLine + f.filePath)
                            .AddButton(new ToastButton()
                            .SetContent("Betroffene Datei öffnen")
                            .AddArgument(f.filePath))
                            .Show();
                        ToastNotificationManagerCompat.OnActivated += toastArgs =>
                        {
                            System.Diagnostics.Process.Start(toastArgs.Argument);
                        };

                        i++;
                    }
                }
            }
        }


        /*********************************************************************************
         * Helper functions
         * Adding Buttons on the fly etc.
         * ******************************************************************************/

        private void AddNewButton(int xpos, int ypos, String filePath, int size, Color color)
        {
            Button testbutton = new Button();
            testbutton.Text = filePath;
            testbutton.Location = new Point(xpos, ypos);
            testbutton.Size = new Size(size, size);
            testbutton.Visible = true;
            testbutton.BackColor = color;
            testbutton.Click += (s, e) => {
                try
                {
                    System.Diagnostics.Process.Start(filePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            };
            testbutton.BringToFront();
            this.Controls.Add(testbutton);
            buttonsAdded.Add(testbutton);
        }

        private void RemoveAddedButtons()
        {
            while (buttonsAdded.Count > 0)
            {
                Button buttonToRemove = buttonsAdded[0];
                buttonsAdded.Remove(buttonToRemove);
                buttonToRemove.Invoke(new MethodInvoker(delegate { Controls.Remove(buttonToRemove); }));
            }
        }


        /*********************************************************************************
         * XML Helper
         * Save objects to xml and load them again, when the program starts
         * ******************************************************************************/

        public static void SaveSettings()
        {
            WriteToXmlFile<List<FolderWatcherInfo>>(settingsFilePath, Globals.fwi);
        }

        /// <summary>
        /// Writes the given object instance to an XML file.
        /// <para>Only Public properties and variables will be written to the file. These can be any type though, even other classes.</para>
        /// <para>If there are public properties/variables that you do not want written to the file, decorate them with the [XmlIgnore] attribute.</para>
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            try
            {
                File.Copy(filePath, filePath + "_backup_" + DateTime.Now.ToString("ddMMyyyy"), true);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }

            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter(filePath, append);
                serializer.Serialize(writer, objectToWrite);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>
        /// Reads an object instance from an XML file.
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object to read from the file.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the XML file.</returns>
        public static T ReadFromXmlFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader(filePath);
                return (T)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        /*********************************************************************************
         * Buttons
         * OnClick functions for all buttons
         * ******************************************************************************/

        /*********************************************************************************
         * Common functions buttons
         * Menu item "Allgemeine Funktionen"
         * ******************************************************************************/

        private void ordnerüberprüfungManuellStartenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartAllChecks();
        }

        private void UeberwachteOrdnerDateienAnzeigen_Click(object sender, EventArgs e)
        {
            showWatchedFolders f = new showWatchedFolders();

            f.ShowDialog(); // Shows showWatchedFolders Form
        }

        /*********************************************************************************
         * Watch folder buttons
         * Menu item "Ordner überwachen"
         * ******************************************************************************/

        private void NeuenOrdnerUeberwachen_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    MessageBox.Show("Neuen Ordner zur Überwachung hinzugefügt! " + Environment.NewLine + fbd.SelectedPath);

                    FolderWatcherInfo newfwi = new FolderWatcherInfo(fbd.SelectedPath);
                    Globals.fwi.Add(newfwi);
                    SaveSettings();
                }
            }
        }


        private void BestimmteDateienEinesOrdnersUeberwachen_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string input = Interaction.InputBox("Welcher Text soll im Dateinamen enthalten sein?",
                        "Suchstring eingeben." + Environment.NewLine + "* ist ein Platzhalterzeichen", "*");

                    if(input != "")
                    {
                        FolderWatcherInfo newfwi = new FolderWatcherInfo(fbd.SelectedPath, input);
                        Globals.fwi.Add(newfwi);
                        SaveSettings();

                        MessageBox.Show("Neuen Ordner zur Überwachung hinzugefügt!" + Environment.NewLine + fbd.SelectedPath + Environment.NewLine + input);
                    }                
                }
            }
        }


        /*********************************************************************************
         * Watch file buttons
         * Menu item "Datei überwachen"
         * ******************************************************************************/

        private void AenderungsdatumEinerDateiUeberwachenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();

            if(openFileDialog1.FileName != "")
            {
                FolderWatcherInfo newfwi = new FolderWatcherInfo(openFileDialog1.FileName, "", "file");
                Globals.fwi.Add(newfwi);
                SaveSettings();

                MessageBox.Show("Neue Datei zur Überwachung hinzugefügt!" + Environment.NewLine + openFileDialog1.FileName + Environment.NewLine);
            }    
        }

        /*********************************************************************************
         * Settings buttons
         * Menu item "Einstellungen"
         * ******************************************************************************/

        private void UpdatetimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Bitte in Sekunden eingeben!", "Updatezeit anpassen.", folderTimerValue.ToString());

            try
            {
                if (input != "")
                {
                    folderTimerValue = Int32.Parse(input);
                    Properties.Settings.Default.timerValue = folderTimerValue;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Updatezeit erfolgreich auf " + input + " Sekunden geändert!" + Environment.NewLine +
                    "Bitte einmal das Programm neu starten, damit die Änderung wirksam wird!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Fehler beim Ändern der Einstellung!" + Environment.NewLine + ex);
            }
        }

        private void AenderungszeitBeiDateienAnpassenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Bitte in Sekunden eingeben!",
                "Ab wie vielen Sekunden soll die Software einen Fehler melden, wenn die Datei nicht geändert wurde?", changeDateTimerValue.ToString());

            try
            {
                if (input != "")
                {
                    changeDateTimerValue = Int32.Parse(input);
                    Properties.Settings.Default.changeDate = changeDateTimerValue;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Änderungszeit erfolgreich auf " + input + " Sekunden geändert!" + Environment.NewLine +
                    "Bitte einmal das Programm neu starten, damit die Änderung wirksam wird!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Fehler beim Ändern der Einstellung!" + Environment.NewLine + ex);
            }
        }

        /*********************************************************************************
         * Exit buttons
         * Menu item "Exit"
         * ******************************************************************************/

        private void ProgrammBeenden_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void InTaskleisteMinimieren_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            this.Hide();
        }

        /*********************************************************************************
        * NotifyIcon 
        * Maximize from taskbar; Close via right click menu
        * ******************************************************************************/

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ProgrammBeendenNotifyIcon_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }




        /*********************************************************************************
        * Unneccessary bs
        * ******************************************************************************/


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LastUpdatedLabelFolder_Click(object sender, EventArgs e)
        {

        }

        

        private void ExitSoftware_Click(object sender, EventArgs e)
        {
        }

        
    }

    public static class Globals
    {
        public static List<FolderWatcherInfo> fwi = new List<FolderWatcherInfo>();
    }


}
