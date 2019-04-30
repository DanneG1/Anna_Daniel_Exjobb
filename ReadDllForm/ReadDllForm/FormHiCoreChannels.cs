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
    public partial class FormHiCoreChannels : Form
    {
        public string selectedChannel { get; set; }

        public FormHiCoreChannels(List<string>channels)
        {
            InitializeComponent();
            foreach (var channel in channels)
            {
                listBoxHiCoreChannels.Items.Add(channel);
            }
            
        }

        private void listBoxHiCoreChannels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectChannel_Click(object sender, EventArgs e)
        {
            this.selectedChannel = listBoxHiCoreChannels.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
