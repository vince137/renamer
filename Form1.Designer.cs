namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textFolders = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textFiles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Fichiers";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textFolders
            // 
            this.textFolders.BackColor = System.Drawing.Color.White;
            this.textFolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFolders.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textFolders.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textFolders.Location = new System.Drawing.Point(305, 27);
            this.textFolders.Name = "textFolders";
            this.textFolders.Size = new System.Drawing.Size(254, 13);
            this.textFolders.TabIndex = 3;
            this.textFolders.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // textFiles
            // 
            this.textFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFiles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textFiles.Location = new System.Drawing.Point(49, 50);
            this.textFiles.Multiline = true;
            this.textFiles.Name = "textFiles";
            this.textFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textFiles.Size = new System.Drawing.Size(510, 205);
            this.textFiles.TabIndex = 1;
            this.textFiles.TextChanged += new System.EventHandler(this.textFiles_TextChanged);
            this.textFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textFiles_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 296);
            this.Controls.Add(this.textFolders);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textFolders;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textFiles;
    }
}

