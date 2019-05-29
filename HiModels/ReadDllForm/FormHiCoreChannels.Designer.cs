namespace ReadDllForm
{
    partial class FormHiCoreChannels
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not Update
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxHiCoreChannels = new System.Windows.Forms.ListBox();
            this.btnSelectChannel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSignalName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxHiCoreChannels
            // 
            this.listBoxHiCoreChannels.FormattingEnabled = true;
            this.listBoxHiCoreChannels.ItemHeight = 24;
            this.listBoxHiCoreChannels.Location = new System.Drawing.Point(16, 81);
            this.listBoxHiCoreChannels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxHiCoreChannels.Name = "listBoxHiCoreChannels";
            this.listBoxHiCoreChannels.Size = new System.Drawing.Size(564, 460);
            this.listBoxHiCoreChannels.TabIndex = 0;
            this.listBoxHiCoreChannels.SelectedIndexChanged += new System.EventHandler(this.listBoxHiCoreChannels_SelectedIndexChanged);
            // 
            // btnSelectChannel
            // 
            this.btnSelectChannel.Location = new System.Drawing.Point(463, 570);
            this.btnSelectChannel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectChannel.Name = "btnSelectChannel";
            this.btnSelectChannel.Size = new System.Drawing.Size(118, 46);
            this.btnSelectChannel.TabIndex = 1;
            this.btnSelectChannel.Text = "Select";
            this.btnSelectChannel.UseVisualStyleBackColor = true;
            this.btnSelectChannel.Click += new System.EventHandler(this.btnSelectChannel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Signal name:";
            // 
            // labelSignalName
            // 
            this.labelSignalName.AutoSize = true;
            this.labelSignalName.Location = new System.Drawing.Point(150, 18);
            this.labelSignalName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSignalName.Name = "labelSignalName";
            this.labelSignalName.Size = new System.Drawing.Size(0, 25);
            this.labelSignalName.TabIndex = 3;
            // 
            // FormHiCoreChannels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 642);
            this.Controls.Add(this.labelSignalName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectChannel);
            this.Controls.Add(this.listBoxHiCoreChannels);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormHiCoreChannels";
            this.Text = "Connect to channel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHiCoreChannels;
        private System.Windows.Forms.Button btnSelectChannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSignalName;
    }
}