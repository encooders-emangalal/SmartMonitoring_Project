namespace SmartMonitoring
{
    partial class frmMonitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonitor));
            this.pnlServers = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCounterValue = new System.Windows.Forms.TextBox();
            this.txtSelServerName = new System.Windows.Forms.TextBox();
            this.txtSelCounterID = new System.Windows.Forms.TextBox();
            this.txtSelMonitorID = new System.Windows.Forms.TextBox();
            this.txtSelServerID = new System.Windows.Forms.TextBox();
            this.gvServers = new System.Windows.Forms.DataGridView();
            this.Server_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_image_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.SERVER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnuServers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuServerAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServerEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServerDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServerDuplicate = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMonitors = new System.Windows.Forms.Panel();
            this.gvMonitors = new System.Windows.Forms.DataGridView();
            this.group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitor_image_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitor_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCounters = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblChart1Value = new System.Windows.Forms.Label();
            this.Chart1 = new LiveCharts.WinForms.AngularGauge();
            this.Chart2 = new LiveCharts.WinForms.CartesianChart();
            this.gvCounters = new System.Windows.Forms.DataGridView();
            this.counter_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counter_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instance_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instance_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.average_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimum_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximum_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnuCounters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCounterAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCounterDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCounterDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNotificationRules = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCounterSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCounterMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCounterMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCounterSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCounterViewData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCounterExportData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnJobStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.btnErrors = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbActivate = new System.Windows.Forms.ToolStripButton();
            this.btnJobLocation = new System.Windows.Forms.ToolStripButton();
            this.tmrSelCounter = new System.Windows.Forms.Timer(this.components);
            this.pnlServers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvServers)).BeginInit();
            this.cmnuServers.SuspendLayout();
            this.pnlMonitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonitors)).BeginInit();
            this.pnlCounters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCounters)).BeginInit();
            this.cmnuCounters.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlServers
            // 
            this.pnlServers.Controls.Add(this.panel1);
            this.pnlServers.Controls.Add(this.gvServers);
            this.pnlServers.Location = new System.Drawing.Point(0, 91);
            this.pnlServers.Name = "pnlServers";
            this.pnlServers.Size = new System.Drawing.Size(250, 561);
            this.pnlServers.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCounterValue);
            this.panel1.Controls.Add(this.txtSelServerName);
            this.panel1.Controls.Add(this.txtSelCounterID);
            this.panel1.Controls.Add(this.txtSelMonitorID);
            this.panel1.Controls.Add(this.txtSelServerID);
            this.panel1.Location = new System.Drawing.Point(23, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 149);
            this.panel1.TabIndex = 6;
            // 
            // txtCounterValue
            // 
            this.txtCounterValue.Location = new System.Drawing.Point(3, 115);
            this.txtCounterValue.Name = "txtCounterValue";
            this.txtCounterValue.ReadOnly = true;
            this.txtCounterValue.Size = new System.Drawing.Size(191, 20);
            this.txtCounterValue.TabIndex = 4;
            // 
            // txtSelServerName
            // 
            this.txtSelServerName.Location = new System.Drawing.Point(6, 38);
            this.txtSelServerName.Name = "txtSelServerName";
            this.txtSelServerName.ReadOnly = true;
            this.txtSelServerName.Size = new System.Drawing.Size(191, 20);
            this.txtSelServerName.TabIndex = 3;
            // 
            // txtSelCounterID
            // 
            this.txtSelCounterID.Location = new System.Drawing.Point(6, 89);
            this.txtSelCounterID.Name = "txtSelCounterID";
            this.txtSelCounterID.ReadOnly = true;
            this.txtSelCounterID.Size = new System.Drawing.Size(191, 20);
            this.txtSelCounterID.TabIndex = 2;
            // 
            // txtSelMonitorID
            // 
            this.txtSelMonitorID.Location = new System.Drawing.Point(6, 63);
            this.txtSelMonitorID.Name = "txtSelMonitorID";
            this.txtSelMonitorID.ReadOnly = true;
            this.txtSelMonitorID.Size = new System.Drawing.Size(191, 20);
            this.txtSelMonitorID.TabIndex = 1;
            // 
            // txtSelServerID
            // 
            this.txtSelServerID.Location = new System.Drawing.Point(6, 13);
            this.txtSelServerID.Name = "txtSelServerID";
            this.txtSelServerID.ReadOnly = true;
            this.txtSelServerID.Size = new System.Drawing.Size(191, 20);
            this.txtSelServerID.TabIndex = 0;
            // 
            // gvServers
            // 
            this.gvServers.AllowUserToAddRows = false;
            this.gvServers.AllowUserToDeleteRows = false;
            this.gvServers.AllowUserToResizeColumns = false;
            this.gvServers.AllowUserToResizeRows = false;
            this.gvServers.BackgroundColor = System.Drawing.Color.White;
            this.gvServers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvServers.ColumnHeadersVisible = false;
            this.gvServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Server_ID,
            this.server_image_id,
            this.server_image,
            this.SERVER_NAME});
            this.gvServers.ContextMenuStrip = this.cmnuServers;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvServers.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvServers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gvServers.Location = new System.Drawing.Point(0, 0);
            this.gvServers.Name = "gvServers";
            this.gvServers.ReadOnly = true;
            this.gvServers.RowHeadersVisible = false;
            this.gvServers.RowHeadersWidth = 25;
            this.gvServers.RowTemplate.Height = 44;
            this.gvServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvServers.ShowEditingIcon = false;
            this.gvServers.Size = new System.Drawing.Size(250, 561);
            this.gvServers.TabIndex = 26;
            this.gvServers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvServers_RowEnter);
            this.gvServers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvServers_MouseDown);
            // 
            // Server_ID
            // 
            this.Server_ID.DataPropertyName = "server_id";
            this.Server_ID.HeaderText = "Server ID";
            this.Server_ID.MinimumWidth = 6;
            this.Server_ID.Name = "Server_ID";
            this.Server_ID.ReadOnly = true;
            this.Server_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Server_ID.Visible = false;
            this.Server_ID.Width = 70;
            // 
            // server_image_id
            // 
            this.server_image_id.HeaderText = "server_image_id";
            this.server_image_id.MinimumWidth = 6;
            this.server_image_id.Name = "server_image_id";
            this.server_image_id.ReadOnly = true;
            this.server_image_id.Visible = false;
            this.server_image_id.Width = 125;
            // 
            // server_image
            // 
            this.server_image.HeaderText = "server_image";
            this.server_image.MinimumWidth = 6;
            this.server_image.Name = "server_image";
            this.server_image.ReadOnly = true;
            this.server_image.Width = 40;
            // 
            // SERVER_NAME
            // 
            this.SERVER_NAME.DataPropertyName = "server_name";
            this.SERVER_NAME.HeaderText = "Server";
            this.SERVER_NAME.MinimumWidth = 6;
            this.SERVER_NAME.Name = "SERVER_NAME";
            this.SERVER_NAME.ReadOnly = true;
            this.SERVER_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SERVER_NAME.Width = 200;
            // 
            // cmnuServers
            // 
            this.cmnuServers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnuServers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuServerAdd,
            this.mnuServerEdit,
            this.mnuServerDelete,
            this.mnuServerDuplicate});
            this.cmnuServers.Name = "cmnuServers";
            this.cmnuServers.Size = new System.Drawing.Size(182, 92);
            // 
            // mnuServerAdd
            // 
            this.mnuServerAdd.Name = "mnuServerAdd";
            this.mnuServerAdd.Size = new System.Drawing.Size(181, 22);
            this.mnuServerAdd.Text = "Add Server";
            this.mnuServerAdd.Click += new System.EventHandler(this.mnuServerAdd_Click);
            // 
            // mnuServerEdit
            // 
            this.mnuServerEdit.Name = "mnuServerEdit";
            this.mnuServerEdit.Size = new System.Drawing.Size(181, 22);
            this.mnuServerEdit.Text = "Edit Server";
            this.mnuServerEdit.Click += new System.EventHandler(this.mnuServerEdit_Click);
            // 
            // mnuServerDelete
            // 
            this.mnuServerDelete.Name = "mnuServerDelete";
            this.mnuServerDelete.Size = new System.Drawing.Size(181, 22);
            this.mnuServerDelete.Text = "Delete Server";
            this.mnuServerDelete.Click += new System.EventHandler(this.mnuServerDelete_Click);
            // 
            // mnuServerDuplicate
            // 
            this.mnuServerDuplicate.Name = "mnuServerDuplicate";
            this.mnuServerDuplicate.Size = new System.Drawing.Size(181, 22);
            this.mnuServerDuplicate.Text = "Duplicate this Server";
            this.mnuServerDuplicate.Click += new System.EventHandler(this.mnuServerDuplicate_Click);
            // 
            // pnlMonitors
            // 
            this.pnlMonitors.Controls.Add(this.gvMonitors);
            this.pnlMonitors.Location = new System.Drawing.Point(255, 91);
            this.pnlMonitors.Name = "pnlMonitors";
            this.pnlMonitors.Size = new System.Drawing.Size(250, 561);
            this.pnlMonitors.TabIndex = 4;
            // 
            // gvMonitors
            // 
            this.gvMonitors.AllowUserToAddRows = false;
            this.gvMonitors.AllowUserToDeleteRows = false;
            this.gvMonitors.AllowUserToResizeColumns = false;
            this.gvMonitors.AllowUserToResizeRows = false;
            this.gvMonitors.BackgroundColor = System.Drawing.Color.White;
            this.gvMonitors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvMonitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMonitors.ColumnHeadersVisible = false;
            this.gvMonitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.group_id,
            this.monitor_image_id,
            this.monitor_image,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMonitors.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvMonitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMonitors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gvMonitors.Location = new System.Drawing.Point(0, 0);
            this.gvMonitors.Name = "gvMonitors";
            this.gvMonitors.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMonitors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvMonitors.RowHeadersVisible = false;
            this.gvMonitors.RowHeadersWidth = 25;
            this.gvMonitors.RowTemplate.Height = 44;
            this.gvMonitors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMonitors.ShowEditingIcon = false;
            this.gvMonitors.Size = new System.Drawing.Size(250, 561);
            this.gvMonitors.TabIndex = 26;
            this.gvMonitors.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMonitors_RowEnter);
            // 
            // group_id
            // 
            this.group_id.DataPropertyName = "group_id";
            this.group_id.HeaderText = "MONITOR ID";
            this.group_id.MinimumWidth = 6;
            this.group_id.Name = "group_id";
            this.group_id.ReadOnly = true;
            this.group_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.group_id.Visible = false;
            this.group_id.Width = 70;
            // 
            // monitor_image_id
            // 
            this.monitor_image_id.HeaderText = "monitor_image_id";
            this.monitor_image_id.MinimumWidth = 6;
            this.monitor_image_id.Name = "monitor_image_id";
            this.monitor_image_id.ReadOnly = true;
            this.monitor_image_id.Visible = false;
            this.monitor_image_id.Width = 125;
            // 
            // monitor_image
            // 
            this.monitor_image.HeaderText = "";
            this.monitor_image.MinimumWidth = 6;
            this.monitor_image.Name = "monitor_image";
            this.monitor_image.ReadOnly = true;
            this.monitor_image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.monitor_image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.monitor_image.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "group_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Monitor";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // pnlCounters
            // 
            this.pnlCounters.Controls.Add(this.splitContainer1);
            this.pnlCounters.Location = new System.Drawing.Point(510, 91);
            this.pnlCounters.Name = "pnlCounters";
            this.pnlCounters.Size = new System.Drawing.Size(701, 561);
            this.pnlCounters.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gvCounters);
            this.splitContainer1.Size = new System.Drawing.Size(701, 561);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.lblChart1Value);
            this.splitContainer2.Panel1.Controls.Add(this.Chart1);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(30, 32, 30, 30);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.Chart2);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer2.Size = new System.Drawing.Size(701, 311);
            this.splitContainer2.SplitterDistance = 262;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblChart1Value
            // 
            this.lblChart1Value.AutoSize = true;
            this.lblChart1Value.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChart1Value.Location = new System.Drawing.Point(146, 318);
            this.lblChart1Value.Name = "lblChart1Value";
            this.lblChart1Value.Size = new System.Drawing.Size(29, 16);
            this.lblChart1Value.TabIndex = 4;
            this.lblChart1Value.Text = "0%";
            // 
            // Chart1
            // 
            this.Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart1.Location = new System.Drawing.Point(30, 32);
            this.Chart1.Name = "Chart1";
            this.Chart1.Size = new System.Drawing.Size(200, 247);
            this.Chart1.TabIndex = 3;
            this.Chart1.Text = "lll";
            // 
            // Chart2
            // 
            this.Chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart2.Location = new System.Drawing.Point(10, 10);
            this.Chart2.Name = "Chart2";
            this.Chart2.Size = new System.Drawing.Size(413, 289);
            this.Chart2.TabIndex = 0;
            this.Chart2.Text = "cartesianChart1";
            // 
            // gvCounters
            // 
            this.gvCounters.AllowUserToAddRows = false;
            this.gvCounters.AllowUserToDeleteRows = false;
            this.gvCounters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCounters.BackgroundColor = System.Drawing.Color.White;
            this.gvCounters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvCounters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCounters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.counter_id,
            this.counter_name,
            this.instance_id,
            this.instance_name,
            this.computer_name,
            this.current_value,
            this.average_value,
            this.minimum_value,
            this.maximum_value});
            this.gvCounters.ContextMenuStrip = this.cmnuCounters;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCounters.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvCounters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvCounters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gvCounters.Location = new System.Drawing.Point(0, 0);
            this.gvCounters.MultiSelect = false;
            this.gvCounters.Name = "gvCounters";
            this.gvCounters.ReadOnly = true;
            this.gvCounters.RowHeadersVisible = false;
            this.gvCounters.RowHeadersWidth = 25;
            this.gvCounters.RowTemplate.Height = 30;
            this.gvCounters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCounters.ShowEditingIcon = false;
            this.gvCounters.Size = new System.Drawing.Size(701, 246);
            this.gvCounters.TabIndex = 27;
            this.gvCounters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCounters_CellContentClick);
            this.gvCounters.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCounters_RowEnter);
            this.gvCounters.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvCounters_MouseDown);
            // 
            // counter_id
            // 
            this.counter_id.DataPropertyName = "counter_id";
            this.counter_id.HeaderText = "Counter ID";
            this.counter_id.MinimumWidth = 6;
            this.counter_id.Name = "counter_id";
            this.counter_id.ReadOnly = true;
            this.counter_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.counter_id.Visible = false;
            // 
            // counter_name
            // 
            this.counter_name.DataPropertyName = "counter_description";
            this.counter_name.HeaderText = "Counter";
            this.counter_name.MinimumWidth = 6;
            this.counter_name.Name = "counter_name";
            this.counter_name.ReadOnly = true;
            this.counter_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // instance_id
            // 
            this.instance_id.DataPropertyName = "instance_id";
            this.instance_id.HeaderText = "instance_id";
            this.instance_id.MinimumWidth = 6;
            this.instance_id.Name = "instance_id";
            this.instance_id.ReadOnly = true;
            // 
            // instance_name
            // 
            this.instance_name.DataPropertyName = "instance_name";
            this.instance_name.HeaderText = "Instance";
            this.instance_name.MinimumWidth = 6;
            this.instance_name.Name = "instance_name";
            this.instance_name.ReadOnly = true;
            // 
            // computer_name
            // 
            this.computer_name.DataPropertyName = "machine_name";
            this.computer_name.HeaderText = "Computer";
            this.computer_name.MinimumWidth = 6;
            this.computer_name.Name = "computer_name";
            this.computer_name.ReadOnly = true;
            // 
            // current_value
            // 
            this.current_value.DataPropertyName = "current_value";
            this.current_value.HeaderText = "Current";
            this.current_value.MinimumWidth = 6;
            this.current_value.Name = "current_value";
            this.current_value.ReadOnly = true;
            // 
            // average_value
            // 
            this.average_value.DataPropertyName = "average_value";
            this.average_value.HeaderText = "Average";
            this.average_value.MinimumWidth = 6;
            this.average_value.Name = "average_value";
            this.average_value.ReadOnly = true;
            // 
            // minimum_value
            // 
            this.minimum_value.DataPropertyName = "minimum_value";
            this.minimum_value.HeaderText = "Minimum";
            this.minimum_value.MinimumWidth = 6;
            this.minimum_value.Name = "minimum_value";
            this.minimum_value.ReadOnly = true;
            // 
            // maximum_value
            // 
            this.maximum_value.DataPropertyName = "maximum_value";
            this.maximum_value.HeaderText = "Maximum";
            this.maximum_value.MinimumWidth = 6;
            this.maximum_value.Name = "maximum_value";
            this.maximum_value.ReadOnly = true;
            // 
            // cmnuCounters
            // 
            this.cmnuCounters.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnuCounters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCounterAdd,
            this.mnuCounterDetails,
            this.mnuCounterDelete,
            this.mnuNotificationRules,
            this.mnuCounterSeparator1,
            this.mnuCounterMoveUp,
            this.mnuCounterMoveDown,
            this.mnuCounterSeparator2,
            this.mnuCounterViewData,
            this.mnuCounterExportData});
            this.cmnuCounters.Name = "cmnuCounters";
            this.cmnuCounters.Size = new System.Drawing.Size(185, 192);
            // 
            // mnuCounterAdd
            // 
            this.mnuCounterAdd.Name = "mnuCounterAdd";
            this.mnuCounterAdd.Size = new System.Drawing.Size(184, 22);
            this.mnuCounterAdd.Text = "Add Counter";
            this.mnuCounterAdd.Click += new System.EventHandler(this.mnuCounterAdd_Click);
            // 
            // mnuCounterDetails
            // 
            this.mnuCounterDetails.Name = "mnuCounterDetails";
            this.mnuCounterDetails.Size = new System.Drawing.Size(184, 22);
            this.mnuCounterDetails.Text = "View Counter Details";
            this.mnuCounterDetails.Click += new System.EventHandler(this.mnuCounterDetails_Click);
            // 
            // mnuCounterDelete
            // 
            this.mnuCounterDelete.Name = "mnuCounterDelete";
            this.mnuCounterDelete.Size = new System.Drawing.Size(184, 22);
            this.mnuCounterDelete.Text = "Delete Counter";
            this.mnuCounterDelete.Click += new System.EventHandler(this.mnuCounterDelete_Click);
            // 
            // mnuNotificationRules
            // 
            this.mnuNotificationRules.Name = "mnuNotificationRules";
            this.mnuNotificationRules.Size = new System.Drawing.Size(184, 22);
            this.mnuNotificationRules.Text = "Notification Rules";
            this.mnuNotificationRules.Click += new System.EventHandler(this.mnuNotificationRules_Click);
            // 
            // mnuCounterSeparator1
            // 
            this.mnuCounterSeparator1.Name = "mnuCounterSeparator1";
            this.mnuCounterSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // mnuCounterMoveUp
            // 
            this.mnuCounterMoveUp.Name = "mnuCounterMoveUp";
            this.mnuCounterMoveUp.Size = new System.Drawing.Size(184, 22);
            this.mnuCounterMoveUp.Text = "Move Counter Up";
            // 
            // mnuCounterMoveDown
            // 
            this.mnuCounterMoveDown.Name = "mnuCounterMoveDown";
            this.mnuCounterMoveDown.Size = new System.Drawing.Size(184, 22);
            this.mnuCounterMoveDown.Text = "Move Counter Down";
            // 
            // mnuCounterSeparator2
            // 
            this.mnuCounterSeparator2.Name = "mnuCounterSeparator2";
            this.mnuCounterSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // mnuCounterViewData
            // 
            this.mnuCounterViewData.Name = "mnuCounterViewData";
            this.mnuCounterViewData.Size = new System.Drawing.Size(184, 22);
            this.mnuCounterViewData.Text = "View Counter Data";
            this.mnuCounterViewData.Click += new System.EventHandler(this.mnuCounterViewData_Click);
            // 
            // mnuCounterExportData
            // 
            this.mnuCounterExportData.Name = "mnuCounterExportData";
            this.mnuCounterExportData.Size = new System.Drawing.Size(184, 22);
            this.mnuCounterExportData.Text = "Export Counter Data";
            this.mnuCounterExportData.Click += new System.EventHandler(this.mnuCounterExportData_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1222, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printSetupToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // printSetupToolStripMenuItem
            // 
            this.printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
            this.printSetupToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printSetupToolStripMenuItem.Text = "Print Setup";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator6,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator7,
            this.selectAllToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(161, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(161, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "&View";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.toolBarToolStripMenuItem.Text = "&Toolbar";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(46, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(68, 20);
            this.windowsMenu.Text = "&Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.newWindowToolStripMenuItem.Text = "&New Window";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnJobStart,
            this.toolStripButton1,
            this.toolStripButton8,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton4,
            this.toolStripButton6,
            this.toolStripButton3,
            this.toolStripSeparator9,
            this.toolStripButton7,
            this.btnErrors,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.tsbActivate,
            this.btnJobLocation});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1222, 64);
            this.tsMain.TabIndex = 8;
            this.tsMain.Text = "toolStrip1";
            // 
            // btnJobStart
            // 
            this.btnJobStart.Image = ((System.Drawing.Image)(resources.GetObject("btnJobStart.Image")));
            this.btnJobStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJobStart.Name = "btnJobStart";
            this.btnJobStart.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnJobStart.Size = new System.Drawing.Size(68, 61);
            this.btnJobStart.Text = "Servers";
            this.btnJobStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnJobStart.Click += new System.EventHandler(this.btnJobStart_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::SmartMonitoring.Properties.Resources.servers_groups;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripButton1.Size = new System.Drawing.Size(109, 61);
            this.toolStripButton1.Text = "Servers Groups";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = global::SmartMonitoring.Properties.Resources.users;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripButton8.Size = new System.Drawing.Size(59, 61);
            this.toolStripButton8.Text = "Users";
            this.toolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 64);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripButton5.Size = new System.Drawing.Size(56, 61);
            this.toolStripButton5.Text = "Start";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripButton4.Size = new System.Drawing.Size(62, 61);
            this.toolStripButton4.Text = "Pause";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripButton6.Size = new System.Drawing.Size(59, 61);
            this.toolStripButton6.Text = "Reset";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripButton3.Size = new System.Drawing.Size(56, 61);
            this.toolStripButton3.Text = "Stop";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 64);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripButton7.Size = new System.Drawing.Size(67, 61);
            this.toolStripButton7.Text = "Layout";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnErrors
            // 
            this.btnErrors.Image = ((System.Drawing.Image)(resources.GetObject("btnErrors.Image")));
            this.btnErrors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnErrors.Name = "btnErrors";
            this.btnErrors.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnErrors.Size = new System.Drawing.Size(61, 61);
            this.btnErrors.Text = "Errors";
            this.btnErrors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnErrors.Click += new System.EventHandler(this.btnErrors_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 64);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripButton2.Size = new System.Drawing.Size(73, 61);
            this.toolStripButton2.Text = "Options";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbActivate
            // 
            this.tsbActivate.Image = ((System.Drawing.Image)(resources.GetObject("tsbActivate.Image")));
            this.tsbActivate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbActivate.Name = "tsbActivate";
            this.tsbActivate.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.tsbActivate.Size = new System.Drawing.Size(73, 61);
            this.tsbActivate.Text = "Options";
            this.tsbActivate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbActivate.Visible = false;
            this.tsbActivate.Click += new System.EventHandler(this.tsbActivate_Click);
            // 
            // btnJobLocation
            // 
            this.btnJobLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnJobLocation.Image")));
            this.btnJobLocation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJobLocation.Name = "btnJobLocation";
            this.btnJobLocation.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnJobLocation.Size = new System.Drawing.Size(56, 61);
            this.btnJobLocation.Text = "Help";
            this.btnJobLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tmrSelCounter
            // 
            this.tmrSelCounter.Interval = 1000;
            this.tmrSelCounter.Tick += new System.EventHandler(this.tmrSelCounter_Tick);
            // 
            // frmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 661);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnlCounters);
            this.Controls.Add(this.pnlMonitors);
            this.Controls.Add(this.pnlServers);
            this.MinimumSize = new System.Drawing.Size(1238, 699);
            this.Name = "frmMonitor";
            this.Text = "Monitoring Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMonitor_Load);
            this.Resize += new System.EventHandler(this.frmMonitor_Resize);
            this.pnlServers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvServers)).EndInit();
            this.cmnuServers.ResumeLayout(false);
            this.pnlMonitors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMonitors)).EndInit();
            this.pnlCounters.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCounters)).EndInit();
            this.cmnuCounters.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlServers;
        private System.Windows.Forms.DataGridView gvServers;
        private System.Windows.Forms.Panel pnlMonitors;
        private System.Windows.Forms.DataGridView gvMonitors;
        private System.Windows.Forms.Panel pnlCounters;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gvCounters;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSelCounterID;
        private System.Windows.Forms.TextBox txtSelMonitorID;
        private System.Windows.Forms.TextBox txtSelServerID;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton btnJobStart;
        private System.Windows.Forms.ToolStripButton btnErrors;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsbActivate;
        private System.Windows.Forms.ToolStripButton btnJobLocation;
        private System.Windows.Forms.TextBox txtSelServerName;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private LiveCharts.WinForms.AngularGauge Chart1;
        private System.Windows.Forms.Timer tmrSelCounter;
        private LiveCharts.WinForms.CartesianChart Chart2;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitor_image_id;
        private System.Windows.Forms.DataGridViewImageColumn monitor_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Server_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_image_id;
        private System.Windows.Forms.DataGridViewImageColumn server_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERVER_NAME;
        private System.Windows.Forms.ContextMenuStrip cmnuServers;
        private System.Windows.Forms.ToolStripMenuItem mnuServerAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuServerEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuServerDelete;
        private System.Windows.Forms.ContextMenuStrip cmnuCounters;
        private System.Windows.Forms.ToolStripMenuItem mnuCounterAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuNotificationRules;
        private System.Windows.Forms.ToolStripMenuItem mnuCounterDelete;
        private System.Windows.Forms.ToolStripSeparator mnuCounterSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuCounterMoveUp;
        private System.Windows.Forms.ToolStripMenuItem mnuCounterMoveDown;
        private System.Windows.Forms.ToolStripSeparator mnuCounterSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuCounterViewData;
        private System.Windows.Forms.ToolStripMenuItem mnuCounterExportData;
		private System.Windows.Forms.TextBox txtCounterValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn counter_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn counter_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn instance_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn instance_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn computer_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn current_value;
		private System.Windows.Forms.DataGridViewTextBoxColumn average_value;
		private System.Windows.Forms.DataGridViewTextBoxColumn minimum_value;
		private System.Windows.Forms.DataGridViewTextBoxColumn maximum_value;
		private System.Windows.Forms.ToolStripMenuItem mnuServerDuplicate;
		private System.Windows.Forms.Label lblChart1Value;
        private System.Windows.Forms.ToolStripMenuItem mnuCounterDetails;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}