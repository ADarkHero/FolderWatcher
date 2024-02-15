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
using FolderWatcher;

namespace FolderWatcher
{
    public partial class showWatchedFolders : Form
    {
        char seperator = ';';

        public showWatchedFolders()
        {
            InitializeComponent();
        }

        private void showWatchedFolders_Load(object sender, EventArgs e)
        {
            foreach(FolderWatcherInfo f in Globals.fwi)
            {
                richTextBox1.AppendText(f.filePath + seperator + f.searchString + seperator + f.watchMethod + Environment.NewLine);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            Globals.fwi.Clear();

            var lines = richTextBox1.Text.Split('\n');

            if(lines.Length > 1)
            {
                foreach (String line in lines)
                {
                    try
                    {
                        var field = line.Split(seperator);
                        Globals.fwi.Add(new FolderWatcherInfo(field[0], field[1], field[2]));
                    }
                    catch(Exception ex)
                    {

                    }
                }
            }            

            FolderWatcher.SaveSettings();

            MessageBox.Show("Änderungen gespeichert!");
        }

        private void ExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    writer.WriteLine(richTextBox1.Text);
                }

                MessageBox.Show("Csv wurde in den folgenden Pfad exportiert:" + Environment.NewLine + saveFileDialog1.FileName);
            }
        }
    }
}
