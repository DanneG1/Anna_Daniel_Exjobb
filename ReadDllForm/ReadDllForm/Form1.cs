using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadDllForm.Properties;


namespace ReadDllForm
{
    public partial class Form1 : Form
    {
        private string hPath = "";
        private string cppPath = "";
        
        public Form1()
        {
            InitializeComponent();
            textBoxMsBuild.Text = Settings.Default["MsBuild"].ToString();
            textBoxSolution.Text = Settings.Default["Solution"].ToString();
            textBoxTarget.Text = Settings.Default["TargetFolder"].ToString();

        }

        private void btnHeader_Click(object sender, EventArgs e)
        {
            OpenFileDialog openH = new OpenFileDialog();
            openH.Filter="h files(*.h)|*.h";
            if (openH.ShowDialog() == DialogResult.OK)
            {
                string hFileName = openH.FileName;
                hPath = hFileName;
                txtBoxH.Text = hFileName;
            }
        }

        private void btnCppFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openCpp = new OpenFileDialog();
            openCpp.Filter = "cpp files(*.cpp)|*.cpp";
            if (openCpp.ShowDialog() == DialogResult.OK)
            {
                string cPpFileName = openCpp.FileName;
                cppPath = cPpFileName;
                txtBoxCpp.Text = cPpFileName;
            }
        }

        private void btnGenerateDll_Click(object sender, EventArgs e)
        {
            if (cppPath != "" && hPath != "")
            {
                createDll dll=new createDll();
                dll.createFile(hPath, cppPath);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            createDll dll=new createDll();
            dll.generateDll();
        }

        private void btnMSBuild_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
           // openH.Filter = "h files(*.h)|*.h";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Settings.Default["MsBuild"] = open.FileName;

                textBoxMsBuild.Text = Settings.Default["MsBuild"].ToString();
                Settings.Default.Save();
            }
        }

        private void btnSolution_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // openH.Filter = "h files(*.h)|*.h";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Settings.Default["Solution"] = open.FileName;

                textBoxSolution.Text = Settings.Default["Solution"].ToString();
                Settings.Default.Save();
            }
        }

        private void btnTargetFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Settings.Default["TargetFolder"] = fbd.SelectedPath;

                    textBoxTarget.Text = Settings.Default["TargetFolder"].ToString();
                    Settings.Default.Save();
                }
            }
          
        }
    }
}
