namespace FolderWatcher
{
    partial class FolderWatcher
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordnerüberprüfungManuellStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UeberwachteOrdnerDateienAnzeigen = new System.Windows.Forms.ToolStripMenuItem();
            this.ordnerÜberwachenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NeuenOrdnerUeberwachen = new System.Windows.Forms.ToolStripMenuItem();
            this.BestimmteDateienEinesOrdnersUeberwachen = new System.Windows.Forms.ToolStripMenuItem();
            this.dateiÜberwachenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AenderungsdatumEinerDateiUeberwachenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdatetimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AenderungszeitBeiDateienAnpassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitSoftware = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgrammBeenden = new System.Windows.Forms.ToolStripMenuItem();
            this.LastUpdatedLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.InTaskleisteMinimieren = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ordnerÜberwachenToolStripMenuItem,
            this.dateiÜberwachenToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.ExitSoftware});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordnerüberprüfungManuellStartenToolStripMenuItem,
            this.UeberwachteOrdnerDateienAnzeigen});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 20);
            this.toolStripMenuItem1.Text = "Allgemeine Funktionen";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ordnerüberprüfungManuellStartenToolStripMenuItem
            // 
            this.ordnerüberprüfungManuellStartenToolStripMenuItem.Name = "ordnerüberprüfungManuellStartenToolStripMenuItem";
            this.ordnerüberprüfungManuellStartenToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.ordnerüberprüfungManuellStartenToolStripMenuItem.Text = "Ordnerüberprüfung manuell starten";
            this.ordnerüberprüfungManuellStartenToolStripMenuItem.Click += new System.EventHandler(this.ordnerüberprüfungManuellStartenToolStripMenuItem_Click);
            // 
            // UeberwachteOrdnerDateienAnzeigen
            // 
            this.UeberwachteOrdnerDateienAnzeigen.Name = "UeberwachteOrdnerDateienAnzeigen";
            this.UeberwachteOrdnerDateienAnzeigen.Size = new System.Drawing.Size(272, 22);
            this.UeberwachteOrdnerDateienAnzeigen.Text = "Überwachte Ordner/Dateien anzeigen";
            this.UeberwachteOrdnerDateienAnzeigen.Click += new System.EventHandler(this.UeberwachteOrdnerDateienAnzeigen_Click);
            // 
            // ordnerÜberwachenToolStripMenuItem
            // 
            this.ordnerÜberwachenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NeuenOrdnerUeberwachen,
            this.BestimmteDateienEinesOrdnersUeberwachen});
            this.ordnerÜberwachenToolStripMenuItem.Name = "ordnerÜberwachenToolStripMenuItem";
            this.ordnerÜberwachenToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.ordnerÜberwachenToolStripMenuItem.Text = "Ordner überwachen";
            // 
            // NeuenOrdnerUeberwachen
            // 
            this.NeuenOrdnerUeberwachen.Name = "NeuenOrdnerUeberwachen";
            this.NeuenOrdnerUeberwachen.Size = new System.Drawing.Size(325, 22);
            this.NeuenOrdnerUeberwachen.Text = "Alle Dateien eines Ordners überwachen";
            this.NeuenOrdnerUeberwachen.Click += new System.EventHandler(this.NeuenOrdnerUeberwachen_Click);
            // 
            // BestimmteDateienEinesOrdnersUeberwachen
            // 
            this.BestimmteDateienEinesOrdnersUeberwachen.Name = "BestimmteDateienEinesOrdnersUeberwachen";
            this.BestimmteDateienEinesOrdnersUeberwachen.Size = new System.Drawing.Size(325, 22);
            this.BestimmteDateienEinesOrdnersUeberwachen.Text = "Bestimmte Datei(en) eines Ordners überwachen";
            this.BestimmteDateienEinesOrdnersUeberwachen.Click += new System.EventHandler(this.BestimmteDateienEinesOrdnersUeberwachen_Click);
            // 
            // dateiÜberwachenToolStripMenuItem
            // 
            this.dateiÜberwachenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AenderungsdatumEinerDateiUeberwachenToolStripMenuItem});
            this.dateiÜberwachenToolStripMenuItem.Name = "dateiÜberwachenToolStripMenuItem";
            this.dateiÜberwachenToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.dateiÜberwachenToolStripMenuItem.Text = "Datei überwachen";
            // 
            // AenderungsdatumEinerDateiUeberwachenToolStripMenuItem
            // 
            this.AenderungsdatumEinerDateiUeberwachenToolStripMenuItem.Name = "AenderungsdatumEinerDateiUeberwachenToolStripMenuItem";
            this.AenderungsdatumEinerDateiUeberwachenToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.AenderungsdatumEinerDateiUeberwachenToolStripMenuItem.Text = "Änderungsdatum einer Datei überwachen";
            this.AenderungsdatumEinerDateiUeberwachenToolStripMenuItem.Click += new System.EventHandler(this.AenderungsdatumEinerDateiUeberwachenToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdatetimeToolStripMenuItem,
            this.AenderungszeitBeiDateienAnpassenToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // UpdatetimeToolStripMenuItem
            // 
            this.UpdatetimeToolStripMenuItem.Name = "UpdatetimeToolStripMenuItem";
            this.UpdatetimeToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.UpdatetimeToolStripMenuItem.Text = "Updatezeit/Timer anpassen";
            this.UpdatetimeToolStripMenuItem.Click += new System.EventHandler(this.UpdatetimeToolStripMenuItem_Click);
            // 
            // AenderungszeitBeiDateienAnpassenToolStripMenuItem
            // 
            this.AenderungszeitBeiDateienAnpassenToolStripMenuItem.Name = "AenderungszeitBeiDateienAnpassenToolStripMenuItem";
            this.AenderungszeitBeiDateienAnpassenToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.AenderungszeitBeiDateienAnpassenToolStripMenuItem.Text = "Änderungszeit bei Dateien anpassen";
            this.AenderungszeitBeiDateienAnpassenToolStripMenuItem.Click += new System.EventHandler(this.AenderungszeitBeiDateienAnpassenToolStripMenuItem_Click);
            // 
            // ExitSoftware
            // 
            this.ExitSoftware.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgrammBeenden,
            this.InTaskleisteMinimieren});
            this.ExitSoftware.Name = "ExitSoftware";
            this.ExitSoftware.Size = new System.Drawing.Size(38, 20);
            this.ExitSoftware.Text = "Exit";
            this.ExitSoftware.Click += new System.EventHandler(this.ExitSoftware_Click);
            // 
            // ProgrammBeenden
            // 
            this.ProgrammBeenden.Name = "ProgrammBeenden";
            this.ProgrammBeenden.Size = new System.Drawing.Size(200, 22);
            this.ProgrammBeenden.Text = "Programm beenden";
            this.ProgrammBeenden.Click += new System.EventHandler(this.ProgrammBeenden_Click);
            // 
            // LastUpdatedLabel
            // 
            this.LastUpdatedLabel.AutoSize = true;
            this.LastUpdatedLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUpdatedLabel.Location = new System.Drawing.Point(12, 428);
            this.LastUpdatedLabel.Name = "LastUpdatedLabel";
            this.LastUpdatedLabel.Size = new System.Drawing.Size(420, 14);
            this.LastUpdatedLabel.TabIndex = 2;
            this.LastUpdatedLabel.Text = "Du solltest diesen Text nicht sehen. LastUpdatedLabelFolder";
            this.LastUpdatedLabel.Click += new System.EventHandler(this.LastUpdatedLabelFolder_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // InTaskleisteMinimieren
            // 
            this.InTaskleisteMinimieren.Name = "InTaskleisteMinimieren";
            this.InTaskleisteMinimieren.Size = new System.Drawing.Size(200, 22);
            this.InTaskleisteMinimieren.Text = "In Taskleiste minimieren";
            this.InTaskleisteMinimieren.Click += new System.EventHandler(this.InTaskleisteMinimieren_Click);
            // 
            // FolderWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LastUpdatedLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FolderWatcher";
            this.Text = "Folder Watcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label LastUpdatedLabel;
        private System.Windows.Forms.ToolStripMenuItem ordnerüberprüfungManuellStartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordnerÜberwachenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NeuenOrdnerUeberwachen;
        private System.Windows.Forms.ToolStripMenuItem dateiÜberwachenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BestimmteDateienEinesOrdnersUeberwachen;
        private System.Windows.Forms.ToolStripMenuItem AenderungsdatumEinerDateiUeberwachenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdatetimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AenderungszeitBeiDateienAnpassenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UeberwachteOrdnerDateienAnzeigen;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem ExitSoftware;
        private System.Windows.Forms.ToolStripMenuItem ProgrammBeenden;
        private System.Windows.Forms.ToolStripMenuItem InTaskleisteMinimieren;
    }
}

