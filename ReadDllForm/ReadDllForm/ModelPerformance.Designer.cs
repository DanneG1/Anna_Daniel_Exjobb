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
            this.maxRuntimeInfo = new System.Windows.Forms.Label();
            this.meanRuntimeInfo = new System.Windows.Forms.Label();
            this.minRuntimeInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.modelsLabel = new System.Windows.Forms.Label();
            this.prefixLabel1 = new System.Windows.Forms.Label();
            this.prefixLabel2 = new System.Windows.Forms.Label();
            this.prefixLabel3 = new System.Windows.Forms.Label();
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
            this.componentListBox.SelectedIndexChanged += new System.EventHandler(this.componentListBox_SelectedIndexChanged_1);
            // 
            // minRuntimeLabel
            // 
            this.minRuntimeLabel.AutoSize = true;
            this.minRuntimeLabel.Location = new System.Drawing.Point(44, 41);
            this.minRuntimeLabel.Name = "minRuntimeLabel";
            this.minRuntimeLabel.Size = new System.Drawing.Size(49, 25);
            this.minRuntimeLabel.TabIndex = 1;
            this.minRuntimeLabel.Text = "min:";
            this.minRuntimeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // maxRuntimeLabel
            // 
            this.maxRuntimeLabel.AutoSize = true;
            this.maxRuntimeLabel.Location = new System.Drawing.Point(38, 116);
            this.maxRuntimeLabel.Name = "maxRuntimeLabel";
            this.maxRuntimeLabel.Size = new System.Drawing.Size(55, 25);
            this.maxRuntimeLabel.TabIndex = 2;
            this.maxRuntimeLabel.Text = "max:";
            // 
            // meanRuntimeLabel
            // 
            this.meanRuntimeLabel.AutoSize = true;
            this.meanRuntimeLabel.Location = new System.Drawing.Point(26, 78);
            this.meanRuntimeLabel.Name = "meanRuntimeLabel";
            this.meanRuntimeLabel.Size = new System.Drawing.Size(67, 25);
            this.meanRuntimeLabel.TabIndex = 3;
            this.meanRuntimeLabel.Text = "mean:";
            // 
            // runtimeBox1
            // 
            this.runtimeBox1.Controls.Add(this.prefixLabel3);
            this.runtimeBox1.Controls.Add(this.prefixLabel2);
            this.runtimeBox1.Controls.Add(this.prefixLabel1);
            this.runtimeBox1.Controls.Add(this.maxRuntimeInfo);
            this.runtimeBox1.Controls.Add(this.meanRuntimeInfo);
            this.runtimeBox1.Controls.Add(this.minRuntimeInfo);
            this.runtimeBox1.Controls.Add(this.maxRuntimeLabel);
            this.runtimeBox1.Controls.Add(this.meanRuntimeLabel);
            this.runtimeBox1.Controls.Add(this.minRuntimeLabel);
            this.runtimeBox1.Location = new System.Drawing.Point(352, 51);
            this.runtimeBox1.Name = "runtimeBox1";
            this.runtimeBox1.Size = new System.Drawing.Size(346, 316);
            this.runtimeBox1.TabIndex = 4;
            this.runtimeBox1.TabStop = false;
            this.runtimeBox1.Text = "Runtime";
            // 
            // maxRuntimeInfo
            // 
            this.maxRuntimeInfo.AutoSize = true;
            this.maxRuntimeInfo.Location = new System.Drawing.Point(121, 116);
            this.maxRuntimeInfo.Name = "maxRuntimeInfo";
            this.maxRuntimeInfo.Size = new System.Drawing.Size(19, 25);
            this.maxRuntimeInfo.TabIndex = 6;
            this.maxRuntimeInfo.Text = "-";
            // 
            // meanRuntimeInfo
            // 
            this.meanRuntimeInfo.AutoSize = true;
            this.meanRuntimeInfo.Location = new System.Drawing.Point(121, 78);
            this.meanRuntimeInfo.Name = "meanRuntimeInfo";
            this.meanRuntimeInfo.Size = new System.Drawing.Size(19, 25);
            this.meanRuntimeInfo.TabIndex = 5;
            this.meanRuntimeInfo.Text = "-";
            // 
            // minRuntimeInfo
            // 
            this.minRuntimeInfo.AutoSize = true;
            this.minRuntimeInfo.Location = new System.Drawing.Point(121, 41);
            this.minRuntimeInfo.Name = "minRuntimeInfo";
            this.minRuntimeInfo.Size = new System.Drawing.Size(19, 25);
            this.minRuntimeInfo.TabIndex = 4;
            this.minRuntimeInfo.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // modelsLabel
            // 
            this.modelsLabel.AutoSize = true;
            this.modelsLabel.Location = new System.Drawing.Point(44, 13);
            this.modelsLabel.Name = "modelsLabel";
            this.modelsLabel.Size = new System.Drawing.Size(82, 25);
            this.modelsLabel.TabIndex = 5;
            this.modelsLabel.Text = "Models:";
            this.modelsLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // prefixLabel1
            // 
            this.prefixLabel1.AutoSize = true;
            this.prefixLabel1.Location = new System.Drawing.Point(200, 41);
            this.prefixLabel1.Name = "prefixLabel1";
            this.prefixLabel1.Size = new System.Drawing.Size(38, 25);
            this.prefixLabel1.TabIndex = 8;
            this.prefixLabel1.Text = "ms";
            this.prefixLabel1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // prefixLabel2
            // 
            this.prefixLabel2.AutoSize = true;
            this.prefixLabel2.Location = new System.Drawing.Point(200, 78);
            this.prefixLabel2.Name = "prefixLabel2";
            this.prefixLabel2.Size = new System.Drawing.Size(38, 25);
            this.prefixLabel2.TabIndex = 9;
            this.prefixLabel2.Text = "ms";
            // 
            // prefixLabel3
            // 
            this.prefixLabel3.AutoSize = true;
            this.prefixLabel3.Location = new System.Drawing.Point(200, 116);
            this.prefixLabel3.Name = "prefixLabel3";
            this.prefixLabel3.Size = new System.Drawing.Size(38, 25);
            this.prefixLabel3.TabIndex = 10;
            this.prefixLabel3.Text = "ms";
            // 
            // ModelPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modelsLabel);
            this.Controls.Add(this.runtimeBox1);
            this.Controls.Add(this.componentListBox);
            this.Name = "ModelPerformance";
            this.Text = "ModelPerformance";
            this.Load += new System.EventHandler(this.ModelPerformance_Load);
            this.runtimeBox1.ResumeLayout(false);
            this.runtimeBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label modelsLabel;
        private System.Windows.Forms.Label prefixLabel1;
        private System.Windows.Forms.Label prefixLabel3;
        private System.Windows.Forms.Label prefixLabel2;
    }
}