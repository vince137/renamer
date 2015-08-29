﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        readDir dirSelector;

        public Form1()
        {
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

        public string formtextFiles
        {
            get { return textFiles.Text; }
            set { textFiles.Text = value; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

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


        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
