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
        public ModelPerformance()
        {
            InitializeComponent();
        }

        public void setModelDict(Dictionary<string,SimulinkModel> _mD)
        {
            _modelsDirectory = _mD;
            foreach(var model in _modelsDirectory.Values)
            {
                componentListBox.Items.Add(model.GetName());
            }
        }

        private void componentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (componentListBox.SelectedIndex != -1)
            {
                string name = componentListBox.SelectedItem.ToString();
                _selectedModel  = _modelsDirectory[name];
            }
        }
        private void timerUpdateLists_Tick(object sender, EventArgs e)
        {
            maxRuntimeLabel.Text = _selectedModel.timeSample.Max().ToString();
            minRuntimeLabel.Text = _selectedModel.timeSample.Min().ToString();
            //meanRuntimeLabel.Text = _selectedModel.timeSample.;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModelPerformance_Load(object sender, EventArgs e)
        {

        }
    }
}
