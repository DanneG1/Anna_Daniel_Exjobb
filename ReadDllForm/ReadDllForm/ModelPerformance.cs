using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadDllForm
{
    public partial class ModelPerformance : Form
    {
        private  Dictionary<string,SimulinkModel> _modelsDirectory = new Dictionary<string, SimulinkModel>();
        private SimulinkModel _selectedModel;
        public ModelPerformance(Dictionary<string,SimulinkModel> _mD)
        {
            InitializeComponent();
            setModelDict(_mD);
        }

        public void setModelDict(Dictionary<string,SimulinkModel> _mD)
        {
            _modelsDirectory = _mD;
            foreach(var model in _modelsDirectory.Values)
            {
                componentListBox.Items.Add(model.GetName());
            }
            componentListBox.SelectedIndex = 0;
            _selectedModel = _modelsDirectory[componentListBox.SelectedItem.ToString()];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModelPerformance_Load(object sender, EventArgs e)
        {

        }
        private void updateLabels()
        {
            if (_selectedModel.TimeSample!=null)
            {
                try
                {
                    maxRuntimeInfo.Text = Math.Round(_selectedModel.TimeSample.Max(), 4).ToString();
                    minRuntimeInfo.Text = Math.Round(_selectedModel.TimeSample.Min(), 4).ToString();
                    double sum = 0;
                    foreach (var time in _selectedModel.TimeSample)
                    {
                        sum += time;
                    }
                    meanRuntimeInfo.Text = Math.Round((sum / _selectedModel.TimeSample.Count), 4).ToString();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            updateLabels();
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void componentListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (componentListBox.SelectedIndex != -1)
            {
                string name = componentListBox.SelectedItem.ToString();
                _selectedModel = _modelsDirectory[name];
               // modelNameLabel.Text = name;
                runtimeBox1.Text = "Runtime: " + name;
                updateLabels();
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
