using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    class readDir
    {

        private Form1 form;
        public string folderPath;
        public string[] arrayFiles = new string[255];
        public string[] arrayFilesModified = new string[255];
        public int totalLines;

        public void Main(){
        }

        public void setView(Form1 form)
        {
            this.form = form;
        }


        public void setFolder(string folder)
        {

            this.form.cleanTextFiles();

            // Clean l'array
            this.arrayFiles = new string[255];
            this.arrayFilesModified = new string[255];

            if (!String.IsNullOrEmpty(folder)){
                this.folderPath = folder+"\\";
            }
            this.setFiles();
        }

        // Ajoute les fichiers du répertoire dans un Array
        public void setFiles()
        {
            if (!String.IsNullOrEmpty(this.folderPath))
            {
                Array varFilesList = new string[255];
                varFilesList = Directory.GetFiles(this.folderPath)
                    .Select(path => Path.GetFileName(path))
                    .ToArray();

                this.totalLines = varFilesList.Length;

                int i= 0;
                foreach(string filesList in varFilesList)
                {
                    this.arrayFiles[i] = filesList;
                    this.arrayFilesModified[i] = filesList;
                    this.form.addFiles(i, filesList);
                    i++;
                }
                this.form.saveButton(1);
            }
        }
    }
}
