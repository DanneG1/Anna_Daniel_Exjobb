namespace ReadDllForm
{
    partial class Form1
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
            this.btnHeaderFile = new System.Windows.Forms.Button();
            this.btnCppFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBoxH = new System.Windows.Forms.TextBox();
            this.txtBoxCpp = new System.Windows.Forms.TextBox();
            this.btnGenerateDll = new System.Windows.Forms.Button();
            this.textBoxSolution = new System.Windows.Forms.TextBox();
            this.btnSolution = new System.Windows.Forms.Button();
            this.btnMSBuild = new System.Windows.Forms.Button();
            this.textBoxMsBuild = new System.Windows.Forms.TextBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.btnTargetFolder = new System.Windows.Forms.Button();
            this.textBoxModelName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControlInputs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonConnectSignal = new System.Windows.Forms.Button();
            this.groupBoxModels = new System.Windows.Forms.GroupBox();
            this.componentListBox = new System.Windows.Forms.ListBox();
            this.outSignalBox = new System.Windows.Forms.GroupBox();
            this.listBoxOutSignals = new System.Windows.Forms.ListBox();
            this.buttonStep = new System.Windows.Forms.Button();
            this.groupBoxInSignals = new System.Windows.Forms.GroupBox();
            this.listBoxInputs = new System.Windows.Forms.ListBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelModelLoad = new System.Windows.Forms.Label();
            this.textBoxDll = new System.Windows.Forms.TextBox();
            this.buttonLoadModel = new System.Windows.Forms.Button();
            this.inputValueBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlInputs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxModels.SuspendLayout();
            this.outSignalBox.SuspendLayout();
            this.groupBoxInSignals.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHeaderFile
            // 
            this.btnHeaderFile.Location = new System.Drawing.Point(366, 52);
            this.btnHeaderFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHeaderFile.Name = "btnHeaderFile";
            this.btnHeaderFile.Size = new System.Drawing.Size(103, 45);
            this.btnHeaderFile.TabIndex = 0;
            this.btnHeaderFile.Text = ".h";
            this.btnHeaderFile.UseVisualStyleBackColor = true;
            this.btnHeaderFile.Click += new System.EventHandler(this.btnHeaderFile_Click);
            // 
            // btnCppFile
            // 
            this.btnCppFile.Location = new System.Drawing.Point(366, 128);
            this.btnCppFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCppFile.Name = "btnCppFile";
            this.btnCppFile.Size = new System.Drawing.Size(103, 45);
            this.btnCppFile.TabIndex = 1;
            this.btnCppFile.Text = ".cpp";
            this.btnCppFile.UseVisualStyleBackColor = true;
            this.btnCppFile.Click += new System.EventHandler(this.btnCppFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtBoxH
            // 
            this.txtBoxH.Location = new System.Drawing.Point(8, 58);
            this.txtBoxH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxH.Name = "txtBoxH";
            this.txtBoxH.Size = new System.Drawing.Size(333, 29);
            this.txtBoxH.TabIndex = 2;
            // 
            // txtBoxCpp
            // 
            this.txtBoxCpp.Location = new System.Drawing.Point(8, 134);
            this.txtBoxCpp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCpp.Name = "txtBoxCpp";
            this.txtBoxCpp.Size = new System.Drawing.Size(333, 29);
            this.txtBoxCpp.TabIndex = 3;
            // 
            // btnGenerateDll
            // 
            this.btnGenerateDll.Location = new System.Drawing.Point(924, 470);
            this.btnGenerateDll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerateDll.Name = "btnGenerateDll";
            this.btnGenerateDll.Size = new System.Drawing.Size(133, 45);
            this.btnGenerateDll.TabIndex = 4;
            this.btnGenerateDll.Text = "Generate Dll";
            this.btnGenerateDll.UseVisualStyleBackColor = true;
            this.btnGenerateDll.Click += new System.EventHandler(this.btnGenerateDll_Click);
            // 
            // textBoxSolution
            // 
            this.textBoxSolution.Location = new System.Drawing.Point(8, 58);
            this.textBoxSolution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSolution.Name = "textBoxSolution";
            this.textBoxSolution.Size = new System.Drawing.Size(342, 29);
            this.textBoxSolution.TabIndex = 6;
            // 
            // btnSolution
            // 
            this.btnSolution.Location = new System.Drawing.Point(380, 52);
            this.btnSolution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(103, 45);
            this.btnSolution.TabIndex = 7;
            this.btnSolution.Text = "Solution";
            this.btnSolution.UseVisualStyleBackColor = true;
            this.btnSolution.Click += new System.EventHandler(this.btnSolution_Click);
            // 
            // btnMSBuild
            // 
            this.btnMSBuild.Location = new System.Drawing.Point(380, 130);
            this.btnMSBuild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMSBuild.Name = "btnMSBuild";
            this.btnMSBuild.Size = new System.Drawing.Size(103, 45);
            this.btnMSBuild.TabIndex = 8;
            this.btnMSBuild.Text = "MSBuild";
            this.btnMSBuild.UseVisualStyleBackColor = true;
            this.btnMSBuild.Click += new System.EventHandler(this.btnMSBuild_Click);
            // 
            // textBoxMsBuild
            // 
            this.textBoxMsBuild.Location = new System.Drawing.Point(8, 134);
            this.textBoxMsBuild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMsBuild.Name = "textBoxMsBuild";
            this.textBoxMsBuild.Size = new System.Drawing.Size(342, 29);
            this.textBoxMsBuild.TabIndex = 9;
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(8, 213);
            this.textBoxTarget.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(342, 29);
            this.textBoxTarget.TabIndex = 11;
            // 
            // btnTargetFolder
            // 
            this.btnTargetFolder.Location = new System.Drawing.Point(380, 207);
            this.btnTargetFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTargetFolder.Name = "btnTargetFolder";
            this.btnTargetFolder.Size = new System.Drawing.Size(103, 45);
            this.btnTargetFolder.TabIndex = 10;
            this.btnTargetFolder.Text = "Target";
            this.btnTargetFolder.UseVisualStyleBackColor = true;
            this.btnTargetFolder.Click += new System.EventHandler(this.btnTargetFolder_Click);
            // 
            // textBoxModelName
            // 
            this.textBoxModelName.Location = new System.Drawing.Point(566, 476);
            this.textBoxModelName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxModelName.Name = "textBoxModelName";
            this.textBoxModelName.Size = new System.Drawing.Size(333, 29);
            this.textBoxModelName.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSolution);
            this.groupBox1.Controls.Add(this.btnSolution);
            this.groupBox1.Controls.Add(this.textBoxTarget);
            this.groupBox1.Controls.Add(this.btnMSBuild);
            this.groupBox1.Controls.Add(this.btnTargetFolder);
            this.groupBox1.Controls.Add(this.textBoxMsBuild);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(492, 278);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 480);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Model name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxH);
            this.groupBox2.Controls.Add(this.btnHeaderFile);
            this.groupBox2.Controls.Add(this.btnCppFile);
            this.groupBox2.Controls.Add(this.txtBoxCpp);
            this.groupBox2.Location = new System.Drawing.Point(558, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(499, 278);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generated Code Files";
            // 
            // tabControlInputs
            // 
            this.tabControlInputs.Controls.Add(this.tabPage1);
            this.tabControlInputs.Controls.Add(this.tabPage2);
            this.tabControlInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInputs.Location = new System.Drawing.Point(0, 0);
            this.tabControlInputs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlInputs.Name = "tabControlInputs";
            this.tabControlInputs.SelectedIndex = 0;
            this.tabControlInputs.Size = new System.Drawing.Size(1250, 675);
            this.tabControlInputs.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxModelName);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnGenerateDll);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1242, 638);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Model";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.inputValueBox);
            this.tabPage2.Controls.Add(this.buttonConnectSignal);
            this.tabPage2.Controls.Add(this.groupBoxModels);
            this.tabPage2.Controls.Add(this.outSignalBox);
            this.tabPage2.Controls.Add(this.buttonStep);
            this.tabPage2.Controls.Add(this.groupBoxInSignals);
            this.tabPage2.Controls.Add(this.buttonLoad);
            this.tabPage2.Controls.Add(this.labelModelLoad);
            this.tabPage2.Controls.Add(this.textBoxDll);
            this.tabPage2.Controls.Add(this.buttonLoadModel);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1242, 638);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Load Model";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonConnectSignal
            // 
            this.buttonConnectSignal.Location = new System.Drawing.Point(496, 512);
            this.buttonConnectSignal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConnectSignal.Name = "buttonConnectSignal";
            this.buttonConnectSignal.Size = new System.Drawing.Size(165, 46);
            this.buttonConnectSignal.TabIndex = 7;
            this.buttonConnectSignal.Text = "Connect signal";
            this.buttonConnectSignal.UseVisualStyleBackColor = true;
            this.buttonConnectSignal.Click += new System.EventHandler(this.buttonConnectSignal_Click);
            // 
            // groupBoxModels
            // 
            this.groupBoxModels.Controls.Add(this.componentListBox);
            this.groupBoxModels.Location = new System.Drawing.Point(40, 170);
            this.groupBoxModels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxModels.Name = "groupBoxModels";
            this.groupBoxModels.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxModels.Size = new System.Drawing.Size(368, 340);
            this.groupBoxModels.TabIndex = 6;
            this.groupBoxModels.TabStop = false;
            this.groupBoxModels.Text = "Models";
            // 
            // componentListBox
            // 
            this.componentListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentListBox.FormattingEnabled = true;
            this.componentListBox.ItemHeight = 24;
            this.componentListBox.Location = new System.Drawing.Point(4, 26);
            this.componentListBox.Name = "componentListBox";
            this.componentListBox.Size = new System.Drawing.Size(360, 310);
            this.componentListBox.TabIndex = 7;
            this.componentListBox.SelectedIndexChanged += new System.EventHandler(this.componentListBox_SelectedIndexChanged);
            // 
            // outSignalBox
            // 
            this.outSignalBox.Controls.Add(this.listBoxOutSignals);
            this.outSignalBox.Location = new System.Drawing.Point(857, 170);
            this.outSignalBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outSignalBox.Name = "outSignalBox";
            this.outSignalBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outSignalBox.Size = new System.Drawing.Size(355, 332);
            this.outSignalBox.TabIndex = 6;
            this.outSignalBox.TabStop = false;
            this.outSignalBox.Text = "OutSignal";
            // 
            // listBoxOutSignals
            // 
            this.listBoxOutSignals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOutSignals.FormattingEnabled = true;
            this.listBoxOutSignals.HorizontalScrollbar = true;
            this.listBoxOutSignals.ItemHeight = 24;
            this.listBoxOutSignals.Location = new System.Drawing.Point(4, 26);
            this.listBoxOutSignals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxOutSignals.Name = "listBoxOutSignals";
            this.listBoxOutSignals.ScrollAlwaysVisible = true;
            this.listBoxOutSignals.Size = new System.Drawing.Size(347, 302);
            this.listBoxOutSignals.TabIndex = 1;
            // 
            // buttonStep
            // 
            this.buttonStep.Location = new System.Drawing.Point(1060, 534);
            this.buttonStep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(103, 48);
            this.buttonStep.TabIndex = 6;
            this.buttonStep.Text = "Step";
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // groupBoxInSignals
            // 
            this.groupBoxInSignals.Controls.Add(this.listBoxInputs);
            this.groupBoxInSignals.Location = new System.Drawing.Point(488, 170);
            this.groupBoxInSignals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxInSignals.Name = "groupBoxInSignals";
            this.groupBoxInSignals.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxInSignals.Size = new System.Drawing.Size(346, 332);
            this.groupBoxInSignals.TabIndex = 5;
            this.groupBoxInSignals.TabStop = false;
            this.groupBoxInSignals.Text = "InSignals";
            // 
            // listBoxInputs
            // 
            this.listBoxInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxInputs.FormattingEnabled = true;
            this.listBoxInputs.HorizontalScrollbar = true;
            this.listBoxInputs.ItemHeight = 24;
            this.listBoxInputs.Location = new System.Drawing.Point(4, 26);
            this.listBoxInputs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxInputs.Name = "listBoxInputs";
            this.listBoxInputs.ScrollAlwaysVisible = true;
            this.listBoxInputs.Size = new System.Drawing.Size(338, 302);
            this.listBoxInputs.TabIndex = 0;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(573, 32);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(175, 51);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load model";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelModelLoad
            // 
            this.labelModelLoad.AutoSize = true;
            this.labelModelLoad.Location = new System.Drawing.Point(11, 33);
            this.labelModelLoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModelLoad.Name = "labelModelLoad";
            this.labelModelLoad.Size = new System.Drawing.Size(120, 25);
            this.labelModelLoad.TabIndex = 2;
            this.labelModelLoad.Text = "Model (.dll) :";
            // 
            // textBoxDll
            // 
            this.textBoxDll.Location = new System.Drawing.Point(138, 33);
            this.textBoxDll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDll.Name = "textBoxDll";
            this.textBoxDll.Size = new System.Drawing.Size(294, 29);
            this.textBoxDll.TabIndex = 1;
            // 
            // buttonLoadModel
            // 
            this.buttonLoadModel.Location = new System.Drawing.Point(441, 33);
            this.buttonLoadModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadModel.Name = "buttonLoadModel";
            this.buttonLoadModel.Size = new System.Drawing.Size(103, 50);
            this.buttonLoadModel.TabIndex = 0;
            this.buttonLoadModel.Text = "Browse..";
            this.buttonLoadModel.UseVisualStyleBackColor = true;
            this.buttonLoadModel.Click += new System.EventHandler(this.buttonLoadModel_Click);
            // 
            // inputValueBox
            // 
            this.inputValueBox.Location = new System.Drawing.Point(680, 512);
            this.inputValueBox.Multiline = true;
            this.inputValueBox.Name = "inputValueBox";
            this.inputValueBox.Size = new System.Drawing.Size(154, 46);
            this.inputValueBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 675);
            this.Controls.Add(this.tabControlInputs);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "HiModels";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControlInputs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxModels.ResumeLayout(false);
            this.outSignalBox.ResumeLayout(false);
            this.groupBoxInSignals.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHeaderFile;
        private System.Windows.Forms.Button btnCppFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtBoxH;
        private System.Windows.Forms.TextBox txtBoxCpp;
        private System.Windows.Forms.Button btnGenerateDll;
        private System.Windows.Forms.TextBox textBoxSolution;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.Button btnMSBuild;
        private System.Windows.Forms.TextBox textBoxMsBuild;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.Button btnTargetFolder;
        private System.Windows.Forms.TextBox textBoxModelName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControlInputs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelModelLoad;
        private System.Windows.Forms.TextBox textBoxDll;
        private System.Windows.Forms.Button buttonLoadModel;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupBoxInSignals;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.ListBox componentListBox;
        private System.Windows.Forms.GroupBox outSignalBox;
        private System.Windows.Forms.GroupBox groupBoxModels;
        private System.Windows.Forms.ListBox listBoxInputs;
        private System.Windows.Forms.ListBox listBoxOutSignals;
        private System.Windows.Forms.Button buttonConnectSignal;
        private System.Windows.Forms.TextBox inputValueBox;
    }
}

