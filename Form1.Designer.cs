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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textFolders = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.buttonSaveFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textFolders
            // 
            this.textFolders.BackColor = System.Drawing.Color.White;
            this.textFolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFolders.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textFolders.ForeColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.textFolders, "textFolders");
            this.textFolders.Name = "textFolders";
            this.textFolders.TextChanged += new System.EventHandler(this.textFolders_TextChanged);
            // 
            // panelFiles
            // 
            resources.ApplyResources(this.panelFiles, "panelFiles");
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFiles_Paint);
            // 
            // buttonSaveFiles
            // 
            resources.ApplyResources(this.buttonSaveFiles, "buttonSaveFiles");
            this.buttonSaveFiles.Name = "buttonSaveFiles";
            this.buttonSaveFiles.UseVisualStyleBackColor = true;
            this.buttonSaveFiles.Click += new System.EventHandler(this.buttonSaveFiles_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSaveFiles);
            this.Controls.Add(this.panelFiles);
            this.Controls.Add(this.textFolders);
            this.Controls.Add(this.textBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textFolders;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panelFiles;
        private System.Windows.Forms.Button buttonSaveFiles;
    }
}

