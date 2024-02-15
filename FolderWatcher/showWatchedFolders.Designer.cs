namespace FolderWatcher
{
    partial class showWatchedFolders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExportCSV = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(920, 305);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(12, 388);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(839, 50);
            this.SaveChanges.TabIndex = 1;
            this.SaveChanges.Text = "Änderungen Speichern";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Syntax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ordnername";
            // 
            // ExportCSV
            // 
            this.ExportCSV.Location = new System.Drawing.Point(857, 388);
            this.ExportCSV.Name = "ExportCSV";
            this.ExportCSV.Size = new System.Drawing.Size(75, 49);
            this.ExportCSV.TabIndex = 4;
            this.ExportCSV.Text = "CSV exportieren";
            this.ExportCSV.UseVisualStyleBackColor = true;
            this.ExportCSV.Click += new System.EventHandler(this.ExportCSV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zu überwachende Datei(en) (* überwacht alle)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(425, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Methode (folder = Datei(en) in Ordner überwachen / file = Änderungsdatum überwach" +
    "en)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Option1 (Bei \"file\" die Änderungszeit in Minuten - Stardardwert wenn leer)";
            // 
            // showWatchedFolders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 441);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExportCSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.richTextBox1);
            this.Name = "showWatchedFolders";
            this.Text = "Überwachte Ordner";
            this.Load += new System.EventHandler(this.showWatchedFolders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExportCSV;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}