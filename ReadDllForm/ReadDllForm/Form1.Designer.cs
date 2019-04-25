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
            this.groupBoxModels = new System.Windows.Forms.GroupBox();
            this.componentListBox = new System.Windows.Forms.ListBox();
            this.outSignalBox = new System.Windows.Forms.GroupBox();
            this.buttonStep = new System.Windows.Forms.Button();
            this.groupBoxInSignals = new System.Windows.Forms.GroupBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelModelLoad = new System.Windows.Forms.Label();
            this.textBoxDll = new System.Windows.Forms.TextBox();
            this.buttonLoadModel = new System.Windows.Forms.Button();
            this.listBoxInputs = new System.Windows.Forms.ListBox();
            this.listBoxOutSignals = new System.Windows.Forms.ListBox();
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
            this.btnHeaderFile.Location = new System.Drawing.Point(266, 35);
            this.btnHeaderFile.Name = "btnHeaderFile";
            this.btnHeaderFile.Size = new System.Drawing.Size(75, 30);
            this.btnHeaderFile.TabIndex = 0;
            this.btnHeaderFile.Text = ".h";
            this.btnHeaderFile.UseVisualStyleBackColor = true;
            this.btnHeaderFile.Click += new System.EventHandler(this.btnHeaderFile_Click);
            // 
            // btnCppFile
            // 
            this.btnCppFile.Location = new System.Drawing.Point(266, 85);
            this.btnCppFile.Name = "btnCppFile";
            this.btnCppFile.Size = new System.Drawing.Size(75, 30);
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
            this.txtBoxH.Location = new System.Drawing.Point(6, 39);
            this.txtBoxH.Name = "txtBoxH";
            this.txtBoxH.Size = new System.Drawing.Size(243, 22);
            this.txtBoxH.TabIndex = 2;
            // 
            // txtBoxCpp
            // 
            this.txtBoxCpp.Location = new System.Drawing.Point(6, 89);
            this.txtBoxCpp.Name = "txtBoxCpp";
            this.txtBoxCpp.Size = new System.Drawing.Size(243, 22);
            this.txtBoxCpp.TabIndex = 3;
            // 
            // btnGenerateDll
            // 
            this.btnGenerateDll.Location = new System.Drawing.Point(672, 313);
            this.btnGenerateDll.Name = "btnGenerateDll";
            this.btnGenerateDll.Size = new System.Drawing.Size(97, 30);
            this.btnGenerateDll.TabIndex = 4;
            this.btnGenerateDll.Text = "Generate Dll";
            this.btnGenerateDll.UseVisualStyleBackColor = true;
            this.btnGenerateDll.Click += new System.EventHandler(this.btnGenerateDll_Click);
            // 
            // textBoxSolution
            // 
            this.textBoxSolution.Location = new System.Drawing.Point(6, 39);
            this.textBoxSolution.Name = "textBoxSolution";
            this.textBoxSolution.Size = new System.Drawing.Size(250, 22);
            this.textBoxSolution.TabIndex = 6;
            // 
            // btnSolution
            // 
            this.btnSolution.Location = new System.Drawing.Point(276, 35);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(75, 30);
            this.btnSolution.TabIndex = 7;
            this.btnSolution.Text = "Solution";
            this.btnSolution.UseVisualStyleBackColor = true;
            this.btnSolution.Click += new System.EventHandler(this.btnSolution_Click);
            // 
            // btnMSBuild
            // 
            this.btnMSBuild.Location = new System.Drawing.Point(276, 87);
            this.btnMSBuild.Name = "btnMSBuild";
            this.btnMSBuild.Size = new System.Drawing.Size(75, 30);
            this.btnMSBuild.TabIndex = 8;
            this.btnMSBuild.Text = "MSBuild";
            this.btnMSBuild.UseVisualStyleBackColor = true;
            this.btnMSBuild.Click += new System.EventHandler(this.btnMSBuild_Click);
            // 
            // textBoxMsBuild
            // 
            this.textBoxMsBuild.Location = new System.Drawing.Point(6, 89);
            this.textBoxMsBuild.Name = "textBoxMsBuild";
            this.textBoxMsBuild.Size = new System.Drawing.Size(250, 22);
            this.textBoxMsBuild.TabIndex = 9;
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(6, 142);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(250, 22);
            this.textBoxTarget.TabIndex = 11;
            // 
            // btnTargetFolder
            // 
            this.btnTargetFolder.Location = new System.Drawing.Point(276, 138);
            this.btnTargetFolder.Name = "btnTargetFolder";
            this.btnTargetFolder.Size = new System.Drawing.Size(75, 30);
            this.btnTargetFolder.TabIndex = 10;
            this.btnTargetFolder.Text = "Target";
            this.btnTargetFolder.UseVisualStyleBackColor = true;
            this.btnTargetFolder.Click += new System.EventHandler(this.btnTargetFolder_Click);
            // 
            // textBoxModelName
            // 
            this.textBoxModelName.Location = new System.Drawing.Point(412, 317);
            this.textBoxModelName.Name = "textBoxModelName";
            this.textBoxModelName.Size = new System.Drawing.Size(243, 22);
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
            this.groupBox1.Location = new System.Drawing.Point(23, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 185);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Model name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxH);
            this.groupBox2.Controls.Add(this.btnHeaderFile);
            this.groupBox2.Controls.Add(this.btnCppFile);
            this.groupBox2.Controls.Add(this.txtBoxCpp);
            this.groupBox2.Location = new System.Drawing.Point(406, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 185);
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
            this.tabControlInputs.Name = "tabControlInputs";
            this.tabControlInputs.SelectedIndex = 0;
            this.tabControlInputs.Size = new System.Drawing.Size(909, 450);
            this.tabControlInputs.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxModelName);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnGenerateDll);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Model";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxModels);
            this.tabPage2.Controls.Add(this.outSignalBox);
            this.tabPage2.Controls.Add(this.buttonStep);
            this.tabPage2.Controls.Add(this.groupBoxInSignals);
            this.tabPage2.Controls.Add(this.buttonLoad);
            this.tabPage2.Controls.Add(this.labelModelLoad);
            this.tabPage2.Controls.Add(this.textBoxDll);
            this.tabPage2.Controls.Add(this.buttonLoadModel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Load Model";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxModels
            // 
            this.groupBoxModels.Controls.Add(this.componentListBox);
            this.groupBoxModels.Location = new System.Drawing.Point(29, 113);
            this.groupBoxModels.Name = "groupBoxModels";
            this.groupBoxModels.Size = new System.Drawing.Size(268, 227);
            this.groupBoxModels.TabIndex = 6;
            this.groupBoxModels.TabStop = false;
            this.groupBoxModels.Text = "Models";
            // 
            // componentListBox
            // 
            this.componentListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentListBox.FormattingEnabled = true;
            this.componentListBox.ItemHeight = 16;
            this.componentListBox.Location = new System.Drawing.Point(3, 18);
            this.componentListBox.Margin = new System.Windows.Forms.Padding(2);
            this.componentListBox.Name = "componentListBox";
            this.componentListBox.Size = new System.Drawing.Size(262, 206);
            this.componentListBox.TabIndex = 7;
            this.componentListBox.SelectedIndexChanged += new System.EventHandler(this.componentListBox_SelectedIndexChanged);
            // 
            // outSignalBox
            // 
            this.outSignalBox.Controls.Add(this.listBoxOutSignals);
            this.outSignalBox.Location = new System.Drawing.Point(623, 113);
            this.outSignalBox.Name = "outSignalBox";
            this.outSignalBox.Size = new System.Drawing.Size(258, 221);
            this.outSignalBox.TabIndex = 6;
            this.outSignalBox.TabStop = false;
            this.outSignalBox.Text = "OutSignal";
            // 
            // buttonStep
            // 
            this.buttonStep.Location = new System.Drawing.Point(771, 356);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(75, 32);
            this.buttonStep.TabIndex = 6;
            this.buttonStep.Text = "Step";
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // groupBoxInSignals
            // 
            this.groupBoxInSignals.Controls.Add(this.listBoxInputs);
            this.groupBoxInSignals.Location = new System.Drawing.Point(355, 113);
            this.groupBoxInSignals.Name = "groupBoxInSignals";
            this.groupBoxInSignals.Size = new System.Drawing.Size(252, 221);
            this.groupBoxInSignals.TabIndex = 5;
            this.groupBoxInSignals.TabStop = false;
            this.groupBoxInSignals.Text = "InSignals";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(417, 21);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(127, 34);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load model";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelModelLoad
            // 
            this.labelModelLoad.AutoSize = true;
            this.labelModelLoad.Location = new System.Drawing.Point(8, 22);
            this.labelModelLoad.Name = "labelModelLoad";
            this.labelModelLoad.Size = new System.Drawing.Size(86, 17);
            this.labelModelLoad.TabIndex = 2;
            this.labelModelLoad.Text = "Model (.dll) :";
            // 
            // textBoxDll
            // 
            this.textBoxDll.Location = new System.Drawing.Point(100, 22);
            this.textBoxDll.Name = "textBoxDll";
            this.textBoxDll.Size = new System.Drawing.Size(215, 22);
            this.textBoxDll.TabIndex = 1;
            // 
            // buttonLoadModel
            // 
            this.buttonLoadModel.Location = new System.Drawing.Point(321, 22);
            this.buttonLoadModel.Name = "buttonLoadModel";
            this.buttonLoadModel.Size = new System.Drawing.Size(75, 33);
            this.buttonLoadModel.TabIndex = 0;
            this.buttonLoadModel.Text = "Browse..";
            this.buttonLoadModel.UseVisualStyleBackColor = true;
            this.buttonLoadModel.Click += new System.EventHandler(this.buttonLoadModel_Click);
            // 
            // listBoxInputs
            // 
            this.listBoxInputs.FormattingEnabled = true;
            this.listBoxInputs.ItemHeight = 16;
            this.listBoxInputs.Location = new System.Drawing.Point(6, 35);
            this.listBoxInputs.Name = "listBoxInputs";
            this.listBoxInputs.Size = new System.Drawing.Size(218, 132);
            this.listBoxInputs.TabIndex = 0;
            this.listBoxInputs.SelectedIndexChanged += new System.EventHandler(this.listBoxInputs_SelectedIndexChanged);
            this.listBoxInputs.DoubleClick += new System.EventHandler(this.listBoxInputs_DoubleClick);
            // 
            // listBoxOutSignals
            // 
            this.listBoxOutSignals.FormattingEnabled = true;
            this.listBoxOutSignals.ItemHeight = 16;
            this.listBoxOutSignals.Location = new System.Drawing.Point(6, 35);
            this.listBoxOutSignals.Name = "listBoxOutSignals";
            this.listBoxOutSignals.Size = new System.Drawing.Size(218, 132);
            this.listBoxOutSignals.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.tabControlInputs);
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
    }
}

