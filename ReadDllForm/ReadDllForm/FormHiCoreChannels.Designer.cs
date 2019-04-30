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
        /// Required method for Designer support - do not update
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxHiCoreChannels = new System.Windows.Forms.ListBox();
            this.btnSelectChannel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxHiCoreChannels
            // 
            this.listBoxHiCoreChannels.FormattingEnabled = true;
            this.listBoxHiCoreChannels.ItemHeight = 16;
            this.listBoxHiCoreChannels.Location = new System.Drawing.Point(12, 22);
            this.listBoxHiCoreChannels.Name = "listBoxHiCoreChannels";
            this.listBoxHiCoreChannels.Size = new System.Drawing.Size(411, 340);
            this.listBoxHiCoreChannels.TabIndex = 0;
            this.listBoxHiCoreChannels.SelectedIndexChanged += new System.EventHandler(this.listBoxHiCoreChannels_SelectedIndexChanged);
            // 
            // btnSelectChannel
            // 
            this.btnSelectChannel.Location = new System.Drawing.Point(337, 380);
            this.btnSelectChannel.Name = "btnSelectChannel";
            this.btnSelectChannel.Size = new System.Drawing.Size(86, 31);
            this.btnSelectChannel.TabIndex = 1;
            this.btnSelectChannel.Text = "Select";
            this.btnSelectChannel.UseVisualStyleBackColor = true;
            this.btnSelectChannel.Click += new System.EventHandler(this.btnSelectChannel_Click);
            // 
            // FormHiCoreChannels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 428);
            this.Controls.Add(this.btnSelectChannel);
            this.Controls.Add(this.listBoxHiCoreChannels);
            this.Name = "FormHiCoreChannels";
            this.Text = "FormHiCoreChannels";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHiCoreChannels;
        private System.Windows.Forms.Button btnSelectChannel;
    }
}