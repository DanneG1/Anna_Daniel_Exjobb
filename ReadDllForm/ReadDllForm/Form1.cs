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

namespace ReadDllForm
{
    public partial class Form1 : Form
    {
        private string hPath = "";
        private string cppPath = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (cppPath != "" && hPath != "")
            {
                createDll dll=new createDll(hPath,cppPath);
                dll.createFile();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ANNAS SÖKVÄGAR
            /*
            string msbuild= @"""C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\amd64\MSBuild.exe""";
            string solution= @"""C:\Users\Anna Forsberg\Source\Repos\DanneG1\Anna_Daniel_Exjobb\GenerateDLL\GenerateDLL.sln""";
            */
            //DANNES SÖKVÄGAR
            string msbuild = @"""C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\amd64\MSBuild.exe""";
            string solution = @"""C:\Users\Danne\source\repos\Anna_Daniel_Exjobb\GenerateDLL\GenerateDLL.sln""";

            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.RedirectStandardError = true;
            //cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("cd..");
            cmd.StandardInput.WriteLine(msbuild+" "+ solution);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            Console.WriteLine(cmd.StandardError.ReadToEnd());

        }
    }
}
