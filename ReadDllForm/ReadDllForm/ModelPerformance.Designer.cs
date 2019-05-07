namespace ReadDllForm
{
    partial class ModelPerformance
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.componentListBox = new System.Windows.Forms.ListBox();
            this.minRuntimeLabel = new System.Windows.Forms.Label();
            this.maxRuntimeLabel = new System.Windows.Forms.Label();
            this.meanRuntimeLabel = new System.Windows.Forms.Label();
            this.runtimeBox1 = new System.Windows.Forms.GroupBox();
            this.minRuntimeInfo = new System.Windows.Forms.Label();
            this.meanRuntimeInfo = new System.Windows.Forms.Label();
            this.maxRuntimeInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.runtimeBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // componentListBox
            // 
            this.componentListBox.FormattingEnabled = true;
            this.componentListBox.ItemHeight = 24;
            this.componentListBox.Location = new System.Drawing.Point(44, 51);
            this.componentListBox.Name = "componentListBox";
            this.componentListBox.Size = new System.Drawing.Size(206, 316);
            this.componentListBox.TabIndex = 0;
            // 
            // minRuntimeLabel
            // 
            this.minRuntimeLabel.AutoSize = true;
            this.minRuntimeLabel.Location = new System.Drawing.Point(32, 56);
            this.minRuntimeLabel.Name = "minRuntimeLabel";
            this.minRuntimeLabel.Size = new System.Drawing.Size(49, 25);
            this.minRuntimeLabel.TabIndex = 1;
            this.minRuntimeLabel.Text = "min:";
            this.minRuntimeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // maxRuntimeLabel
            // 
            this.maxRuntimeLabel.AutoSize = true;
            this.maxRuntimeLabel.Location = new System.Drawing.Point(26, 131);
            this.maxRuntimeLabel.Name = "maxRuntimeLabel";
            this.maxRuntimeLabel.Size = new System.Drawing.Size(55, 25);
            this.maxRuntimeLabel.TabIndex = 2;
            this.maxRuntimeLabel.Text = "max:";
            // 
            // meanRuntimeLabel
            // 
            this.meanRuntimeLabel.AutoSize = true;
            this.meanRuntimeLabel.Location = new System.Drawing.Point(14, 93);
            this.meanRuntimeLabel.Name = "meanRuntimeLabel";
            this.meanRuntimeLabel.Size = new System.Drawing.Size(67, 25);
            this.meanRuntimeLabel.TabIndex = 3;
            this.meanRuntimeLabel.Text = "mean:";
            // 
            // runtimeBox1
            // 
            this.runtimeBox1.Controls.Add(this.maxRuntimeInfo);
            this.runtimeBox1.Controls.Add(this.meanRuntimeInfo);
            this.runtimeBox1.Controls.Add(this.minRuntimeInfo);
            this.runtimeBox1.Controls.Add(this.maxRuntimeLabel);
            this.runtimeBox1.Controls.Add(this.meanRuntimeLabel);
            this.runtimeBox1.Controls.Add(this.minRuntimeLabel);
            this.runtimeBox1.Location = new System.Drawing.Point(352, 51);
            this.runtimeBox1.Name = "runtimeBox1";
            this.runtimeBox1.Size = new System.Drawing.Size(346, 194);
            this.runtimeBox1.TabIndex = 4;
            this.runtimeBox1.TabStop = false;
            this.runtimeBox1.Text = "Runtime";
            // 
            // minRuntimeInfo
            // 
            this.minRuntimeInfo.AutoSize = true;
            this.minRuntimeInfo.Location = new System.Drawing.Point(109, 56);
            this.minRuntimeInfo.Name = "minRuntimeInfo";
            this.minRuntimeInfo.Size = new System.Drawing.Size(19, 25);
            this.minRuntimeInfo.TabIndex = 4;
            this.minRuntimeInfo.Text = "-";
            // 
            // meanRuntimeInfo
            // 
            this.meanRuntimeInfo.AutoSize = true;
            this.meanRuntimeInfo.Location = new System.Drawing.Point(109, 93);
            this.meanRuntimeInfo.Name = "meanRuntimeInfo";
            this.meanRuntimeInfo.Size = new System.Drawing.Size(19, 25);
            this.meanRuntimeInfo.TabIndex = 5;
            this.meanRuntimeInfo.Text = "-";
            // 
            // maxRuntimeInfo
            // 
            this.maxRuntimeInfo.AutoSize = true;
            this.maxRuntimeInfo.Location = new System.Drawing.Point(109, 131);
            this.maxRuntimeInfo.Name = "maxRuntimeInfo";
            this.maxRuntimeInfo.Size = new System.Drawing.Size(19, 25);
            this.maxRuntimeInfo.TabIndex = 6;
            this.maxRuntimeInfo.Text = "-";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            // 
            // ModelPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.runtimeBox1);
            this.Controls.Add(this.componentListBox);
            this.Name = "ModelPerformance";
            this.Text = "ModelPerformance";
            this.Load += new System.EventHandler(this.ModelPerformance_Load);
            this.runtimeBox1.ResumeLayout(false);
            this.runtimeBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox componentListBox;
        private System.Windows.Forms.Label minRuntimeLabel;
        private System.Windows.Forms.Label maxRuntimeLabel;
        private System.Windows.Forms.Label meanRuntimeLabel;
        private System.Windows.Forms.GroupBox runtimeBox1;
        private System.Windows.Forms.Label maxRuntimeInfo;
        private System.Windows.Forms.Label meanRuntimeInfo;
        private System.Windows.Forms.Label minRuntimeInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}