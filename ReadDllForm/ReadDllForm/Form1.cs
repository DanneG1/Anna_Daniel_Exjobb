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
        private int count=0;
        private List<SimulinkModel> models = new List<SimulinkModel>();
        private Dictionary<string,SimulinkModel> keyValue=new Dictionary<string, SimulinkModel>();
        private SimulinkModel selectedModel;
        private List<ISignal> inSignals=new List<ISignal>();
        private List<ISignal> outSignals=new List<ISignal>();

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
            componentListBox.Items.Add(model.name);
            keyValue.Add(model.name, model);
            models.Add(model);
        }

        private void CreateInputs(SimulinkModel model)
        {
            
            listBoxInputs.Items.Clear();
            listBoxOutSignals.Items.Clear();
            inSignals = model.GetInSignals();
            outSignals = model.GetOutSignals();
            for (int i = 0; i < inSignals.Count; i++)
            {
                listBoxInputs.Items.Add(inSignals[i].GetSignalName()+"\t\t"+inSignals[i].GetSignal());
            }
            for (int i = 0; i < outSignals.Count; i++)
            {
                listBoxOutSignals.Items.Add(outSignals[i].GetSignalName() + "\t\t" + outSignals[i].GetSignal());
            }
            /*
            for (int i = 0; i < inSignals.Count; i++)
                {
                
                    Label lb1 = new Label();
                    count++;
                    lb1.Name = "InSignal" + count;
                    lb1.Text = inSignals[i].GetSignalName();
                    lb1.Location = new Point(20, +40 * count + 20);
                    lb1.AutoSize = true;
                    //inSignalPanel.Controls.Add(lb1);

                    TextBox txt = new TextBox();
                    txt.Text = inSignals[i].GetSignal().ToString();
                    txt.AutoSize = true;
                    txt.MinimumSize = new Size(20, 20);
                    txt.Location = new Point(50, 40 * count + 20);
                    //inSignalPanel.Controls.Add(txt);

                    //textboxen kommer att bli dubbellänkad om flera komponenter laddas in, tack vare "tag i" inte blir unik
                    txt.Tag = i;
                    txt.TextChanged += delegate {
                        if (txt.Text != "")
                        {
                            inSignals[Convert.ToInt32(txt.Tag)].SetSignal(Convert.ToDouble(txt.Text));
                        }
                    };*/

                //}
            //}     
        }
        private void buttonStep_Click(object sender, EventArgs e)
        {
            foreach (var modell in models)
            {
                modell.Step();
                CreateInputs(selectedModel);
                //textBoxModel.Text += modell.GetSignalsAsString();
            }
        }

        private void componentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = componentListBox.SelectedItem.ToString();
            selectedModel = keyValue[name];
            CreateInputs(selectedModel);
        }

       

        private void listBoxInputs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxInputs_DoubleClick(object sender, EventArgs e)
        {
           

            //listBoxInputs.SelectedItem
        }

        private void buttonConnectSignal_Click(object sender, EventArgs e)
        {
            inSignals[listBoxInputs.SelectedIndex].SetSignal(6);
           
            CreateInputs(selectedModel);
        }
    }
}
