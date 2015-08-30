using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        readDir dirSelector;
        int files_CursorPosition = 0;
        bool files_BackPressed = false;

        public Form1()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
            this.dirSelector = new readDir();
            dirSelector.setView(this);
            textFolders.Click += new EventHandler(textFolders_Click);
        }


        public string formTextFolder
        {
            get { return textFolders.Text; }
            set { textFolders.Text = value; }
        }

        public void saveButton(int status)
        {
            if (status == 0) this.buttonSaveFiles.Enabled = false;
            else if (status == 1) this.buttonSaveFiles.Enabled = true;
        }

        public void addFiles(int i, string text)
        {
            // Ajoute les textBox à la vue
            TextBox txt = new TextBox();
            txt.Name = "textFiles_" + i;
            txt.Width = (this.panelFiles.Width - 50);
            txt.Location = new Point(10, i * 20);
            txt.Text = text;
            txt.TextChanged += new EventHandler(textFilesUpdate);
            this.panelFiles.Controls.Add(txt);
        }


        private void textFiles_TextChanged(object sender, KeyEventArgs e)
        {
            bool deleteKey = false;
            if (e.KeyCode == Keys.Enter) deleteKey = true;
            if (deleteKey == true)
            {
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void textFilesUpdate(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            string[] Text = textBox.Name.Split('_');

            var regex = new Regex("[0-9]");
            int n;
            foreach (string t in Text)
            {
                if (regex.IsMatch(t))
                {
                    Int32.TryParse(t, out n);
                    this.dirSelector.arrayFilesModified[n] = textBox.Text;
                    return;
                }
            }            
        }

        private void buttonSaveFiles_Click(object sender, EventArgs e)
        {
            this.saveButton(0);

            // Sauvegarde des modifications sur les fichiers
            int i = 0;
            foreach (string filesList in this.dirSelector.arrayFiles)
            {
                if(this.dirSelector.arrayFilesModified[i] != this.dirSelector.arrayFiles[i])
                {
                    // Rename the file
                    try
                    {
                        System.IO.File.Move(this.dirSelector.folderPath + this.dirSelector.arrayFiles[i], this.dirSelector.folderPath + this.dirSelector.arrayFilesModified[i]);
                    }
                    catch
                    {

                    }
                }
                i++;
            }
        }

        private void textFolders_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                formTextFolder = folderBrowserDialog1.SelectedPath;
                this.dirSelector.setFolder(formTextFolder);
            }
        }

        private void panelFiles_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
