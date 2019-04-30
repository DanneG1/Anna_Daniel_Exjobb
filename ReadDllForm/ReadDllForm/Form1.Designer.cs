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
        /// Required method for Designer support - do not update
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
            this.panelModelAndSignals = new System.Windows.Forms.Panel();
            this.componentListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewOutSignals = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRemoveModel = new System.Windows.Forms.Button();
            this.btnConnectOutsignal = new System.Windows.Forms.Button();
            this.listViewInSignals = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConnectInSignal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.worstRuntimeInfoLabel = new System.Windows.Forms.Label();
            this.worstTimeLabel = new System.Windows.Forms.Label();
            this.labelHiCoreConnection = new System.Windows.Forms.Label();
            this.buttonStep = new System.Windows.Forms.Button();
            this.buttonLoadModel = new System.Windows.Forms.Button();
            this.labelModelLoad = new System.Windows.Forms.Label();
            this.textBoxDll = new System.Windows.Forms.TextBox();
            this.buttonBrowseModel = new System.Windows.Forms.Button();
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.buttonRunModel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlInputs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelModelAndSignals.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
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
            this.tabControlInputs.Size = new System.Drawing.Size(1290, 675);
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
            this.tabPage1.Size = new System.Drawing.Size(1282, 638);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Model";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonRunModel);
            this.tabPage2.Controls.Add(this.textBoxFrequency);
            this.tabPage2.Controls.Add(this.panelModelAndSignals);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.worstRuntimeInfoLabel);
            this.tabPage2.Controls.Add(this.worstTimeLabel);
            this.tabPage2.Controls.Add(this.labelHiCoreConnection);
            this.tabPage2.Controls.Add(this.buttonStep);
            this.tabPage2.Controls.Add(this.buttonLoadModel);
            this.tabPage2.Controls.Add(this.labelModelLoad);
            this.tabPage2.Controls.Add(this.textBoxDll);
            this.tabPage2.Controls.Add(this.buttonBrowseModel);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1282, 638);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Load Model";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelModelAndSignals
            // 
            this.panelModelAndSignals.Controls.Add(this.componentListBox);
            this.panelModelAndSignals.Controls.Add(this.label2);
            this.panelModelAndSignals.Controls.Add(this.listViewOutSignals);
            this.panelModelAndSignals.Controls.Add(this.buttonRemoveModel);
            this.panelModelAndSignals.Controls.Add(this.btnConnectOutsignal);
            this.panelModelAndSignals.Controls.Add(this.listViewInSignals);
            this.panelModelAndSignals.Controls.Add(this.label3);
            this.panelModelAndSignals.Controls.Add(this.buttonConnectInSignal);
            this.panelModelAndSignals.Controls.Add(this.label4);
            this.panelModelAndSignals.Enabled = false;
            this.panelModelAndSignals.Location = new System.Drawing.Point(16, 111);
            this.panelModelAndSignals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelModelAndSignals.Name = "panelModelAndSignals";
            this.panelModelAndSignals.Size = new System.Drawing.Size(1254, 414);
            this.panelModelAndSignals.TabIndex = 20;
            // 
            // componentListBox
            // 
            this.componentListBox.FormattingEnabled = true;
            this.componentListBox.ItemHeight = 24;
            this.componentListBox.Location = new System.Drawing.Point(12, 46);
            this.componentListBox.Name = "componentListBox";
            this.componentListBox.Size = new System.Drawing.Size(264, 292);
            this.componentListBox.TabIndex = 7;
            this.componentListBox.SelectedIndexChanged += new System.EventHandler(this.componentListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Models:";
            // 
            // listViewOutSignals
            // 
            this.listViewOutSignals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewOutSignals.FullRowSelect = true;
            this.listViewOutSignals.Location = new System.Drawing.Point(791, 46);
            this.listViewOutSignals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewOutSignals.MultiSelect = false;
            this.listViewOutSignals.Name = "listViewOutSignals";
            this.listViewOutSignals.Size = new System.Drawing.Size(450, 292);
            this.listViewOutSignals.TabIndex = 18;
            this.listViewOutSignals.UseCompatibleStateImageBehavior = false;
            this.listViewOutSignals.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Value";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Connection";
            this.columnHeader6.Width = 100;
            // 
            // buttonRemoveModel
            // 
            this.buttonRemoveModel.Location = new System.Drawing.Point(12, 358);
            this.buttonRemoveModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemoveModel.Name = "buttonRemoveModel";
            this.buttonRemoveModel.Size = new System.Drawing.Size(170, 45);
            this.buttonRemoveModel.TabIndex = 12;
            this.buttonRemoveModel.Text = "Remove model";
            this.buttonRemoveModel.UseVisualStyleBackColor = true;
            this.buttonRemoveModel.Click += new System.EventHandler(this.buttonRemoveModel_Click);
            // 
            // btnConnectOutsignal
            // 
            this.btnConnectOutsignal.Location = new System.Drawing.Point(1031, 358);
            this.btnConnectOutsignal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnectOutsignal.Name = "btnConnectOutsignal";
            this.btnConnectOutsignal.Size = new System.Drawing.Size(210, 45);
            this.btnConnectOutsignal.TabIndex = 14;
            this.btnConnectOutsignal.Text = "Connect to channel";
            this.btnConnectOutsignal.UseVisualStyleBackColor = true;
            this.btnConnectOutsignal.Click += new System.EventHandler(this.btnConnectOutsignal_Click);
            // 
            // listViewInSignals
            // 
            this.listViewInSignals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewInSignals.FullRowSelect = true;
            this.listViewInSignals.Location = new System.Drawing.Point(311, 46);
            this.listViewInSignals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewInSignals.MultiSelect = false;
            this.listViewInSignals.Name = "listViewInSignals";
            this.listViewInSignals.Size = new System.Drawing.Size(440, 292);
            this.listViewInSignals.TabIndex = 17;
            this.listViewInSignals.UseCompatibleStateImageBehavior = false;
            this.listViewInSignals.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Connection";
            this.columnHeader3.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "In signals:";
            // 
            // buttonConnectInSignal
            // 
            this.buttonConnectInSignal.Location = new System.Drawing.Point(534, 358);
            this.buttonConnectInSignal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConnectInSignal.Name = "buttonConnectInSignal";
            this.buttonConnectInSignal.Size = new System.Drawing.Size(219, 45);
            this.buttonConnectInSignal.TabIndex = 7;
            this.buttonConnectInSignal.Text = "Connect to channel";
            this.buttonConnectInSignal.UseVisualStyleBackColor = true;
            this.buttonConnectInSignal.Click += new System.EventHandler(this.buttonConnectInSignal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(786, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Out signals:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(780, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "HiCore connection:";
            // 
            // worstRuntimeInfoLabel
            // 
            this.worstRuntimeInfoLabel.AutoSize = true;
            this.worstRuntimeInfoLabel.Location = new System.Drawing.Point(348, 544);
            this.worstRuntimeInfoLabel.Name = "worstRuntimeInfoLabel";
            this.worstRuntimeInfoLabel.Size = new System.Drawing.Size(139, 25);
            this.worstRuntimeInfoLabel.TabIndex = 16;
            this.worstRuntimeInfoLabel.Text = "Worst runtime:";
            // 
            // worstTimeLabel
            // 
            this.worstTimeLabel.AutoSize = true;
            this.worstTimeLabel.Location = new System.Drawing.Point(494, 544);
            this.worstTimeLabel.Name = "worstTimeLabel";
            this.worstTimeLabel.Size = new System.Drawing.Size(19, 25);
            this.worstTimeLabel.TabIndex = 15;
            this.worstTimeLabel.Text = "-";
            // 
            // labelHiCoreConnection
            // 
            this.labelHiCoreConnection.AutoSize = true;
            this.labelHiCoreConnection.Location = new System.Drawing.Point(964, 30);
            this.labelHiCoreConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHiCoreConnection.Name = "labelHiCoreConnection";
            this.labelHiCoreConnection.Size = new System.Drawing.Size(19, 25);
            this.labelHiCoreConnection.TabIndex = 13;
            this.labelHiCoreConnection.Text = "-";
            // 
            // buttonStep
            // 
            this.buttonStep.Location = new System.Drawing.Point(1148, 574);
            this.buttonStep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(103, 45);
            this.buttonStep.TabIndex = 6;
            this.buttonStep.Text = "Step";
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // buttonLoadModel
            // 
            this.buttonLoadModel.Enabled = false;
            this.buttonLoadModel.Location = new System.Drawing.Point(554, 24);
            this.buttonLoadModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadModel.Name = "buttonLoadModel";
            this.buttonLoadModel.Size = new System.Drawing.Size(133, 45);
            this.buttonLoadModel.TabIndex = 3;
            this.buttonLoadModel.Text = "Load model";
            this.buttonLoadModel.UseVisualStyleBackColor = true;
            this.buttonLoadModel.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelModelLoad
            // 
            this.labelModelLoad.AutoSize = true;
            this.labelModelLoad.Location = new System.Drawing.Point(12, 34);
            this.labelModelLoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModelLoad.Name = "labelModelLoad";
            this.labelModelLoad.Size = new System.Drawing.Size(120, 25);
            this.labelModelLoad.TabIndex = 2;
            this.labelModelLoad.Text = "Model (.dll) :";
            // 
            // textBoxDll
            // 
            this.textBoxDll.Location = new System.Drawing.Point(139, 30);
            this.textBoxDll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDll.Name = "textBoxDll";
            this.textBoxDll.Size = new System.Drawing.Size(294, 29);
            this.textBoxDll.TabIndex = 1;
            // 
            // buttonBrowseModel
            // 
            this.buttonBrowseModel.Location = new System.Drawing.Point(443, 24);
            this.buttonBrowseModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBrowseModel.Name = "buttonBrowseModel";
            this.buttonBrowseModel.Size = new System.Drawing.Size(103, 45);
            this.buttonBrowseModel.TabIndex = 0;
            this.buttonBrowseModel.Text = "Browse..";
            this.buttonBrowseModel.UseVisualStyleBackColor = true;
            this.buttonBrowseModel.Click += new System.EventHandler(this.buttonBrowseModel_Click);
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Location = new System.Drawing.Point(807, 574);
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.Size = new System.Drawing.Size(100, 29);
            this.textBoxFrequency.TabIndex = 21;
            // 
            // buttonRunModel
            // 
            this.buttonRunModel.Location = new System.Drawing.Point(924, 574);
            this.buttonRunModel.Name = "buttonRunModel";
            this.buttonRunModel.Size = new System.Drawing.Size(173, 45);
            this.buttonRunModel.TabIndex = 22;
            this.buttonRunModel.Text = "Run model";
            this.buttonRunModel.UseVisualStyleBackColor = true;
            this.buttonRunModel.Click += new System.EventHandler(this.buttonRunModel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 675);
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
            this.panelModelAndSignals.ResumeLayout(false);
            this.panelModelAndSignals.PerformLayout();
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
        private System.Windows.Forms.Button buttonBrowseModel;
        private System.Windows.Forms.Button buttonLoadModel;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.Button buttonConnectInSignal;
        private System.Windows.Forms.ListBox componentListBox;
        private System.Windows.Forms.Button buttonRemoveModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHiCoreConnection;
        private System.Windows.Forms.Button btnConnectOutsignal;
        private System.Windows.Forms.Label worstTimeLabel;
        private System.Windows.Forms.Label worstRuntimeInfoLabel;
        private System.Windows.Forms.ListView listViewInSignals;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewOutSignals;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelModelAndSignals;
        private System.Windows.Forms.Button buttonRunModel;
        private System.Windows.Forms.TextBox textBoxFrequency;
    }
}

