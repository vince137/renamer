using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class readDir
    {

        private Form1 form;
        public string folderPath = "";

        public void Main(){
        }

        public void setView(Form1 form)
        {
            this.form = form;
            this.setFolder();
        }


        public void setFolder()
        {
            form.formTextFolder = "Sélectionnez un répertoire";

        }


    }
}
