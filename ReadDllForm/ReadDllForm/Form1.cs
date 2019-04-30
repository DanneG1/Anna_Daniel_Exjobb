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
using HiQ.HiMacs.HiServices;
using HiQ.HiMacs.WCF;
using HiQ.HiMacs.WCF.Client;


namespace ReadDllForm
{
    public partial class Form1 : Form
    {
        private const string Solution = "Solution";
        private const string MsBuild = "MsBuild";
        private const string TargetFolder = "TargetFolder";
        private const string ModelFilePath = "ModelFilePath";
        private string _hPath;
        private string _cppPath;
        private readonly Dictionary<string,SimulinkModel> _modelsDictionary=new Dictionary<string, SimulinkModel>();
        private SimulinkModel _selectedModel;
        private HiQ.HiMacs.WCF.Client.HiCoreClient _hiCore;

        public Form1()
        {
            InitializeComponent();
            //listViewInSignals.Columns.Add("Name",20,HorizontalAlignment.Left);
            //listViewInSignals.Columns.Add("Value",20, HorizontalAlignment.Left);
            //listViewInSignals.Columns.Add("HiCChannel",20, HorizontalAlignment.Left);
            
            FillOutFieldsFromSettings();
            
            Load += (s, e) =>
            {
                if (!this.DesignMode)
                {
                    OpenHiCoreConnection();
                }
            };
        }

        private void OpenHiCoreConnection()
        {
            try
            {
                if (_hiCore == null)
                {
                    _hiCore = new HiCoreClient();
                    _hiCore.ConnectionOpened += OnHiCoreConnectionOpened;
                    _hiCore.ConnectionClosed += OnHiCoreConnectionClosed;
                }
                _hiCore.Connect();
            }
            catch(Exception e)
            {
            }
        }

        private async void OnHiCoreConnectionOpened(object sender, EventArgs e)
        {
            await Task.Delay(5000);
            ThreadSafeRequest(() => HandleConnectionOpened());
        }
        private async void OnHiCoreConnectionClosed(object sender, EventArgs e)
        {
            await Task.Delay(5000);
            ThreadSafeRequest(() => HandleConnectionClosed());
        }

        private void ThreadSafeRequest(Action action)
        {
            BeginInvoke(new MethodInvoker(delegate { action(); }));

        }

        private void HandleConnectionOpened()
        {
            labelHiCoreConnection.ForeColor = Color.Green;
            labelHiCoreConnection.Text = "Connected";
            buttonLoadModel.Enabled = true;
            panelModelAndSignals.Enabled = true;

        }

        private void HandleConnectionClosed()
        {

            labelHiCoreConnection.ForeColor = Color.Red;
            labelHiCoreConnection.Text = "Disconnected";
            buttonLoadModel.Enabled = false;
            panelModelAndSignals.Enabled = false;
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
            return _cppPath != "" 
                   && _hPath != "" 
                   && textBoxModelName.Text != "" 
                   && textBoxSolution.Text != "" 
                   && textBoxMsBuild.Text != "" 
                   && textBoxTarget.Text != "";
        }
     
        private void ShowSignals(SimulinkModel model)
        {
            listViewInSignals.Items.Clear();
            listViewOutSignals.Items.Clear();
            for (int i = 0; i < model.GetInSignals().Count; i++)
            {
                ListViewItem listViewItem=new ListViewItem(model.GetInSignals()[i].GetSignalName());
                listViewItem.SubItems.Add(model.GetInSignals()[i].GetSignal().ToString());
                listViewItem.SubItems.Add(model.GetInSignals()[i].GetChannelName());
                listViewInSignals.Items.Add(listViewItem);
                listViewInSignals.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewInSignals.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            for (int i = 0; i < model.GetOutSignals().Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(model.GetOutSignals()[i].GetSignalName());
                listViewItem.SubItems.Add(model.GetOutSignals()[i].GetSignal().ToString());
                listViewItem.SubItems.Add(model.GetOutSignals()[i].GetChannelName());
                listViewOutSignals.Items.Add(listViewItem);
                listViewOutSignals.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewOutSignals.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }  
        }
        private void componentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (componentListBox.SelectedIndex != -1)
            {
                string name = componentListBox.SelectedItem.ToString();
                _selectedModel = _modelsDictionary[name];
                ShowSignals(_selectedModel);
                worstTimeLabel.Text = _selectedModel.getWorstTime();
            }
        }

        #region buttonEvents
        private void btnGenerateDll_Click(object sender, EventArgs e)
        {
            if (AllFieldsOk())
            {
                CreateDll dll = new CreateDll();
                dll.CreateFile(_hPath, _cppPath, textBoxModelName.Text);
                textBoxModelName.Text = "";
            }
        }
        private void btnHeaderFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openH = new OpenFileDialog();
            openH.Filter = @"h files(*.h)|*.h";
            if (Settings.Default[ModelFilePath].ToString() != "")
            {
                openH.InitialDirectory = Path.GetDirectoryName(Settings.Default[ModelFilePath].ToString());
            }
            if (openH.ShowDialog() == DialogResult.OK)
            {
                string hFileName = openH.FileName;
                _hPath = hFileName;
                txtBoxH.Text = hFileName;
                txtBoxH.SelectionStart = txtBoxH.Text.Length;
                Settings.Default[ModelFilePath] = openH.FileName;
                Settings.Default.Save();
            }
        }
        private void btnCppFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openCpp = new OpenFileDialog();
            openCpp.Filter = @"cpp files(*.cpp)|*.cpp";
            if (Settings.Default[ModelFilePath].ToString() != "")
            {
                openCpp.InitialDirectory = Path.GetDirectoryName(Settings.Default[ModelFilePath].ToString());
            }
            if (openCpp.ShowDialog() == DialogResult.OK)
            {
                string cppFileName = openCpp.FileName;
                _cppPath = cppFileName;
                txtBoxCpp.Text = cppFileName;
                Settings.Default[ModelFilePath] = openCpp.FileName;
                Settings.Default.Save();
                txtBoxCpp.SelectionStart = txtBoxCpp.Text.Length;
            }
        }
        private void btnMSBuild_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Settings.Default[MsBuild] = open.FileName;

                textBoxMsBuild.Text = Settings.Default[MsBuild].ToString();
                Settings.Default.Save();
            }
        }
        private void btnSolution_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = @"Solution(*.sln)|*.sln";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Settings.Default[Solution] = open.FileName;

                textBoxSolution.Text = Settings.Default[Solution].ToString();
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
                    Settings.Default[TargetFolder] = fbd.SelectedPath;

                    textBoxTarget.Text = Settings.Default[TargetFolder].ToString();
                    Settings.Default.Save();
                }
            }

        }
        private void buttonRemoveModel_Click(object sender, EventArgs e)
        {
            if (componentListBox.SelectedIndex != -1)
            {
                string message = $@"Are you sure you want to remove model {componentListBox.SelectedItem}";
                string title = "Remove model";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    _modelsDictionary.Remove(componentListBox.SelectedItem.ToString());
                    componentListBox.Items.Remove(componentListBox.SelectedItem.ToString());
                    listViewInSignals.Items.Clear();
                    listViewOutSignals.Items.Clear();
                }
            }
            else
            {
                string message = "Select a model to remove.";
                string title = "Message";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);

            }
        }
        private void buttonConnectInSignal_Click(object sender, EventArgs e)
        {
            if (listViewInSignals.SelectedItems.Count>0)
            {
            FormHiCoreChannels hiCoreChannels=new FormHiCoreChannels(_hiCore.GetChannelNames("HiModels"), _selectedModel.GetInSignals()[listViewInSignals.SelectedIndices[0]].GetSignalName());
            var result = hiCoreChannels.ShowDialog();
            if (result == DialogResult.OK)
            {
                string channelName = hiCoreChannels.selectedChannel;
                _selectedModel.GetInSignals()[listViewInSignals.SelectedIndices[0]].SetChannelName(channelName);
                _selectedModel.GetInSignals()[listViewInSignals.SelectedIndices[0]].update();
                ShowSignals(_selectedModel);
            }
               
            }
            else
            {
                string message = "Select a insignal to connect to a channel.";
                string title = "Message";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
            }
        }

        private void btnConnectOutsignal_Click(object sender, EventArgs e)
        {


            if (listViewOutSignals.SelectedItems.Count > 0)
            {
                FormHiCoreChannels hiCoreChannels = new FormHiCoreChannels(_hiCore.GetChannelNames("HiModels"), _selectedModel.GetOutSignals()[listViewOutSignals.SelectedIndices[0]].GetSignalName());
                var result = hiCoreChannels.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string channelName = hiCoreChannels.selectedChannel;
                    _selectedModel.GetOutSignals()[listViewOutSignals.SelectedIndices[0]].SetChannelName(channelName);

                    ShowSignals(_selectedModel);
                }
            }

            else
            {
                string message = "Select a insignal to connect to a channel.";
                string title = "Message";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
            }
        }
        private void buttonBrowseModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDll = new OpenFileDialog();
            if (Settings.Default[TargetFolder].ToString() != "")
            {
                openDll.InitialDirectory = Settings.Default[TargetFolder].ToString();
            }

            openDll.Filter = @"dll files(*.dll)|*.dll";
            if (openDll.ShowDialog() == DialogResult.OK)
            {
                string dllFileName = openDll.FileName;
                textBoxDll.Text = dllFileName;
                textBoxDll.SelectionStart = txtBoxCpp.Text.Length;
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            SimulinkModel model = new SimulinkModel(textBoxDll.Text,_hiCore);
            if (!_modelsDictionary.ContainsKey(model.GetName()))
            {
                componentListBox.Items.Add(model.GetName());
                _modelsDictionary.Add(model.GetName(), model);
                if (model.getRunning())
                {
                    buttonRunModel.Text = "Stop model";
                }
                else
                {
                    buttonRunModel.Text = "Run model";
                }
            }
        }
  
        private void buttonStep_Click(object sender, EventArgs e)
        {
            if (componentListBox.SelectedIndex != -1)
            {
                _selectedModel.Step();
                ShowSignals(_selectedModel);
            }
            
        }



        #endregion

        private void buttonRunModel_Click(object sender, EventArgs e)
        {
            if (_selectedModel.getRunning())
            {
                _selectedModel.setRunning(false);
                buttonRunModel.Text = "Run model";
                timerUpdateLists.Stop();
                _selectedModel.StopRun();
            }
            else
            {
                _selectedModel.setRunning(true);
                buttonRunModel.Text = "Stop model";
                _selectedModel.setSleep(Convert.ToInt32(textBoxFrequency.Text));
                _selectedModel.Run();
                timerUpdateLists.Start();
            }
        }

        private void timerUpdateLists_Tick(object sender, EventArgs e)
        {
            ShowSignals(_selectedModel);
        }
    }
}
