namespace Episode_Renamer.Forms
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbInfo = new System.Windows.Forms.TabControl();
            this.tabSuffix = new System.Windows.Forms.TabPage();
            this.dgvPrefix = new System.Windows.Forms.DataGridView();
            this.tabFileExtensions = new System.Windows.Forms.TabPage();
            this.dgvFileTypes = new System.Windows.Forms.DataGridView();
            this.tabRegEx = new System.Windows.Forms.TabPage();
            this.cBSuffix = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.tbTest = new System.Windows.Forms.TextBox();
            this.dgvRegEx = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DBSelect = new System.Windows.Forms.Button();
            this.tbDBPath = new System.Windows.Forms.TextBox();
            this.tabRegistry = new System.Windows.Forms.TabPage();
            this.gbFolderHandler = new System.Windows.Forms.GroupBox();
            this.btnUnregFolder = new System.Windows.Forms.Button();
            this.btnRegFolder = new System.Windows.Forms.Button();
            this.gBFileHandler = new System.Windows.Forms.GroupBox();
            this.btnUnregFile = new System.Windows.Forms.Button();
            this.btnRegFile = new System.Windows.Forms.Button();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbTestResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tbInfo.SuspendLayout();
            this.tabSuffix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrefix)).BeginInit();
            this.tabFileExtensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileTypes)).BeginInit();
            this.tabRegEx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegEx)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.tabRegistry.SuspendLayout();
            this.gbFolderHandler.SuspendLayout();
            this.gBFileHandler.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(508, 417);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Episode Renamer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbInfo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(508, 344);
            this.splitContainer2.SplitterDistance = 316;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 1;
            // 
            // tbInfo
            // 
            this.tbInfo.Controls.Add(this.tabSuffix);
            this.tbInfo.Controls.Add(this.tabFileExtensions);
            this.tbInfo.Controls.Add(this.tabRegEx);
            this.tbInfo.Controls.Add(this.tabSettings);
            this.tbInfo.Controls.Add(this.tabRegistry);
            this.tbInfo.Controls.Add(this.tabInfo);
            this.tbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInfo.Location = new System.Drawing.Point(0, 0);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.SelectedIndex = 0;
            this.tbInfo.Size = new System.Drawing.Size(508, 316);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabSuffix
            // 
            this.tabSuffix.Controls.Add(this.dgvPrefix);
            this.tabSuffix.Location = new System.Drawing.Point(4, 22);
            this.tabSuffix.Margin = new System.Windows.Forms.Padding(2);
            this.tabSuffix.Name = "tabSuffix";
            this.tabSuffix.Padding = new System.Windows.Forms.Padding(2);
            this.tabSuffix.Size = new System.Drawing.Size(500, 290);
            this.tabSuffix.TabIndex = 0;
            this.tabSuffix.Text = "Suffix";
            this.tabSuffix.UseVisualStyleBackColor = true;
            // 
            // dgvPrefix
            // 
            this.dgvPrefix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrefix.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPrefix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrefix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrefix.Location = new System.Drawing.Point(2, 2);
            this.dgvPrefix.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPrefix.Name = "dgvPrefix";
            this.dgvPrefix.RowTemplate.Height = 24;
            this.dgvPrefix.Size = new System.Drawing.Size(496, 286);
            this.dgvPrefix.TabIndex = 0;
            this.dgvPrefix.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPrefix_CellMouseUp);
            // 
            // tabFileExtensions
            // 
            this.tabFileExtensions.Controls.Add(this.dgvFileTypes);
            this.tabFileExtensions.Location = new System.Drawing.Point(4, 22);
            this.tabFileExtensions.Margin = new System.Windows.Forms.Padding(2);
            this.tabFileExtensions.Name = "tabFileExtensions";
            this.tabFileExtensions.Padding = new System.Windows.Forms.Padding(2);
            this.tabFileExtensions.Size = new System.Drawing.Size(500, 290);
            this.tabFileExtensions.TabIndex = 1;
            this.tabFileExtensions.Text = "File Extensions";
            this.tabFileExtensions.UseVisualStyleBackColor = true;
            // 
            // dgvFileTypes
            // 
            this.dgvFileTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFileTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFileTypes.Location = new System.Drawing.Point(2, 2);
            this.dgvFileTypes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFileTypes.Name = "dgvFileTypes";
            this.dgvFileTypes.RowTemplate.Height = 24;
            this.dgvFileTypes.Size = new System.Drawing.Size(496, 286);
            this.dgvFileTypes.TabIndex = 0;
            this.dgvFileTypes.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFileTypes_CellMouseUp);
            // 
            // tabRegEx
            // 
            this.tabRegEx.Controls.Add(this.tbTestResult);
            this.tabRegEx.Controls.Add(this.cBSuffix);
            this.tabRegEx.Controls.Add(this.label5);
            this.tabRegEx.Controls.Add(this.btnTest);
            this.tabRegEx.Controls.Add(this.tbTest);
            this.tabRegEx.Controls.Add(this.dgvRegEx);
            this.tabRegEx.Controls.Add(this.label4);
            this.tabRegEx.Location = new System.Drawing.Point(4, 22);
            this.tabRegEx.Name = "tabRegEx";
            this.tabRegEx.Size = new System.Drawing.Size(500, 290);
            this.tabRegEx.TabIndex = 5;
            this.tabRegEx.Text = "RegEx";
            this.tabRegEx.UseVisualStyleBackColor = true;
            // 
            // cBSuffix
            // 
            this.cBSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cBSuffix.AutoSize = true;
            this.cBSuffix.Location = new System.Drawing.Point(380, 239);
            this.cBSuffix.Name = "cBSuffix";
            this.cBSuffix.Size = new System.Drawing.Size(108, 17);
            this.cBSuffix.TabIndex = 20;
            this.cBSuffix.Text = "Include Suffix DB";
            this.cBSuffix.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Test Regex";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(380, 259);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 18;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tbTest
            // 
            this.tbTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTest.Location = new System.Drawing.Point(23, 237);
            this.tbTest.Name = "tbTest";
            this.tbTest.Size = new System.Drawing.Size(351, 20);
            this.tbTest.TabIndex = 17;
            // 
            // dgvRegEx
            // 
            this.dgvRegEx.AllowUserToResizeRows = false;
            this.dgvRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegEx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegEx.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRegEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegEx.Location = new System.Drawing.Point(23, 44);
            this.dgvRegEx.Name = "dgvRegEx";
            this.dgvRegEx.Size = new System.Drawing.Size(455, 150);
            this.dgvRegEx.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "RegEx Management";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.label3);
            this.tabSettings.Controls.Add(this.btn_DBSelect);
            this.tabSettings.Controls.Add(this.tbDBPath);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(2);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(500, 290);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select Database";
            // 
            // btn_DBSelect
            // 
            this.btn_DBSelect.Location = new System.Drawing.Point(418, 69);
            this.btn_DBSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DBSelect.Name = "btn_DBSelect";
            this.btn_DBSelect.Size = new System.Drawing.Size(56, 19);
            this.btn_DBSelect.TabIndex = 10;
            this.btn_DBSelect.Text = "Select";
            this.btn_DBSelect.UseVisualStyleBackColor = true;
            this.btn_DBSelect.Click += new System.EventHandler(this.btn_DBSelect_Click);
            // 
            // tbDBPath
            // 
            this.tbDBPath.Location = new System.Drawing.Point(19, 42);
            this.tbDBPath.Margin = new System.Windows.Forms.Padding(2);
            this.tbDBPath.Name = "tbDBPath";
            this.tbDBPath.Size = new System.Drawing.Size(456, 20);
            this.tbDBPath.TabIndex = 9;
            // 
            // tabRegistry
            // 
            this.tabRegistry.Controls.Add(this.gbFolderHandler);
            this.tabRegistry.Controls.Add(this.gBFileHandler);
            this.tabRegistry.Location = new System.Drawing.Point(4, 22);
            this.tabRegistry.Name = "tabRegistry";
            this.tabRegistry.Size = new System.Drawing.Size(500, 290);
            this.tabRegistry.TabIndex = 4;
            this.tabRegistry.Text = "Registry";
            this.tabRegistry.UseVisualStyleBackColor = true;
            // 
            // gbFolderHandler
            // 
            this.gbFolderHandler.Controls.Add(this.btnUnregFolder);
            this.gbFolderHandler.Controls.Add(this.btnRegFolder);
            this.gbFolderHandler.Location = new System.Drawing.Point(8, 74);
            this.gbFolderHandler.Name = "gbFolderHandler";
            this.gbFolderHandler.Size = new System.Drawing.Size(270, 47);
            this.gbFolderHandler.TabIndex = 6;
            this.gbFolderHandler.TabStop = false;
            this.gbFolderHandler.Text = "FolderHandler";
            // 
            // btnUnregFolder
            // 
            this.btnUnregFolder.Location = new System.Drawing.Point(172, 15);
            this.btnUnregFolder.Name = "btnUnregFolder";
            this.btnUnregFolder.Size = new System.Drawing.Size(88, 23);
            this.btnUnregFolder.TabIndex = 2;
            this.btnUnregFolder.Text = "Unregister";
            this.btnUnregFolder.UseVisualStyleBackColor = true;
            this.btnUnregFolder.Click += new System.EventHandler(this.btnUnregFolder_Click);
            // 
            // btnRegFolder
            // 
            this.btnRegFolder.Location = new System.Drawing.Point(78, 15);
            this.btnRegFolder.Name = "btnRegFolder";
            this.btnRegFolder.Size = new System.Drawing.Size(88, 23);
            this.btnRegFolder.TabIndex = 1;
            this.btnRegFolder.Text = "Register";
            this.btnRegFolder.UseVisualStyleBackColor = true;
            this.btnRegFolder.Click += new System.EventHandler(this.btnRegFolder_Click);
            // 
            // gBFileHandler
            // 
            this.gBFileHandler.Controls.Add(this.btnUnregFile);
            this.gBFileHandler.Controls.Add(this.btnRegFile);
            this.gBFileHandler.Location = new System.Drawing.Point(8, 21);
            this.gBFileHandler.Name = "gBFileHandler";
            this.gBFileHandler.Size = new System.Drawing.Size(270, 47);
            this.gBFileHandler.TabIndex = 5;
            this.gBFileHandler.TabStop = false;
            this.gBFileHandler.Text = "FileHandler";
            // 
            // btnUnregFile
            // 
            this.btnUnregFile.Location = new System.Drawing.Point(172, 15);
            this.btnUnregFile.Name = "btnUnregFile";
            this.btnUnregFile.Size = new System.Drawing.Size(88, 23);
            this.btnUnregFile.TabIndex = 1;
            this.btnUnregFile.Text = "Unregister";
            this.btnUnregFile.UseVisualStyleBackColor = true;
            this.btnUnregFile.Click += new System.EventHandler(this.btnUnregFile_Click);
            // 
            // btnRegFile
            // 
            this.btnRegFile.Location = new System.Drawing.Point(78, 15);
            this.btnRegFile.Name = "btnRegFile";
            this.btnRegFile.Size = new System.Drawing.Size(88, 23);
            this.btnRegFile.TabIndex = 0;
            this.btnRegFile.Text = "Register";
            this.btnRegFile.UseVisualStyleBackColor = true;
            this.btnRegFile.Click += new System.EventHandler(this.btnRegFile_Click);
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.richTextBox1);
            this.tabInfo.Controls.Add(this.label2);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tabInfo.Size = new System.Drawing.Size(500, 290);
            this.tabInfo.TabIndex = 3;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(496, 286);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer3.Panel1.Controls.Add(this.lblStatus);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btn_save);
            this.splitContainer3.Size = new System.Drawing.Size(508, 25);
            this.splitContainer3.SplitterDistance = 409;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 3);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "lblStatus";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save.Location = new System.Drawing.Point(0, 0);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(96, 25);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbTestResult
            // 
            this.tbTestResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTestResult.Location = new System.Drawing.Point(23, 261);
            this.tbTestResult.Name = "tbTestResult";
            this.tbTestResult.ReadOnly = true;
            this.tbTestResult.Size = new System.Drawing.Size(351, 20);
            this.tbTestResult.TabIndex = 21;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 417);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConfig";
            this.Text = "Episode Renamer Config";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tbInfo.ResumeLayout(false);
            this.tabSuffix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrefix)).EndInit();
            this.tabFileExtensions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileTypes)).EndInit();
            this.tabRegEx.ResumeLayout(false);
            this.tabRegEx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegEx)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabRegistry.ResumeLayout(false);
            this.gbFolderHandler.ResumeLayout(false);
            this.gBFileHandler.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tbInfo;
        private System.Windows.Forms.TabPage tabSuffix;
        private System.Windows.Forms.TabPage tabFileExtensions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_DBSelect;
        private System.Windows.Forms.TextBox tbDBPath;
        private System.Windows.Forms.DataGridView dgvPrefix;
        private System.Windows.Forms.DataGridView dgvFileTypes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabRegistry;
        private System.Windows.Forms.Button btnRegFolder;
        private System.Windows.Forms.Button btnRegFile;
        private System.Windows.Forms.GroupBox gbFolderHandler;
        private System.Windows.Forms.GroupBox gBFileHandler;
        private System.Windows.Forms.Button btnUnregFolder;
        private System.Windows.Forms.Button btnUnregFile;
        private System.Windows.Forms.TabPage tabRegEx;
        private System.Windows.Forms.CheckBox cBSuffix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox tbTest;
        private System.Windows.Forms.DataGridView dgvRegEx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTestResult;
    }
}

