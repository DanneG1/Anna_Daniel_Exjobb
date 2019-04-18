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
            string msbuild= @"""C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\amd64\MSBuild.exe""";
            string sulution= @"""C:\Users\Anna Forsberg\Source\Repos\DanneG1\Anna_Daniel_Exjobb\GenerateDLL\GenerateDLL.sln""";
            string cl = @"""C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\VC\Tools\MSVC\14.13.26128\bin\Hostx64\x64\cl.exe""";
            string cpp =@"""C:\Users\Anna Forsberg\Source\Repos\DanneG1\Anna_Daniel_Exjobb\ReadDllForm\ReadDllForm\bin\Debug\newDLLfileV2.cpp""";
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.RedirectStandardError = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("cd..");
            //cmd.StandardInput.WriteLine(cl +" /LD "+cpp);
            cmd.StandardInput.WriteLine(msbuild+" "+ sulution);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            Console.WriteLine(cmd.StandardError.ReadToEnd());

            /* string msbuild= @"""C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\amd64\MSBuild.exe""";
            string solution= @"""C:\Users\Anna Forsberg\Source\Repos\DanneG1\Anna_Daniel_Exjobb\Read_Header_generate_CppCode\Read_Header_generate_CppCode.sln""";
            string cl = @"""C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\VC\Tools\MSVC\14.13.26128\bin\Hostx64\x64\cl.exe""";
            string cpp =@"""C:\Users\Anna Forsberg\Source\Repos\DanneG1\Anna_Daniel_Exjobb\ReadDllForm\ReadDllForm\bin\Debug\newDLLfileV2.cpp""";


            //string name = "cmd.exe";
            string name = "x86_x64 Cross Tools Command Prompt for VS 2017";
            string directory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Visual Studio 2017\Visual Studio Tools\VC";
            Process cmd = new Process();
            string command = cl + " /LD " + cpp;


            /*ProcessStartInfo info
                = new ProcessStartInfo("cmd", @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Visual Studio 2017\Visual Studio Tools\VC\x86_x64 Cross Tools Command Prompt for VS 2017 /K cl.exe \LD ""C:\Users\Anna Forsberg\Source\Repos\DanneG1\Anna_Daniel_Exjobb\ReadDllForm\ReadDllForm\bin\Debug\newDLLfileV2.cpp""");
            
            info.Verb = "runas";
            info.RedirectStandardInput = true;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            cmd.StartInfo=info;*/

            /*cmd.StartInfo.FileName = name;
            cmd.StartInfo.WorkingDirectory = directory;
            cmd.StartInfo.Verb = "runas";

            //försök starta vs-komandotolken sen avkommentera detta
            /*
             cmd.StartInfo.RedirectStandardInput = true;
             cmd.StartInfo.RedirectStandardOutput = true;
             cmd.StartInfo.RedirectStandardError = true;
             cmd.StartInfo.CreateNoWindow = true;
             cmd.StartInfo.UseShellExecute = false;*/
            /*cmd.Start();


            //och detta
            //cmd.StandardInput.WriteLine("cd..");
            // cmd.StandardInput.WriteLine(cl +" /LD "+cpp);
            // cmd.StandardInput.WriteLine(msbuild+" "+ solution);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            Console.WriteLine(cmd.StandardError.ReadToEnd());
            */

           

        }
    }
}
