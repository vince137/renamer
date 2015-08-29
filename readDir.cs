using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class readDir
    {

        private Form1 form;
        public string folderPath;
        private Array arrayFiles;

        public void Main(){
        }

        public void setView(Form1 form)
        {
            this.form = form;
        }


        public void setFolder(string folder)
        {

            if (!String.IsNullOrEmpty(folder)){
                this.folderPath = folder;
            }
            this.setFiles();
        }

        // Ajoute les fichiers du répertoire dans un Array
        public void setFiles()
        {
            if (!String.IsNullOrEmpty(this.folderPath))
            {
                this.arrayFiles = Directory.GetFiles(this.folderPath)
                    .Select(path => Path.GetFileName(path))
                    .ToArray();
                this.readFiles();
            }
        }
        
        // Lecture de l'array qui contient tous les fichiers
        public void readFiles()
        {
            int i = 0;
            foreach(string file in this.arrayFiles)
            {
                i++;
                if (String.IsNullOrEmpty(file)) continue;
                this.form.formtextFiles += i+". "+file.Replace(this.folderPath,"")+Environment.NewLine;
            }
        }
    }
}
