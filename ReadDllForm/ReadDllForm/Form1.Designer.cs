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
            this.components = new System.ComponentModel.Container();
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
            this.statusStripCreatePage = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCreatePage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStripLoadPage = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLoadPage = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelPerformanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSaveModel = new System.Windows.Forms.Panel();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.labelProjectNAme = new System.Windows.Forms.Label();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.checkBoxProject = new System.Windows.Forms.CheckBox();
            this.checkBoxModel = new System.Windows.Forms.CheckBox();
            this.panelLoadProject = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowseProject = new System.Windows.Forms.Button();
            this.textBoxProjectXml = new System.Windows.Forms.TextBox();
            this.btnLoadProject = new System.Windows.Forms.Button();
            this.panelLoadModel = new System.Windows.Forms.Panel();
            this.labelModelLoad = new System.Windows.Forms.Label();
            this.buttonBrowseModel = new System.Windows.Forms.Button();
            this.textBoxDll = new System.Windows.Forms.TextBox();
            this.buttonLoadModel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelHiCoreConnection = new System.Windows.Forms.Label();
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.worstRuntimeInfoLabel = new System.Windows.Forms.Label();
            this.buttonRunModel = new System.Windows.Forms.Button();
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
            this.timerUpdateLists = new System.Windows.Forms.Timer(this.components);
            this.timerConnect = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlInputs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStripCreatePage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStripLoadPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelSaveModel.SuspendLayout();
            this.panelLoadProject.SuspendLayout();
            this.panelLoadModel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelModelAndSignals.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHeaderFile
            // 
            this.btnHeaderFile.Location = new System.Drawing.Point(266, 40);
            this.btnHeaderFile.Name = "btnHeaderFile";
            this.btnHeaderFile.Size = new System.Drawing.Size(75, 30);
            this.btnHeaderFile.TabIndex = 0;
            this.btnHeaderFile.Text = ".h";
            this.btnHeaderFile.UseVisualStyleBackColor = true;
            this.btnHeaderFile.Click += new System.EventHandler(this.btnHeaderFile_Click);
            // 
            // btnCppFile
            // 
            this.btnCppFile.Location = new System.Drawing.Point(266, 90);
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
            this.txtBoxH.Location = new System.Drawing.Point(6, 44);
            this.txtBoxH.Name = "txtBoxH";
            this.txtBoxH.Size = new System.Drawing.Size(243, 22);
            this.txtBoxH.TabIndex = 2;
            // 
            // txtBoxCpp
            // 
            this.txtBoxCpp.Location = new System.Drawing.Point(6, 94);
            this.txtBoxCpp.Name = "txtBoxCpp";
            this.txtBoxCpp.Size = new System.Drawing.Size(243, 22);
            this.txtBoxCpp.TabIndex = 3;
            // 
            // btnGenerateDll
            // 
            this.btnGenerateDll.Location = new System.Drawing.Point(679, 255);
            this.btnGenerateDll.Name = "btnGenerateDll";
            this.btnGenerateDll.Size = new System.Drawing.Size(97, 30);
            this.btnGenerateDll.TabIndex = 4;
            this.btnGenerateDll.Text = "Generate Dll";
            this.btnGenerateDll.UseVisualStyleBackColor = true;
            this.btnGenerateDll.Click += new System.EventHandler(this.btnGenerateDll_Click);
            // 
            // textBoxSolution
            // 
            this.textBoxSolution.Location = new System.Drawing.Point(6, 44);
            this.textBoxSolution.Name = "textBoxSolution";
            this.textBoxSolution.Size = new System.Drawing.Size(250, 22);
            this.textBoxSolution.TabIndex = 6;
            // 
            // btnSolution
            // 
            this.btnSolution.Location = new System.Drawing.Point(276, 40);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(75, 30);
            this.btnSolution.TabIndex = 7;
            this.btnSolution.Text = "Solution";
            this.btnSolution.UseVisualStyleBackColor = true;
            this.btnSolution.Click += new System.EventHandler(this.btnSolution_Click);
            // 
            // btnMSBuild
            // 
            this.btnMSBuild.Location = new System.Drawing.Point(276, 92);
            this.btnMSBuild.Name = "btnMSBuild";
            this.btnMSBuild.Size = new System.Drawing.Size(75, 30);
            this.btnMSBuild.TabIndex = 8;
            this.btnMSBuild.Text = "MSBuild";
            this.btnMSBuild.UseVisualStyleBackColor = true;
            this.btnMSBuild.Click += new System.EventHandler(this.btnMSBuild_Click);
            // 
            // textBoxMsBuild
            // 
            this.textBoxMsBuild.Location = new System.Drawing.Point(6, 94);
            this.textBoxMsBuild.Name = "textBoxMsBuild";
            this.textBoxMsBuild.Size = new System.Drawing.Size(250, 22);
            this.textBoxMsBuild.TabIndex = 9;
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(6, 147);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(250, 22);
            this.textBoxTarget.TabIndex = 11;
            // 
            // btnTargetFolder
            // 
            this.btnTargetFolder.Location = new System.Drawing.Point(276, 143);
            this.btnTargetFolder.Name = "btnTargetFolder";
            this.btnTargetFolder.Size = new System.Drawing.Size(75, 30);
            this.btnTargetFolder.TabIndex = 10;
            this.btnTargetFolder.Text = "Target";
            this.btnTargetFolder.UseVisualStyleBackColor = true;
            this.btnTargetFolder.Click += new System.EventHandler(this.btnTargetFolder_Click);
            // 
            // textBoxModelName
            // 
            this.textBoxModelName.Location = new System.Drawing.Point(419, 263);
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
            this.groupBox1.Location = new System.Drawing.Point(22, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 185);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 266);
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
            this.groupBox2.Location = new System.Drawing.Point(413, 29);
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
            this.tabControlInputs.Size = new System.Drawing.Size(940, 637);
            this.tabControlInputs.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStripCreatePage);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxModelName);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnGenerateDll);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(932, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Model";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStripCreatePage
            // 
            this.statusStripCreatePage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripCreatePage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCreatePage});
            this.statusStripCreatePage.Location = new System.Drawing.Point(3, 580);
            this.statusStripCreatePage.Name = "statusStripCreatePage";
            this.statusStripCreatePage.Size = new System.Drawing.Size(926, 25);
            this.statusStripCreatePage.TabIndex = 16;
            this.statusStripCreatePage.Text = "       ";
            // 
            // toolStripStatusLabelCreatePage
            // 
            this.toolStripStatusLabelCreatePage.Name = "toolStripStatusLabelCreatePage";
            this.toolStripStatusLabelCreatePage.Size = new System.Drawing.Size(41, 20);
            this.toolStripStatusLabelCreatePage.Text = "        ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.statusStripLoadPage);
            this.tabPage2.Controls.Add(this.menuStrip1);
            this.tabPage2.Controls.Add(this.panelSaveModel);
            this.tabPage2.Controls.Add(this.checkBoxProject);
            this.tabPage2.Controls.Add(this.checkBoxModel);
            this.tabPage2.Controls.Add(this.panelLoadProject);
            this.tabPage2.Controls.Add(this.panelLoadModel);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.buttonRunModel);
            this.tabPage2.Controls.Add(this.panelModelAndSignals);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(932, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Load Model";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStripLoadPage
            // 
            this.statusStripLoadPage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripLoadPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLoadPage});
            this.statusStripLoadPage.Location = new System.Drawing.Point(3, 580);
            this.statusStripLoadPage.Name = "statusStripLoadPage";
            this.statusStripLoadPage.Size = new System.Drawing.Size(926, 25);
            this.statusStripLoadPage.TabIndex = 32;
            this.statusStripLoadPage.Text = "statusStrip2";
            // 
            // toolStripStatusLabelLoadPage
            // 
            this.toolStripStatusLabelLoadPage.Name = "toolStripStatusLabelLoadPage";
            this.toolStripStatusLabelLoadPage.Size = new System.Drawing.Size(37, 20);
            this.toolStripStatusLabelLoadPage.Text = "       ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 28);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelPerformanceToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // modelPerformanceToolStripMenuItem
            // 
            this.modelPerformanceToolStripMenuItem.Name = "modelPerformanceToolStripMenuItem";
            this.modelPerformanceToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.modelPerformanceToolStripMenuItem.Text = "Model Performance";
            this.modelPerformanceToolStripMenuItem.Click += new System.EventHandler(this.modelPerformanceToolStripMenuItem_Click);
            // 
            // panelSaveModel
            // 
            this.panelSaveModel.Controls.Add(this.textBoxProjectName);
            this.panelSaveModel.Controls.Add(this.labelProjectNAme);
            this.panelSaveModel.Controls.Add(this.btnSaveProject);
            this.panelSaveModel.Location = new System.Drawing.Point(11, 497);
            this.panelSaveModel.Name = "panelSaveModel";
            this.panelSaveModel.Size = new System.Drawing.Size(447, 56);
            this.panelSaveModel.TabIndex = 31;
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(104, 23);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(143, 22);
            this.textBoxProjectName.TabIndex = 29;
            // 
            // labelProjectNAme
            // 
            this.labelProjectNAme.AutoSize = true;
            this.labelProjectNAme.Location = new System.Drawing.Point(6, 26);
            this.labelProjectNAme.Name = "labelProjectNAme";
            this.labelProjectNAme.Size = new System.Drawing.Size(95, 17);
            this.labelProjectNAme.TabIndex = 30;
            this.labelProjectNAme.Text = "Project name:";
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.Location = new System.Drawing.Point(253, 19);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(180, 30);
            this.btnSaveProject.TabIndex = 28;
            this.btnSaveProject.Text = "Save Project";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // checkBoxProject
            // 
            this.checkBoxProject.AutoSize = true;
            this.checkBoxProject.Location = new System.Drawing.Point(134, 43);
            this.checkBoxProject.Name = "checkBoxProject";
            this.checkBoxProject.Size = new System.Drawing.Size(110, 21);
            this.checkBoxProject.TabIndex = 27;
            this.checkBoxProject.Text = "Load Project";
            this.checkBoxProject.UseVisualStyleBackColor = true;
            this.checkBoxProject.CheckedChanged += new System.EventHandler(this.checkBoxProject_CheckedChanged);
            // 
            // checkBoxModel
            // 
            this.checkBoxModel.AutoSize = true;
            this.checkBoxModel.Checked = true;
            this.checkBoxModel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxModel.Location = new System.Drawing.Point(11, 43);
            this.checkBoxModel.Name = "checkBoxModel";
            this.checkBoxModel.Size = new System.Drawing.Size(104, 21);
            this.checkBoxModel.TabIndex = 26;
            this.checkBoxModel.Text = "Load Model";
            this.checkBoxModel.UseVisualStyleBackColor = true;
            this.checkBoxModel.CheckedChanged += new System.EventHandler(this.checkBoxModel_CheckedChanged);
            // 
            // panelLoadProject
            // 
            this.panelLoadProject.Controls.Add(this.label6);
            this.panelLoadProject.Controls.Add(this.btnBrowseProject);
            this.panelLoadProject.Controls.Add(this.textBoxProjectXml);
            this.panelLoadProject.Controls.Add(this.btnLoadProject);
            this.panelLoadProject.Enabled = false;
            this.panelLoadProject.Location = new System.Drawing.Point(11, 142);
            this.panelLoadProject.Name = "panelLoadProject";
            this.panelLoadProject.Size = new System.Drawing.Size(508, 54);
            this.panelLoadProject.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Project (.xml) :";
            // 
            // btnBrowseProject
            // 
            this.btnBrowseProject.Location = new System.Drawing.Point(319, 19);
            this.btnBrowseProject.Name = "btnBrowseProject";
            this.btnBrowseProject.Size = new System.Drawing.Size(75, 30);
            this.btnBrowseProject.TabIndex = 0;
            this.btnBrowseProject.Text = "Browse..";
            this.btnBrowseProject.UseVisualStyleBackColor = true;
            this.btnBrowseProject.Click += new System.EventHandler(this.btnBrowseProject_Click);
            // 
            // textBoxProjectXml
            // 
            this.textBoxProjectXml.Location = new System.Drawing.Point(110, 23);
            this.textBoxProjectXml.Name = "textBoxProjectXml";
            this.textBoxProjectXml.Size = new System.Drawing.Size(203, 22);
            this.textBoxProjectXml.TabIndex = 1;
            // 
            // btnLoadProject
            // 
            this.btnLoadProject.Enabled = false;
            this.btnLoadProject.Location = new System.Drawing.Point(400, 19);
            this.btnLoadProject.Name = "btnLoadProject";
            this.btnLoadProject.Size = new System.Drawing.Size(97, 30);
            this.btnLoadProject.TabIndex = 3;
            this.btnLoadProject.Text = "Load project";
            this.btnLoadProject.UseVisualStyleBackColor = true;
            this.btnLoadProject.Click += new System.EventHandler(this.btnLoadProject_Click);
            // 
            // panelLoadModel
            // 
            this.panelLoadModel.Controls.Add(this.labelModelLoad);
            this.panelLoadModel.Controls.Add(this.buttonBrowseModel);
            this.panelLoadModel.Controls.Add(this.textBoxDll);
            this.panelLoadModel.Controls.Add(this.buttonLoadModel);
            this.panelLoadModel.Location = new System.Drawing.Point(11, 70);
            this.panelLoadModel.Name = "panelLoadModel";
            this.panelLoadModel.Size = new System.Drawing.Size(508, 54);
            this.panelLoadModel.TabIndex = 24;
            // 
            // labelModelLoad
            // 
            this.labelModelLoad.AutoSize = true;
            this.labelModelLoad.Location = new System.Drawing.Point(6, 26);
            this.labelModelLoad.Name = "labelModelLoad";
            this.labelModelLoad.Size = new System.Drawing.Size(86, 17);
            this.labelModelLoad.TabIndex = 2;
            this.labelModelLoad.Text = "Model (.dll) :";
            // 
            // buttonBrowseModel
            // 
            this.buttonBrowseModel.Location = new System.Drawing.Point(319, 19);
            this.buttonBrowseModel.Name = "buttonBrowseModel";
            this.buttonBrowseModel.Size = new System.Drawing.Size(75, 30);
            this.buttonBrowseModel.TabIndex = 0;
            this.buttonBrowseModel.Text = "Browse..";
            this.buttonBrowseModel.UseVisualStyleBackColor = true;
            this.buttonBrowseModel.Click += new System.EventHandler(this.buttonBrowseModel_Click);
            // 
            // textBoxDll
            // 
            this.textBoxDll.Location = new System.Drawing.Point(110, 23);
            this.textBoxDll.Name = "textBoxDll";
            this.textBoxDll.Size = new System.Drawing.Size(203, 22);
            this.textBoxDll.TabIndex = 1;
            // 
            // buttonLoadModel
            // 
            this.buttonLoadModel.Enabled = false;
            this.buttonLoadModel.Location = new System.Drawing.Point(400, 19);
            this.buttonLoadModel.Name = "buttonLoadModel";
            this.buttonLoadModel.Size = new System.Drawing.Size(97, 30);
            this.buttonLoadModel.TabIndex = 3;
            this.buttonLoadModel.Text = "Load model";
            this.buttonLoadModel.UseVisualStyleBackColor = true;
            this.buttonLoadModel.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelFrequency);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.labelHiCoreConnection);
            this.groupBox3.Controls.Add(this.textBoxFrequency);
            this.groupBox3.Controls.Add(this.worstRuntimeInfoLabel);
            this.groupBox3.Location = new System.Drawing.Point(586, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 132);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information";
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(59, 60);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(114, 17);
            this.labelFrequency.TabIndex = 22;
            this.labelFrequency.Text = "Update rate(Hz):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "HiCore connection:";
            // 
            // labelHiCoreConnection
            // 
            this.labelHiCoreConnection.AutoSize = true;
            this.labelHiCoreConnection.Location = new System.Drawing.Point(198, 34);
            this.labelHiCoreConnection.Name = "labelHiCoreConnection";
            this.labelHiCoreConnection.Size = new System.Drawing.Size(13, 17);
            this.labelHiCoreConnection.TabIndex = 13;
            this.labelHiCoreConnection.Text = "-";
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Location = new System.Drawing.Point(203, 60);
            this.textBoxFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.Size = new System.Drawing.Size(74, 22);
            this.textBoxFrequency.TabIndex = 21;
            this.textBoxFrequency.Text = "1";
            // 
            // worstRuntimeInfoLabel
            // 
            this.worstRuntimeInfoLabel.AutoSize = true;
            this.worstRuntimeInfoLabel.Location = new System.Drawing.Point(6, 74);
            this.worstRuntimeInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.worstRuntimeInfoLabel.Name = "worstRuntimeInfoLabel";
            this.worstRuntimeInfoLabel.Size = new System.Drawing.Size(0, 17);
            this.worstRuntimeInfoLabel.TabIndex = 16;
            // 
            // buttonRunModel
            // 
            this.buttonRunModel.Location = new System.Drawing.Point(787, 523);
            this.buttonRunModel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRunModel.Name = "buttonRunModel";
            this.buttonRunModel.Size = new System.Drawing.Size(126, 30);
            this.buttonRunModel.TabIndex = 22;
            this.buttonRunModel.Text = "Run model";
            this.buttonRunModel.UseVisualStyleBackColor = true;
            this.buttonRunModel.Click += new System.EventHandler(this.buttonRunModel_Click);
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
            this.panelModelAndSignals.Location = new System.Drawing.Point(11, 218);
            this.panelModelAndSignals.Name = "panelModelAndSignals";
            this.panelModelAndSignals.Size = new System.Drawing.Size(910, 276);
            this.panelModelAndSignals.TabIndex = 20;
            // 
            // componentListBox
            // 
            this.componentListBox.FormattingEnabled = true;
            this.componentListBox.ItemHeight = 16;
            this.componentListBox.Location = new System.Drawing.Point(13, 42);
            this.componentListBox.Margin = new System.Windows.Forms.Padding(2);
            this.componentListBox.Name = "componentListBox";
            this.componentListBox.Size = new System.Drawing.Size(190, 196);
            this.componentListBox.TabIndex = 7;
            this.componentListBox.SelectedIndexChanged += new System.EventHandler(this.componentListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
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
            this.listViewOutSignals.Location = new System.Drawing.Point(575, 42);
            this.listViewOutSignals.MultiSelect = false;
            this.listViewOutSignals.Name = "listViewOutSignals";
            this.listViewOutSignals.Size = new System.Drawing.Size(320, 200);
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
            this.buttonRemoveModel.Location = new System.Drawing.Point(79, 244);
            this.buttonRemoveModel.Name = "buttonRemoveModel";
            this.buttonRemoveModel.Size = new System.Drawing.Size(124, 30);
            this.buttonRemoveModel.TabIndex = 12;
            this.buttonRemoveModel.Text = "Remove model";
            this.buttonRemoveModel.UseVisualStyleBackColor = true;
            this.buttonRemoveModel.Click += new System.EventHandler(this.buttonRemoveModel_Click);
            // 
            // btnConnectOutsignal
            // 
            this.btnConnectOutsignal.Location = new System.Drawing.Point(742, 244);
            this.btnConnectOutsignal.Name = "btnConnectOutsignal";
            this.btnConnectOutsignal.Size = new System.Drawing.Size(153, 30);
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
            this.listViewInSignals.Location = new System.Drawing.Point(238, 42);
            this.listViewInSignals.MultiSelect = false;
            this.listViewInSignals.Name = "listViewInSignals";
            this.listViewInSignals.Size = new System.Drawing.Size(320, 200);
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
            this.label3.Location = new System.Drawing.Point(235, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "In signals:";
            // 
            // buttonConnectInSignal
            // 
            this.buttonConnectInSignal.Location = new System.Drawing.Point(400, 244);
            this.buttonConnectInSignal.Name = "buttonConnectInSignal";
            this.buttonConnectInSignal.Size = new System.Drawing.Size(159, 30);
            this.buttonConnectInSignal.TabIndex = 7;
            this.buttonConnectInSignal.Text = "Connect to channel";
            this.buttonConnectInSignal.UseVisualStyleBackColor = true;
            this.buttonConnectInSignal.Click += new System.EventHandler(this.buttonConnectInSignal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Out signals:";
            // 
            // timerUpdateLists
            // 
            this.timerUpdateLists.Tick += new System.EventHandler(this.timerUpdateLists_Tick);
            // 
            // timerConnect
            // 
            this.timerConnect.Tick += new System.EventHandler(this.timerConnect_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 637);
            this.Controls.Add(this.tabControlInputs);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HiModels";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControlInputs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStripCreatePage.ResumeLayout(false);
            this.statusStripCreatePage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStripLoadPage.ResumeLayout(false);
            this.statusStripLoadPage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSaveModel.ResumeLayout(false);
            this.panelSaveModel.PerformLayout();
            this.panelLoadProject.ResumeLayout(false);
            this.panelLoadProject.PerformLayout();
            this.panelLoadModel.ResumeLayout(false);
            this.panelLoadModel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button buttonConnectInSignal;
        private System.Windows.Forms.ListBox componentListBox;
        private System.Windows.Forms.Button buttonRemoveModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHiCoreConnection;
        private System.Windows.Forms.Button btnConnectOutsignal;
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
        private System.Windows.Forms.Timer timerUpdateLists;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Timer timerConnect;
        private System.Windows.Forms.CheckBox checkBoxProject;
        private System.Windows.Forms.CheckBox checkBoxModel;
        private System.Windows.Forms.Panel panelLoadProject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowseProject;
        private System.Windows.Forms.TextBox textBoxProjectXml;
        private System.Windows.Forms.Button btnLoadProject;
        private System.Windows.Forms.Panel panelLoadModel;
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.Panel panelSaveModel;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.Label labelProjectNAme;
        private System.Windows.Forms.StatusStrip statusStripCreatePage;
        private System.Windows.Forms.StatusStrip statusStripLoadPage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCreatePage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLoadPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelPerformanceToolStripMenuItem;
    }
}

