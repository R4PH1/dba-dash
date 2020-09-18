﻿namespace DBAChecksGUI
{
    partial class SlowQueries
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlowQueries));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsTime = new System.Windows.Forms.ToolStripDropDownButton();
            this.minsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts30Min = new System.Windows.Forms.ToolStripMenuItem();
            this.ts1Hr = new System.Windows.Forms.ToolStripMenuItem();
            this.ts2Hr = new System.Windows.Forms.ToolStripMenuItem();
            this.ts3Hr = new System.Windows.Forms.ToolStripMenuItem();
            this.ts6Hr = new System.Windows.Forms.ToolStripMenuItem();
            this.ts12Hr = new System.Windows.Forms.ToolStripMenuItem();
            this.dayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsGroup = new System.Windows.Forms.ToolStripDropDownButton();
            this.instanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.lblInstance = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInstance = new System.Windows.Forms.ToolStripTextBox();
            this.lblClient = new System.Windows.Forms.ToolStripMenuItem();
            this.txtClient = new System.Windows.Forms.ToolStripTextBox();
            this.lblApp = new System.Windows.Forms.ToolStripMenuItem();
            this.txtApp = new System.Windows.Forms.ToolStripTextBox();
            this.lblDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDatabase = new System.Windows.Forms.ToolStripTextBox();
            this.lblObject = new System.Windows.Forms.ToolStripMenuItem();
            this.txtObject = new System.Windows.Forms.ToolStripTextBox();
            this.lblUser = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUser = new System.Windows.Forms.ToolStripTextBox();
            this.lblText = new System.Windows.Forms.ToolStripMenuItem();
            this.txtText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSlow = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Instance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatabaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.object_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpu_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logical_reads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physical_reads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_hostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_app_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grp = new System.Windows.Forms.DataGridViewLinkColumn();
            this._1to5 = new System.Windows.Forms.DataGridViewLinkColumn();
            this._5to10 = new System.Windows.Forms.DataGridViewLinkColumn();
            this._10to20 = new System.Windows.Forms.DataGridViewLinkColumn();
            this._20to30 = new System.Windows.Forms.DataGridViewLinkColumn();
            this._30to60 = new System.Windows.Forms.DataGridViewLinkColumn();
            this._1to5min = new System.Windows.Forms.DataGridViewLinkColumn();
            this._5to10min = new System.Windows.Forms.DataGridViewLinkColumn();
            this._10to30min = new System.Windows.Forms.DataGridViewLinkColumn();
            this._30to60min = new System.Windows.Forms.DataGridViewLinkColumn();
            this._1hrPlus = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Total = new System.Windows.Forms.DataGridViewLinkColumn();
            this.TotalDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPhysicalIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSummary
            // 
            this.dgvSummary.AllowUserToAddRows = false;
            this.dgvSummary.AllowUserToDeleteRows = false;
            this.dgvSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSummary.BackgroundColor = System.Drawing.Color.White;
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grp,
            this._1to5,
            this._5to10,
            this._10to20,
            this._20to30,
            this._30to60,
            this._1to5min,
            this._5to10min,
            this._10to30min,
            this._30to60min,
            this._1hrPlus,
            this.Total,
            this.TotalDuration,
            this.TotalCPU,
            this.TotalIO,
            this.TotalPhysicalIO});
            this.dgvSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSummary.Location = new System.Drawing.Point(0, 0);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.ReadOnly = true;
            this.dgvSummary.RowHeadersVisible = false;
            this.dgvSummary.RowHeadersWidth = 51;
            this.dgvSummary.RowTemplate.Height = 24;
            this.dgvSummary.Size = new System.Drawing.Size(1829, 388);
            this.dgvSummary.TabIndex = 0;
            this.dgvSummary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSummary_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTime,
            this.tsRefresh,
            this.tsGroup,
            this.toolStripDropDownButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1829, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsTime
            // 
            this.tsTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minsToolStripMenuItem,
            this.ts30Min,
            this.ts1Hr,
            this.ts2Hr,
            this.ts3Hr,
            this.ts6Hr,
            this.ts12Hr,
            this.dayToolStripMenuItem,
            this.toolStripSeparator1,
            this.tsCustom});
            this.tsTime.Image = global::DBAChecksGUI.Properties.Resources.Time_16x;
            this.tsTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTime.Name = "tsTime";
            this.tsTime.Size = new System.Drawing.Size(34, 24);
            this.tsTime.Text = "Time";
            // 
            // minsToolStripMenuItem
            // 
            this.minsToolStripMenuItem.Checked = true;
            this.minsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minsToolStripMenuItem.Name = "minsToolStripMenuItem";
            this.minsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.minsToolStripMenuItem.Tag = "15";
            this.minsToolStripMenuItem.Text = "15 Mins";
            this.minsToolStripMenuItem.Click += new System.EventHandler(this.tsTime_Click);
            // 
            // ts30Min
            // 
            this.ts30Min.CheckOnClick = true;
            this.ts30Min.Name = "ts30Min";
            this.ts30Min.Size = new System.Drawing.Size(224, 26);
            this.ts30Min.Tag = "30";
            this.ts30Min.Text = "30 Mins";
            this.ts30Min.Click += new System.EventHandler(this.tsTime_Click);
            // 
            // ts1Hr
            // 
            this.ts1Hr.Name = "ts1Hr";
            this.ts1Hr.Size = new System.Drawing.Size(224, 26);
            this.ts1Hr.Tag = "60";
            this.ts1Hr.Text = "1Hr";
            this.ts1Hr.Click += new System.EventHandler(this.tsTime_Click);
            // 
            // ts2Hr
            // 
            this.ts2Hr.CheckOnClick = true;
            this.ts2Hr.Name = "ts2Hr";
            this.ts2Hr.Size = new System.Drawing.Size(224, 26);
            this.ts2Hr.Tag = "120";
            this.ts2Hr.Text = "2Hr";
            this.ts2Hr.Click += new System.EventHandler(this.tsTime_Click);
            // 
            // ts3Hr
            // 
            this.ts3Hr.CheckOnClick = true;
            this.ts3Hr.Name = "ts3Hr";
            this.ts3Hr.Size = new System.Drawing.Size(224, 26);
            this.ts3Hr.Tag = "180";
            this.ts3Hr.Text = "3Hr";
            this.ts3Hr.Click += new System.EventHandler(this.tsTime_Click);
            // 
            // ts6Hr
            // 
            this.ts6Hr.CheckOnClick = true;
            this.ts6Hr.Name = "ts6Hr";
            this.ts6Hr.Size = new System.Drawing.Size(224, 26);
            this.ts6Hr.Tag = "360";
            this.ts6Hr.Text = "6Hr";
            this.ts6Hr.Click += new System.EventHandler(this.tsTime_Click);
            // 
            // ts12Hr
            // 
            this.ts12Hr.CheckOnClick = true;
            this.ts12Hr.Name = "ts12Hr";
            this.ts12Hr.Size = new System.Drawing.Size(224, 26);
            this.ts12Hr.Tag = "720";
            this.ts12Hr.Text = "12Hr";
            this.ts12Hr.Click += new System.EventHandler(this.tsTime_Click);
            // 
            // dayToolStripMenuItem
            // 
            this.dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            this.dayToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dayToolStripMenuItem.Tag = "1440";
            this.dayToolStripMenuItem.Text = "1 Day";
            this.dayToolStripMenuItem.Click += new System.EventHandler(this.tsTime_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // tsCustom
            // 
            this.tsCustom.Name = "tsCustom";
            this.tsCustom.Size = new System.Drawing.Size(224, 26);
            this.tsCustom.Tag = "-1";
            this.tsCustom.Text = "Custom";
            this.tsCustom.Click += new System.EventHandler(this.tsCustom_Click);
            // 
            // tsRefresh
            // 
            this.tsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRefresh.Image = global::DBAChecksGUI.Properties.Resources._112_RefreshArrow_Green_16x16_72;
            this.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRefresh.Name = "tsRefresh";
            this.tsRefresh.Size = new System.Drawing.Size(29, 24);
            this.tsRefresh.Text = "Refresh";
            this.tsRefresh.Click += new System.EventHandler(this.tsRefresh_Click);
            // 
            // tsGroup
            // 
            this.tsGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.databaseNameToolStripMenuItem,
            this.instanceToolStripMenuItem,
            this.objectNameToolStripMenuItem,
            this.usernameToolStripMenuItem});
            this.tsGroup.Image = ((System.Drawing.Image)(resources.GetObject("tsGroup.Image")));
            this.tsGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGroup.Name = "tsGroup";
            this.tsGroup.Size = new System.Drawing.Size(84, 24);
            this.tsGroup.Text = "Group By";
            // 
            // instanceToolStripMenuItem
            // 
            this.instanceToolStripMenuItem.Checked = true;
            this.instanceToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.instanceToolStripMenuItem.Name = "instanceToolStripMenuItem";
            this.instanceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.instanceToolStripMenuItem.Tag = "ConnectionID";
            this.instanceToolStripMenuItem.Text = "Instance";
            this.instanceToolStripMenuItem.Click += new System.EventHandler(this.GroupBy_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientToolStripMenuItem.Tag = "client_hostname";
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.GroupBy_Click);
            // 
            // usernameToolStripMenuItem
            // 
            this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            this.usernameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usernameToolStripMenuItem.Tag = "username";
            this.usernameToolStripMenuItem.Text = "Username";
            this.usernameToolStripMenuItem.Click += new System.EventHandler(this.GroupBy_Click);
            // 
            // objectNameToolStripMenuItem
            // 
            this.objectNameToolStripMenuItem.Name = "objectNameToolStripMenuItem";
            this.objectNameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.objectNameToolStripMenuItem.Tag = "object_name";
            this.objectNameToolStripMenuItem.Text = "Object Name";
            this.objectNameToolStripMenuItem.Click += new System.EventHandler(this.GroupBy_Click);
            // 
            // databaseNameToolStripMenuItem
            // 
            this.databaseNameToolStripMenuItem.Name = "databaseNameToolStripMenuItem";
            this.databaseNameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.databaseNameToolStripMenuItem.Tag = "DatabaseName";
            this.databaseNameToolStripMenuItem.Text = "Database Name";
            this.databaseNameToolStripMenuItem.Click += new System.EventHandler(this.GroupBy_Click);
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.appToolStripMenuItem.Tag = "client_app_name";
            this.appToolStripMenuItem.Text = "App";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInstance,
            this.lblClient,
            this.lblApp,
            this.lblDatabase,
            this.lblObject,
            this.lblUser,
            this.lblText,
            this.toolStripSeparator2,
            this.resetToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::DBAChecksGUI.Properties.Resources.FilterDropdown_16x;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // lblInstance
            // 
            this.lblInstance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtInstance});
            this.lblInstance.Name = "lblInstance";
            this.lblInstance.Size = new System.Drawing.Size(224, 26);
            this.lblInstance.Text = "Instance";
            // 
            // txtInstance
            // 
            this.txtInstance.BackColor = System.Drawing.Color.AliceBlue;
            this.txtInstance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(200, 27);
            this.txtInstance.TextChanged += new System.EventHandler(this.txtInstance_TextChanged);
            // 
            // lblClient
            // 
            this.lblClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtClient});
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(224, 26);
            this.lblClient.Text = "Client";
            // 
            // txtClient
            // 
            this.txtClient.BackColor = System.Drawing.Color.AliceBlue;
            this.txtClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(200, 27);
            this.txtClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // lblApp
            // 
            this.lblApp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtApp});
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(224, 26);
            this.lblApp.Text = "App";
            // 
            // txtApp
            // 
            this.txtApp.BackColor = System.Drawing.Color.AliceBlue;
            this.txtApp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(200, 27);
            this.txtApp.TextChanged += new System.EventHandler(this.txtApp_TextChanged);
            // 
            // lblDatabase
            // 
            this.lblDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDatabase});
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(224, 26);
            this.lblDatabase.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDatabase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(200, 27);
            this.txtDatabase.TextChanged += new System.EventHandler(this.txtDatabase_TextChanged);
            // 
            // lblObject
            // 
            this.lblObject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtObject});
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(224, 26);
            this.lblObject.Text = "Object";
            // 
            // txtObject
            // 
            this.txtObject.BackColor = System.Drawing.Color.AliceBlue;
            this.txtObject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(200, 27);
            this.txtObject.TextChanged += new System.EventHandler(this.txtObject_TextChanged);
            // 
            // lblUser
            // 
            this.lblUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtUser});
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(224, 26);
            this.lblUser.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 27);
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblText
            // 
            this.lblText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtText});
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(224, 26);
            this.lblText.Text = "Text";
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.Color.AliceBlue;
            this.txtText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(200, 27);
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // dgvSlow
            // 
            this.dgvSlow.AllowUserToAddRows = false;
            this.dgvSlow.AllowUserToDeleteRows = false;
            this.dgvSlow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSlow.BackgroundColor = System.Drawing.Color.White;
            this.dgvSlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Instance,
            this.DatabaseName,
            this.event_type,
            this.object_name,
            this.timestamp,
            this.duration,
            this.cpu_time,
            this.logical_reads,
            this.physical_reads,
            this.Writes,
            this.username,
            this.client_hostname,
            this.client_app_name,
            this.Result,
            this.Text});
            this.dgvSlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSlow.Location = new System.Drawing.Point(0, 0);
            this.dgvSlow.Name = "dgvSlow";
            this.dgvSlow.ReadOnly = true;
            this.dgvSlow.RowHeadersVisible = false;
            this.dgvSlow.RowHeadersWidth = 51;
            this.dgvSlow.RowTemplate.Height = 24;
            this.dgvSlow.Size = new System.Drawing.Size(1829, 679);
            this.dgvSlow.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvSummary);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSlow);
            this.splitContainer1.Size = new System.Drawing.Size(1829, 1071);
            this.splitContainer1.SplitterDistance = 388;
            this.splitContainer1.TabIndex = 5;
            // 
            // Instance
            // 
            this.Instance.DataPropertyName = "Instance";
            this.Instance.HeaderText = "Instance";
            this.Instance.MinimumWidth = 6;
            this.Instance.Name = "Instance";
            this.Instance.ReadOnly = true;
            this.Instance.Width = 90;
            // 
            // DatabaseName
            // 
            this.DatabaseName.DataPropertyName = "DatabaseName";
            this.DatabaseName.HeaderText = "Database";
            this.DatabaseName.MinimumWidth = 6;
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.ReadOnly = true;
            this.DatabaseName.Width = 98;
            // 
            // event_type
            // 
            this.event_type.DataPropertyName = "event_type";
            this.event_type.HeaderText = "Event Type";
            this.event_type.MinimumWidth = 6;
            this.event_type.Name = "event_type";
            this.event_type.ReadOnly = true;
            // 
            // object_name
            // 
            this.object_name.DataPropertyName = "object_name";
            this.object_name.HeaderText = "Object Name";
            this.object_name.MinimumWidth = 6;
            this.object_name.Name = "object_name";
            this.object_name.ReadOnly = true;
            this.object_name.Width = 109;
            // 
            // timestamp
            // 
            this.timestamp.DataPropertyName = "timestamp";
            this.timestamp.HeaderText = "Time";
            this.timestamp.MinimumWidth = 6;
            this.timestamp.Name = "timestamp";
            this.timestamp.ReadOnly = true;
            this.timestamp.Width = 68;
            // 
            // duration
            // 
            this.duration.DataPropertyName = "duration";
            dataGridViewCellStyle16.Format = "#,#,,.000";
            this.duration.DefaultCellStyle = dataGridViewCellStyle16;
            this.duration.HeaderText = "Duration (sec)";
            this.duration.MinimumWidth = 6;
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.Width = 117;
            // 
            // cpu_time
            // 
            this.cpu_time.DataPropertyName = "cpu_time";
            dataGridViewCellStyle17.Format = "#,#,,.000";
            this.cpu_time.DefaultCellStyle = dataGridViewCellStyle17;
            this.cpu_time.HeaderText = "CPU (sec)";
            this.cpu_time.MinimumWidth = 6;
            this.cpu_time.Name = "cpu_time";
            this.cpu_time.ReadOnly = true;
            this.cpu_time.Width = 93;
            // 
            // logical_reads
            // 
            this.logical_reads.DataPropertyName = "logical_reads";
            dataGridViewCellStyle18.Format = "N0";
            this.logical_reads.DefaultCellStyle = dataGridViewCellStyle18;
            this.logical_reads.HeaderText = "Logical Reads";
            this.logical_reads.MinimumWidth = 6;
            this.logical_reads.Name = "logical_reads";
            this.logical_reads.ReadOnly = true;
            this.logical_reads.Width = 117;
            // 
            // physical_reads
            // 
            this.physical_reads.DataPropertyName = "physical_reads";
            dataGridViewCellStyle19.Format = "N0";
            this.physical_reads.DefaultCellStyle = dataGridViewCellStyle19;
            this.physical_reads.HeaderText = "Physical Reads";
            this.physical_reads.MinimumWidth = 6;
            this.physical_reads.Name = "physical_reads";
            this.physical_reads.ReadOnly = true;
            this.physical_reads.Width = 123;
            // 
            // Writes
            // 
            this.Writes.DataPropertyName = "Writes";
            dataGridViewCellStyle20.Format = "N0";
            this.Writes.DefaultCellStyle = dataGridViewCellStyle20;
            this.Writes.HeaderText = "Writes";
            this.Writes.MinimumWidth = 6;
            this.Writes.Name = "Writes";
            this.Writes.ReadOnly = true;
            this.Writes.Width = 77;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "UserName";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 104;
            // 
            // client_hostname
            // 
            this.client_hostname.DataPropertyName = "client_hostname";
            this.client_hostname.HeaderText = "Client";
            this.client_hostname.MinimumWidth = 6;
            this.client_hostname.Name = "client_hostname";
            this.client_hostname.ReadOnly = true;
            this.client_hostname.Width = 72;
            // 
            // client_app_name
            // 
            this.client_app_name.DataPropertyName = "client_app_name";
            this.client_app_name.HeaderText = "App";
            this.client_app_name.MinimumWidth = 6;
            this.client_app_name.Name = "client_app_name";
            this.client_app_name.ReadOnly = true;
            this.client_app_name.Width = 62;
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Result";
            this.Result.HeaderText = "Result";
            this.Result.MinimumWidth = 6;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 77;
            // 
            // Text
            // 
            this.Text.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Text.DataPropertyName = "Text";
            this.Text.HeaderText = "Text";
            this.Text.MinimumWidth = 6;
            this.Text.Name = "Text";
            this.Text.ReadOnly = true;
            // 
            // Grp
            // 
            this.Grp.DataPropertyName = "Grp";
            this.Grp.HeaderText = "Group";
            this.Grp.MinimumWidth = 6;
            this.Grp.Name = "Grp";
            this.Grp.ReadOnly = true;
            this.Grp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Grp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Grp.Width = 77;
            // 
            // _1to5
            // 
            this._1to5.DataPropertyName = "1-5 seconds";
            dataGridViewCellStyle1.Format = "#,#";
            this._1to5.DefaultCellStyle = dataGridViewCellStyle1;
            this._1to5.HeaderText = "1-5 Seconds";
            this._1to5.MinimumWidth = 6;
            this._1to5.Name = "_1to5";
            this._1to5.ReadOnly = true;
            this._1to5.Width = 94;
            // 
            // _5to10
            // 
            this._5to10.DataPropertyName = "5-10 seconds";
            dataGridViewCellStyle2.Format = "#,#";
            this._5to10.DefaultCellStyle = dataGridViewCellStyle2;
            this._5to10.HeaderText = "5-10 seconds";
            this._5to10.MinimumWidth = 6;
            this._5to10.Name = "_5to10";
            this._5to10.ReadOnly = true;
            // 
            // _10to20
            // 
            this._10to20.DataPropertyName = "10-20 seconds";
            dataGridViewCellStyle3.Format = "#,#";
            this._10to20.DefaultCellStyle = dataGridViewCellStyle3;
            this._10to20.HeaderText = "10-20 Seconds";
            this._10to20.MinimumWidth = 6;
            this._10to20.Name = "_10to20";
            this._10to20.ReadOnly = true;
            this._10to20.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._10to20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._10to20.Width = 122;
            // 
            // _20to30
            // 
            this._20to30.DataPropertyName = "20-30 seconds";
            dataGridViewCellStyle4.Format = "#,#";
            this._20to30.DefaultCellStyle = dataGridViewCellStyle4;
            this._20to30.HeaderText = "20-30 Seconds";
            this._20to30.MinimumWidth = 6;
            this._20to30.Name = "_20to30";
            this._20to30.ReadOnly = true;
            this._20to30.Width = 99;
            // 
            // _30to60
            // 
            this._30to60.DataPropertyName = "30-60 seconds";
            dataGridViewCellStyle5.Format = "#,#";
            this._30to60.DefaultCellStyle = dataGridViewCellStyle5;
            this._30to60.HeaderText = "30-60 Seconds";
            this._30to60.MinimumWidth = 6;
            this._30to60.Name = "_30to60";
            this._30to60.ReadOnly = true;
            this._30to60.Width = 99;
            // 
            // _1to5min
            // 
            this._1to5min.DataPropertyName = "1-5 minutes";
            dataGridViewCellStyle6.Format = "#,#";
            this._1to5min.DefaultCellStyle = dataGridViewCellStyle6;
            this._1to5min.HeaderText = "1-5 min";
            this._1to5min.MinimumWidth = 6;
            this._1to5min.Name = "_1to5min";
            this._1to5min.ReadOnly = true;
            this._1to5min.Width = 55;
            // 
            // _5to10min
            // 
            this._5to10min.DataPropertyName = "5-10 minutes";
            dataGridViewCellStyle7.Format = "#,#";
            this._5to10min.DefaultCellStyle = dataGridViewCellStyle7;
            this._5to10min.HeaderText = "5-10 min";
            this._5to10min.MinimumWidth = 6;
            this._5to10min.Name = "_5to10min";
            this._5to10min.ReadOnly = true;
            this._5to10min.Width = 62;
            // 
            // _10to30min
            // 
            this._10to30min.DataPropertyName = "10-30 minutes";
            dataGridViewCellStyle8.Format = "#,#";
            this._10to30min.DefaultCellStyle = dataGridViewCellStyle8;
            this._10to30min.HeaderText = "10-30 min";
            this._10to30min.MinimumWidth = 6;
            this._10to30min.Name = "_10to30min";
            this._10to30min.ReadOnly = true;
            this._10to30min.Width = 69;
            // 
            // _30to60min
            // 
            this._30to60min.DataPropertyName = "30-60 minutes";
            dataGridViewCellStyle9.Format = "#,#";
            this._30to60min.DefaultCellStyle = dataGridViewCellStyle9;
            this._30to60min.HeaderText = "30-60 min";
            this._30to60min.MinimumWidth = 6;
            this._30to60min.Name = "_30to60min";
            this._30to60min.ReadOnly = true;
            this._30to60min.Width = 69;
            // 
            // _1hrPlus
            // 
            this._1hrPlus.DataPropertyName = "1hr+";
            dataGridViewCellStyle10.Format = "#,#";
            this._1hrPlus.DefaultCellStyle = dataGridViewCellStyle10;
            this._1hrPlus.HeaderText = "1Hr+";
            this._1hrPlus.MinimumWidth = 6;
            this._1hrPlus.Name = "_1hrPlus";
            this._1hrPlus.ReadOnly = true;
            this._1hrPlus.Width = 45;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle11.Format = "#,#";
            this.Total.DefaultCellStyle = dataGridViewCellStyle11;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 46;
            // 
            // TotalDuration
            // 
            this.TotalDuration.DataPropertyName = "TotalDuration";
            dataGridViewCellStyle12.Format = "#,#,,.000";
            this.TotalDuration.DefaultCellStyle = dataGridViewCellStyle12;
            this.TotalDuration.HeaderText = "Total Duration (sec)";
            this.TotalDuration.MinimumWidth = 6;
            this.TotalDuration.Name = "TotalDuration";
            this.TotalDuration.ReadOnly = true;
            this.TotalDuration.Width = 149;
            // 
            // TotalCPU
            // 
            this.TotalCPU.DataPropertyName = "TotalCPU";
            dataGridViewCellStyle13.Format = "#,#,,.000";
            this.TotalCPU.DefaultCellStyle = dataGridViewCellStyle13;
            this.TotalCPU.HeaderText = "Total CPU (sec)";
            this.TotalCPU.MinimumWidth = 6;
            this.TotalCPU.Name = "TotalCPU";
            this.TotalCPU.ReadOnly = true;
            this.TotalCPU.Width = 126;
            // 
            // TotalIO
            // 
            this.TotalIO.DataPropertyName = "TotalIO";
            dataGridViewCellStyle14.Format = "N0";
            this.TotalIO.DefaultCellStyle = dataGridViewCellStyle14;
            this.TotalIO.HeaderText = "Total IO";
            this.TotalIO.MinimumWidth = 6;
            this.TotalIO.Name = "TotalIO";
            this.TotalIO.ReadOnly = true;
            this.TotalIO.Width = 81;
            // 
            // TotalPhysicalIO
            // 
            this.TotalPhysicalIO.DataPropertyName = "TotalPhysicalIO";
            dataGridViewCellStyle15.Format = "N0";
            this.TotalPhysicalIO.DefaultCellStyle = dataGridViewCellStyle15;
            this.TotalPhysicalIO.HeaderText = "Total Physical IO";
            this.TotalPhysicalIO.MinimumWidth = 6;
            this.TotalPhysicalIO.Name = "TotalPhysicalIO";
            this.TotalPhysicalIO.ReadOnly = true;
            this.TotalPhysicalIO.Width = 118;
            // 
            // SlowQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SlowQueries";
            this.Size = new System.Drawing.Size(1829, 1098);
            this.Load += new System.EventHandler(this.SlowQueries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlow)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsTime;
        private System.Windows.Forms.ToolStripMenuItem ts30Min;
        private System.Windows.Forms.ToolStripMenuItem ts1Hr;
        private System.Windows.Forms.ToolStripMenuItem ts2Hr;
        private System.Windows.Forms.ToolStripMenuItem ts3Hr;
        private System.Windows.Forms.ToolStripMenuItem ts6Hr;
        private System.Windows.Forms.ToolStripMenuItem ts12Hr;
        private System.Windows.Forms.ToolStripMenuItem dayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsCustom;
        private System.Windows.Forms.ToolStripButton tsRefresh;
        private System.Windows.Forms.ToolStripMenuItem minsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsGroup;
        private System.Windows.Forms.ToolStripMenuItem instanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem lblInstance;
        private System.Windows.Forms.ToolStripTextBox txtInstance;
        private System.Windows.Forms.ToolStripMenuItem lblClient;
        private System.Windows.Forms.ToolStripTextBox txtClient;
        private System.Windows.Forms.ToolStripMenuItem lblApp;
        private System.Windows.Forms.ToolStripTextBox txtApp;
        private System.Windows.Forms.ToolStripMenuItem lblDatabase;
        private System.Windows.Forms.ToolStripTextBox txtDatabase;
        private System.Windows.Forms.ToolStripMenuItem lblObject;
        private System.Windows.Forms.ToolStripTextBox txtObject;
        private System.Windows.Forms.ToolStripMenuItem lblUser;
        private System.Windows.Forms.ToolStripTextBox txtUser;
        private System.Windows.Forms.ToolStripMenuItem lblText;
        private System.Windows.Forms.ToolStripTextBox txtText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSlow;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instance;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatabaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn object_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpu_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn logical_reads;
        private System.Windows.Forms.DataGridViewTextBoxColumn physical_reads;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writes;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_hostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_app_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
        private System.Windows.Forms.DataGridViewLinkColumn Grp;
        private System.Windows.Forms.DataGridViewLinkColumn _1to5;
        private System.Windows.Forms.DataGridViewLinkColumn _5to10;
        private System.Windows.Forms.DataGridViewLinkColumn _10to20;
        private System.Windows.Forms.DataGridViewLinkColumn _20to30;
        private System.Windows.Forms.DataGridViewLinkColumn _30to60;
        private System.Windows.Forms.DataGridViewLinkColumn _1to5min;
        private System.Windows.Forms.DataGridViewLinkColumn _5to10min;
        private System.Windows.Forms.DataGridViewLinkColumn _10to30min;
        private System.Windows.Forms.DataGridViewLinkColumn _30to60min;
        private System.Windows.Forms.DataGridViewLinkColumn _1hrPlus;
        private System.Windows.Forms.DataGridViewLinkColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPhysicalIO;
    }
}