using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
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
        private const string Solution = "Solution";
        private const string MsBuild = "MsBuild";
        private const string TargetFolder = "TargetFolder";
        private string hPath;
        private string cppPath;
        private Dictionary<string,SimulinkModel> keyValue=new Dictionary<string, SimulinkModel>();
        private SimulinkModel selectedModel;

        public Form1()
        {
            InitializeComponent();
            FillOutFieldsFromSettings();
        }
        private void FillOutFieldsFromSettings()
        {
            textBoxMsBuild.Text = Settings.Default[MsBuild].ToString();
            textBoxSolution.Text = Settings.Default[Solution].ToString();
            textBoxTarget.Text = Settings.Default[TargetFolder].ToString();

            //Show end of file path
            textBoxMsBuild.SelectionStart = textBoxMsBuild.Text.Length;
            textBoxSolution.SelectionStart = textBoxSolution.Text.Length;
            textBoxTarget.SelectionStart = textBoxTarget.Text.Length;
        }
        private bool AllFieldsOk()
        {
            return cppPath != "" 
                   && hPath != "" 
                   && textBoxModelName.Text != "" 
                   && textBoxSolution.Text != "" 
                   && textBoxMsBuild.Text != "" 
                   && textBoxTarget.Text != "";
        }

        #region buttonEvents
        private void btnGenerateDll_Click(object sender, EventArgs e)
        {
            if (AllFieldsOk())
            {
                createDll dll = new createDll();
                dll.CreateFile(hPath, cppPath, textBoxModelName.Text);
                textBoxModelName.Text = "";
            }
        }
        private void btnHeaderFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openH = new OpenFileDialog();
            openH.Filter = "h files(*.h)|*.h";
            if (openH.ShowDialog() == DialogResult.OK)
            {
                string hFileName = openH.FileName;
                hPath = hFileName;
                txtBoxH.Text = hFileName;
                txtBoxH.SelectionStart = txtBoxH.Text.Length;
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
                txtBoxCpp.SelectionStart = txtBoxCpp.Text.Length;
            }
        }
        private void btnMSBuild_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
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

        #endregion

        private void buttonLoadModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDll = new OpenFileDialog();
            openDll.Filter = "dll files(*.dll)|*.dll";
            if (openDll.ShowDialog() == DialogResult.OK)
            {
                string dllFileName = openDll.FileName;
                textBoxDll.Text = dllFileName;
                textBoxDll.SelectionStart = txtBoxCpp.Text.Length;
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            SimulinkModel model=new SimulinkModel(textBoxDll.Text);
            if (!keyValue.ContainsKey(model.name)){
                componentListBox.Items.Add(model.name);
                keyValue.Add(model.name, model);
            }
        }

        private void CreateInputs(SimulinkModel model)
        {
            listBoxInputs.Items.Clear();
            listBoxOutSignals.Items.Clear();
            for (int i = 0; i < model.GetInSignals().Count; i++)
            {
                listBoxInputs.Items.Add(model.GetInSignals()[i].GetSignalName()+"\t\t"+ model.GetInSignals()[i].GetSignal());
            }
            for (int i = 0; i < model.GetOutSignals().Count; i++)
            {
                listBoxOutSignals.Items.Add(model.GetOutSignals()[i].GetSignalName() + "\t\t" + model.GetOutSignals()[i].GetSignal());
            }  
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            selectedModel.Step();
            CreateInputs(selectedModel);
        }

        private void componentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (componentListBox.SelectedIndex != -1)
            {
                string name = componentListBox.SelectedItem.ToString();
                selectedModel = keyValue[name];
                CreateInputs(selectedModel);
            }
        }

        private void buttonConnectSignal_Click(object sender, EventArgs e)
        {
            double value;
            if (listBoxInputs.SelectedIndex != -1 && Double.TryParse(inputValueBox.Text,out value))
            {
                selectedModel.GetInSignals()[listBoxInputs.SelectedIndex].SetSignal(value);
                CreateInputs(selectedModel);
            }
        }
    }
}
