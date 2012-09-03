namespace MSIInspector
{
    partial class mainForm
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
            this.msiPath = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportTable = new System.Windows.Forms.Button();
            this.btnExportAll = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.cbxExcludeUI = new System.Windows.Forms.CheckBox();
            this.tbList = new System.Windows.Forms.TabControl();
            this.tabTables = new System.Windows.Forms.TabPage();
            this.dgTables = new System.Windows.Forms.DataGridView();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProperties = new System.Windows.Forms.TabPage();
            this.propertyList = new System.Windows.Forms.DataGridView();
            this.Property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDirectories = new System.Windows.Forms.TabPage();
            this.directoryList = new System.Windows.Forms.DataGridView();
            this.Directory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabComponents = new System.Windows.Forms.TabPage();
            this.componentList = new System.Windows.Forms.DataGridView();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attributes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAction = new System.Windows.Forms.TabPage();
            this.actionList = new System.Windows.Forms.DataGridView();
            this.ActionContext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCustAct = new System.Windows.Forms.TabPage();
            this.custactList = new System.Windows.Forms.DataGridView();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtendedType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileSelector = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tbList.SuspendLayout();
            this.tabTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTables)).BeginInit();
            this.tabProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyList)).BeginInit();
            this.tabDirectories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directoryList)).BeginInit();
            this.tabComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.componentList)).BeginInit();
            this.tabAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionList)).BeginInit();
            this.tabCustAct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custactList)).BeginInit();
            this.SuspendLayout();
            // 
            // msiPath
            // 
            this.msiPath.FileName = "targetFile";
            this.msiPath.Filter = "MSI files|*.msi|All Files|*.*";
            this.msiPath.Title = "Choose the MSI File";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbList);
            this.splitContainer1.Size = new System.Drawing.Size(675, 353);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(675, 113);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.Controls.Add(this.tbxFilePath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExportTable, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExportAll, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 97);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tbxFilePath
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbxFilePath, 2);
            this.tbxFilePath.Location = new System.Drawing.Point(96, 8);
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.Size = new System.Drawing.Size(398, 20);
            this.tbxFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to MSI File";
            // 
            // btnExportTable
            // 
            this.btnExportTable.Enabled = false;
            this.btnExportTable.Location = new System.Drawing.Point(356, 68);
            this.btnExportTable.Name = "btnExportTable";
            this.btnExportTable.Size = new System.Drawing.Size(90, 21);
            this.btnExportTable.TabIndex = 2;
            this.btnExportTable.Text = "Export Table";
            this.btnExportTable.UseVisualStyleBackColor = true;
            this.btnExportTable.Click += new System.EventHandler(this.btnExportTable_Click);
            // 
            // btnExportAll
            // 
            this.btnExportAll.Enabled = false;
            this.btnExportAll.Location = new System.Drawing.Point(356, 38);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(90, 23);
            this.btnExportAll.TabIndex = 3;
            this.btnExportAll.Text = "Export All Tables";
            this.btnExportAll.UseVisualStyleBackColor = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnBrowse);
            this.flowLayoutPanel3.Controls.Add(this.btnProcess);
            this.flowLayoutPanel3.Controls.Add(this.cbxExcludeUI);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(540, 8);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(127, 97);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(8, 8);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(101, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Find MSI";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(8, 37);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(101, 23);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // cbxExcludeUI
            // 
            this.cbxExcludeUI.AutoSize = true;
            this.cbxExcludeUI.Checked = true;
            this.cbxExcludeUI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxExcludeUI.Location = new System.Drawing.Point(8, 66);
            this.cbxExcludeUI.Name = "cbxExcludeUI";
            this.cbxExcludeUI.Size = new System.Drawing.Size(116, 17);
            this.cbxExcludeUI.TabIndex = 2;
            this.cbxExcludeUI.Text = "Ignore UI Elements";
            this.cbxExcludeUI.UseVisualStyleBackColor = true;
            // 
            // tbList
            // 
            this.tbList.Controls.Add(this.tabTables);
            this.tbList.Controls.Add(this.tabProperties);
            this.tbList.Controls.Add(this.tabDirectories);
            this.tbList.Controls.Add(this.tabComponents);
            this.tbList.Controls.Add(this.tabAction);
            this.tbList.Controls.Add(this.tabCustAct);
            this.tbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbList.Location = new System.Drawing.Point(0, 0);
            this.tbList.Name = "tbList";
            this.tbList.SelectedIndex = 0;
            this.tbList.Size = new System.Drawing.Size(675, 242);
            this.tbList.TabIndex = 1;
            // 
            // tabTables
            // 
            this.tabTables.AutoScroll = true;
            this.tabTables.Controls.Add(this.dgTables);
            this.tabTables.Location = new System.Drawing.Point(4, 22);
            this.tabTables.Name = "tabTables";
            this.tabTables.Padding = new System.Windows.Forms.Padding(3);
            this.tabTables.Size = new System.Drawing.Size(667, 216);
            this.tabTables.TabIndex = 6;
            this.tabTables.Text = "Tables";
            this.tabTables.UseVisualStyleBackColor = true;
            // 
            // dgTables
            // 
            this.dgTables.AllowUserToAddRows = false;
            this.dgTables.AllowUserToDeleteRows = false;
            this.dgTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableName,
            this.Columns});
            this.dgTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTables.Location = new System.Drawing.Point(3, 3);
            this.dgTables.Name = "dgTables";
            this.dgTables.ReadOnly = true;
            this.dgTables.Size = new System.Drawing.Size(661, 210);
            this.dgTables.TabIndex = 0;
            // 
            // TableName
            // 
            this.TableName.HeaderText = "Name";
            this.TableName.Name = "TableName";
            this.TableName.ReadOnly = true;
            // 
            // Columns
            // 
            this.Columns.HeaderText = "Columns";
            this.Columns.Name = "Columns";
            this.Columns.ReadOnly = true;
            // 
            // tabProperties
            // 
            this.tabProperties.Controls.Add(this.propertyList);
            this.tabProperties.Location = new System.Drawing.Point(4, 22);
            this.tabProperties.Name = "tabProperties";
            this.tabProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tabProperties.Size = new System.Drawing.Size(667, 216);
            this.tabProperties.TabIndex = 0;
            this.tabProperties.Text = "Properties";
            this.tabProperties.UseVisualStyleBackColor = true;
            // 
            // propertyList
            // 
            this.propertyList.AllowUserToAddRows = false;
            this.propertyList.AllowUserToDeleteRows = false;
            this.propertyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.propertyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Property,
            this.Value});
            this.propertyList.Location = new System.Drawing.Point(0, 0);
            this.propertyList.Name = "propertyList";
            this.propertyList.Size = new System.Drawing.Size(664, 222);
            this.propertyList.TabIndex = 0;
            // 
            // Property
            // 
            this.Property.HeaderText = "Property";
            this.Property.Name = "Property";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // tabDirectories
            // 
            this.tabDirectories.Controls.Add(this.directoryList);
            this.tabDirectories.Location = new System.Drawing.Point(4, 22);
            this.tabDirectories.Name = "tabDirectories";
            this.tabDirectories.Padding = new System.Windows.Forms.Padding(3);
            this.tabDirectories.Size = new System.Drawing.Size(667, 216);
            this.tabDirectories.TabIndex = 1;
            this.tabDirectories.Text = "Directories";
            this.tabDirectories.UseVisualStyleBackColor = true;
            // 
            // directoryList
            // 
            this.directoryList.AllowUserToAddRows = false;
            this.directoryList.AllowUserToDeleteRows = false;
            this.directoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.directoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Directory,
            this.ParentDir,
            this.DefaultDir});
            this.directoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryList.Location = new System.Drawing.Point(3, 3);
            this.directoryList.Name = "directoryList";
            this.directoryList.Size = new System.Drawing.Size(654, 209);
            this.directoryList.TabIndex = 0;
            // 
            // Directory
            // 
            this.Directory.HeaderText = "Directory";
            this.Directory.Name = "Directory";
            // 
            // ParentDir
            // 
            this.ParentDir.HeaderText = "Parent";
            this.ParentDir.Name = "ParentDir";
            // 
            // DefaultDir
            // 
            this.DefaultDir.HeaderText = "Default Directory";
            this.DefaultDir.Name = "DefaultDir";
            // 
            // tabComponents
            // 
            this.tabComponents.Controls.Add(this.componentList);
            this.tabComponents.Location = new System.Drawing.Point(4, 22);
            this.tabComponents.Name = "tabComponents";
            this.tabComponents.Size = new System.Drawing.Size(667, 216);
            this.tabComponents.TabIndex = 2;
            this.tabComponents.Text = "Components";
            this.tabComponents.UseVisualStyleBackColor = true;
            // 
            // componentList
            // 
            this.componentList.AllowUserToAddRows = false;
            this.componentList.AllowUserToDeleteRows = false;
            this.componentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.componentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Component,
            this.ComponentId,
            this.DirectoryId,
            this.Attributes,
            this.Condition,
            this.KeyPath});
            this.componentList.Location = new System.Drawing.Point(0, 0);
            this.componentList.Name = "componentList";
            this.componentList.Size = new System.Drawing.Size(660, 219);
            this.componentList.TabIndex = 0;
            // 
            // Component
            // 
            this.Component.HeaderText = "Component";
            this.Component.Name = "Component";
            // 
            // ComponentId
            // 
            this.ComponentId.HeaderText = "Component ID";
            this.ComponentId.Name = "ComponentId";
            // 
            // DirectoryId
            // 
            this.DirectoryId.HeaderText = "Directory";
            this.DirectoryId.Name = "DirectoryId";
            // 
            // Attributes
            // 
            this.Attributes.HeaderText = "Attributes";
            this.Attributes.Name = "Attributes";
            // 
            // Condition
            // 
            this.Condition.HeaderText = "Condition";
            this.Condition.Name = "Condition";
            // 
            // KeyPath
            // 
            this.KeyPath.HeaderText = "Key Path";
            this.KeyPath.Name = "KeyPath";
            // 
            // tabAction
            // 
            this.tabAction.Controls.Add(this.actionList);
            this.tabAction.Location = new System.Drawing.Point(4, 22);
            this.tabAction.Name = "tabAction";
            this.tabAction.Padding = new System.Windows.Forms.Padding(3);
            this.tabAction.Size = new System.Drawing.Size(667, 216);
            this.tabAction.TabIndex = 5;
            this.tabAction.Text = "Actions";
            this.tabAction.UseVisualStyleBackColor = true;
            // 
            // actionList
            // 
            this.actionList.AllowUserToAddRows = false;
            this.actionList.AllowUserToDeleteRows = false;
            this.actionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.actionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActionContext,
            this.InstallAction,
            this.InstallCondition,
            this.InstallSequence});
            this.actionList.Location = new System.Drawing.Point(0, 0);
            this.actionList.Name = "actionList";
            this.actionList.ReadOnly = true;
            this.actionList.Size = new System.Drawing.Size(660, 215);
            this.actionList.TabIndex = 0;
            this.actionList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sequenceColumnHeaderClick);
            // 
            // ActionContext
            // 
            this.ActionContext.HeaderText = "Context";
            this.ActionContext.Name = "ActionContext";
            this.ActionContext.ReadOnly = true;
            // 
            // InstallAction
            // 
            this.InstallAction.HeaderText = "Action";
            this.InstallAction.Name = "InstallAction";
            this.InstallAction.ReadOnly = true;
            // 
            // InstallCondition
            // 
            this.InstallCondition.HeaderText = "Condition";
            this.InstallCondition.Name = "InstallCondition";
            this.InstallCondition.ReadOnly = true;
            // 
            // InstallSequence
            // 
            this.InstallSequence.HeaderText = "Sequence";
            this.InstallSequence.Name = "InstallSequence";
            this.InstallSequence.ReadOnly = true;
            this.InstallSequence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tabCustAct
            // 
            this.tabCustAct.Controls.Add(this.custactList);
            this.tabCustAct.Location = new System.Drawing.Point(4, 22);
            this.tabCustAct.Name = "tabCustAct";
            this.tabCustAct.Size = new System.Drawing.Size(667, 216);
            this.tabCustAct.TabIndex = 4;
            this.tabCustAct.Text = "Custom Actions";
            this.tabCustAct.UseVisualStyleBackColor = true;
            // 
            // custactList
            // 
            this.custactList.AllowUserToAddRows = false;
            this.custactList.AllowUserToDeleteRows = false;
            this.custactList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.custactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custactList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.Type,
            this.Source,
            this.Target,
            this.ExtendedType});
            this.custactList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custactList.Location = new System.Drawing.Point(0, 0);
            this.custactList.Name = "custactList";
            this.custactList.Size = new System.Drawing.Size(667, 222);
            this.custactList.TabIndex = 0;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Source
            // 
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            // 
            // Target
            // 
            this.Target.HeaderText = "Target";
            this.Target.Name = "Target";
            // 
            // ExtendedType
            // 
            this.ExtendedType.HeaderText = "Extended Type";
            this.ExtendedType.Name = "ExtendedType";
            // 
            // saveFileSelector
            // 
            this.saveFileSelector.FileName = "targetFile";
            this.saveFileSelector.Filter = "Microsoft Excel|*.xlsx|CSV File|*.csv";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 353);
            this.Controls.Add(this.splitContainer1);
            this.Name = "mainForm";
            this.Text = "MSI Property Browser";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tbList.ResumeLayout(false);
            this.tabTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTables)).EndInit();
            this.tabProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyList)).EndInit();
            this.tabDirectories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.directoryList)).EndInit();
            this.tabComponents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.componentList)).EndInit();
            this.tabAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actionList)).EndInit();
            this.tabCustAct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.custactList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog msiPath;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView propertyList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Property;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.TabControl tbList;
        private System.Windows.Forms.TabPage tabProperties;
        private System.Windows.Forms.TabPage tabDirectories;
        private System.Windows.Forms.DataGridView directoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultDir;
        private System.Windows.Forms.TabPage tabComponents;
        private System.Windows.Forms.DataGridView componentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyPath;
        private System.Windows.Forms.TabPage tabCustAct;
        private System.Windows.Forms.DataGridView custactList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Target;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtendedType;
        private System.Windows.Forms.TabPage tabAction;
        private System.Windows.Forms.DataGridView actionList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionContext;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallSequence;
        private System.Windows.Forms.TabPage tabTables;
        private System.Windows.Forms.DataGridView dgTables;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columns;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFilePath;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.CheckBox cbxExcludeUI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExportTable;
        private System.Windows.Forms.Button btnExportAll;
        private System.Windows.Forms.SaveFileDialog saveFileSelector;


    }
}

