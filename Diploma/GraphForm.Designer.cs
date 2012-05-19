namespace Diploma
{
    partial class GraphForm
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
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Drawing = new System.Windows.Forms.Panel();
            this.listBox_Statuses = new System.Windows.Forms.ListBox();
            this.menuStrip_MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Main = new System.Windows.Forms.ToolStripStatusLabel();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel_Algorithm = new System.Windows.Forms.FlowLayoutPanel();
            this.button_StartAlgorithm = new System.Windows.Forms.Button();
            this.numericUpDown_KilometerCost = new System.Windows.Forms.NumericUpDown();
            this.label_KilometerCost = new System.Windows.Forms.Label();
            this.checkBox_CapacityUnlimited = new System.Windows.Forms.CheckBox();
            this.numericUpDown_ClusterCapacityLimit = new System.Windows.Forms.NumericUpDown();
            this.label_ClusterCapacityLimit = new System.Windows.Forms.Label();
            this.checkBox_VehiclesCountUnlimited = new System.Windows.Forms.CheckBox();
            this.numericUpDown_ClustersCount = new System.Windows.Forms.NumericUpDown();
            this.label_ClustersCount = new System.Windows.Forms.Label();
            this.groupBox_Algorithm = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.menuStrip_MainMenu.SuspendLayout();
            this.statusStrip_Main.SuspendLayout();
            this.flowLayoutPanel_Algorithm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_KilometerCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClusterCapacityLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClustersCount)).BeginInit();
            this.groupBox_Algorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 2;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel_Main.Controls.Add(this.panel_Drawing, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.listBox_Statuses, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.groupBox_Algorithm, 1, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 3;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1006, 640);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // panel_Drawing
            // 
            this.panel_Drawing.BackColor = System.Drawing.Color.White;
            this.panel_Drawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Drawing.Location = new System.Drawing.Point(3, 3);
            this.panel_Drawing.Name = "panel_Drawing";
            this.panel_Drawing.Size = new System.Drawing.Size(840, 480);
            this.panel_Drawing.TabIndex = 1;
            this.panel_Drawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Drawing_MouseClick);
            // 
            // listBox_Statuses
            // 
            this.listBox_Statuses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Statuses.FormattingEnabled = true;
            this.listBox_Statuses.Location = new System.Drawing.Point(3, 489);
            this.listBox_Statuses.Name = "listBox_Statuses";
            this.listBox_Statuses.Size = new System.Drawing.Size(840, 124);
            this.listBox_Statuses.TabIndex = 3;
            this.listBox_Statuses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox_Statuses_MouseClick);
            this.listBox_Statuses.SelectedIndexChanged += new System.EventHandler(this.listBox_Statuses_SelectedIndexChanged);
            // 
            // menuStrip_MainMenu
            // 
            this.menuStrip_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MainMenu.Name = "menuStrip_MainMenu";
            this.menuStrip_MainMenu.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip_MainMenu.TabIndex = 1;
            this.menuStrip_MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadModelToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadModelToolStripMenuItem
            // 
            this.loadModelToolStripMenuItem.Name = "loadModelToolStripMenuItem";
            this.loadModelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadModelToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.loadModelToolStripMenuItem.Text = "Load data...";
            this.loadModelToolStripMenuItem.Click += new System.EventHandler(this.loadModelToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Main});
            this.statusStrip_Main.Location = new System.Drawing.Point(0, 642);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(1006, 22);
            this.statusStrip_Main.TabIndex = 2;
            this.statusStrip_Main.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Main
            // 
            this.toolStripStatusLabel_Main.Name = "toolStripStatusLabel_Main";
            this.toolStripStatusLabel_Main.Size = new System.Drawing.Size(0, 17);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // generateReportToolStripMenuItem
            // 
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.generateReportToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.generateReportToolStripMenuItem.Text = "Generate report ...";
            this.generateReportToolStripMenuItem.Click += new System.EventHandler(this.generateReportToolStripMenuItem_Click);
            // 
            // flowLayoutPanel_Algorithm
            // 
            this.flowLayoutPanel_Algorithm.Controls.Add(this.label_ClustersCount);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.numericUpDown_ClustersCount);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.checkBox_VehiclesCountUnlimited);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.label_ClusterCapacityLimit);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.numericUpDown_ClusterCapacityLimit);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.checkBox_CapacityUnlimited);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.label_KilometerCost);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.numericUpDown_KilometerCost);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.button_StartAlgorithm);
            this.flowLayoutPanel_Algorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Algorithm.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Algorithm.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel_Algorithm.Name = "flowLayoutPanel_Algorithm";
            this.flowLayoutPanel_Algorithm.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowLayoutPanel_Algorithm.Size = new System.Drawing.Size(148, 201);
            this.flowLayoutPanel_Algorithm.TabIndex = 8;
            // 
            // button_StartAlgorithm
            // 
            this.button_StartAlgorithm.Location = new System.Drawing.Point(3, 171);
            this.button_StartAlgorithm.Name = "button_StartAlgorithm";
            this.button_StartAlgorithm.Size = new System.Drawing.Size(140, 23);
            this.button_StartAlgorithm.TabIndex = 3;
            this.button_StartAlgorithm.Text = "Start";
            this.button_StartAlgorithm.UseVisualStyleBackColor = true;
            this.button_StartAlgorithm.Click += new System.EventHandler(this.button_StartAlgorithm_Click);
            // 
            // numericUpDown_KilometerCost
            // 
            this.numericUpDown_KilometerCost.DecimalPlaces = 3;
            this.numericUpDown_KilometerCost.Location = new System.Drawing.Point(3, 145);
            this.numericUpDown_KilometerCost.Name = "numericUpDown_KilometerCost";
            this.numericUpDown_KilometerCost.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_KilometerCost.TabIndex = 16;
            this.numericUpDown_KilometerCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_KilometerCost
            // 
            this.label_KilometerCost.AutoSize = true;
            this.label_KilometerCost.Location = new System.Drawing.Point(3, 129);
            this.label_KilometerCost.Name = "label_KilometerCost";
            this.label_KilometerCost.Size = new System.Drawing.Size(73, 13);
            this.label_KilometerCost.TabIndex = 15;
            this.label_KilometerCost.Text = "Kilometer cost";
            // 
            // checkBox_CapacityUnlimited
            // 
            this.checkBox_CapacityUnlimited.AutoSize = true;
            this.checkBox_CapacityUnlimited.Location = new System.Drawing.Point(3, 109);
            this.checkBox_CapacityUnlimited.Name = "checkBox_CapacityUnlimited";
            this.checkBox_CapacityUnlimited.Size = new System.Drawing.Size(111, 17);
            this.checkBox_CapacityUnlimited.TabIndex = 18;
            this.checkBox_CapacityUnlimited.Text = "Capacity unlimited";
            this.checkBox_CapacityUnlimited.UseVisualStyleBackColor = true;
            this.checkBox_CapacityUnlimited.CheckedChanged += new System.EventHandler(this.checkBox_CapacityLimit_CheckedChanged);
            // 
            // numericUpDown_ClusterCapacityLimit
            // 
            this.numericUpDown_ClusterCapacityLimit.Location = new System.Drawing.Point(3, 83);
            this.numericUpDown_ClusterCapacityLimit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_ClusterCapacityLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ClusterCapacityLimit.Name = "numericUpDown_ClusterCapacityLimit";
            this.numericUpDown_ClusterCapacityLimit.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_ClusterCapacityLimit.TabIndex = 11;
            this.numericUpDown_ClusterCapacityLimit.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label_ClusterCapacityLimit
            // 
            this.label_ClusterCapacityLimit.AutoSize = true;
            this.label_ClusterCapacityLimit.Location = new System.Drawing.Point(3, 67);
            this.label_ClusterCapacityLimit.Name = "label_ClusterCapacityLimit";
            this.label_ClusterCapacityLimit.Size = new System.Drawing.Size(48, 13);
            this.label_ClusterCapacityLimit.TabIndex = 12;
            this.label_ClusterCapacityLimit.Text = "Capacity";
            // 
            // checkBox_VehiclesCountUnlimited
            // 
            this.checkBox_VehiclesCountUnlimited.AutoSize = true;
            this.checkBox_VehiclesCountUnlimited.Location = new System.Drawing.Point(3, 47);
            this.checkBox_VehiclesCountUnlimited.Name = "checkBox_VehiclesCountUnlimited";
            this.checkBox_VehiclesCountUnlimited.Size = new System.Drawing.Size(140, 17);
            this.checkBox_VehiclesCountUnlimited.TabIndex = 17;
            this.checkBox_VehiclesCountUnlimited.Text = "Vehicles count unlimited";
            this.checkBox_VehiclesCountUnlimited.UseVisualStyleBackColor = true;
            this.checkBox_VehiclesCountUnlimited.CheckedChanged += new System.EventHandler(this.checkBox_VehiclesCountUnlimited_CheckedChanged);
            // 
            // numericUpDown_ClustersCount
            // 
            this.numericUpDown_ClustersCount.Location = new System.Drawing.Point(3, 21);
            this.numericUpDown_ClustersCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ClustersCount.Name = "numericUpDown_ClustersCount";
            this.numericUpDown_ClustersCount.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_ClustersCount.TabIndex = 9;
            this.numericUpDown_ClustersCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label_ClustersCount
            // 
            this.label_ClustersCount.AutoSize = true;
            this.label_ClustersCount.Location = new System.Drawing.Point(3, 5);
            this.label_ClustersCount.Name = "label_ClustersCount";
            this.label_ClustersCount.Size = new System.Drawing.Size(77, 13);
            this.label_ClustersCount.TabIndex = 8;
            this.label_ClustersCount.Text = "Vehicles count";
            // 
            // groupBox_Algorithm
            // 
            this.groupBox_Algorithm.Controls.Add(this.flowLayoutPanel_Algorithm);
            this.groupBox_Algorithm.Location = new System.Drawing.Point(849, 3);
            this.groupBox_Algorithm.Name = "groupBox_Algorithm";
            this.groupBox_Algorithm.Size = new System.Drawing.Size(154, 220);
            this.groupBox_Algorithm.TabIndex = 7;
            this.groupBox_Algorithm.TabStop = false;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 664);
            this.Controls.Add(this.statusStrip_Main);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Controls.Add(this.menuStrip_MainMenu);
            this.Name = "GraphForm";
            this.Text = "Math";
            this.Load += new System.EventHandler(this.GraphForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GraphForm_MouseClick);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.menuStrip_MainMenu.ResumeLayout(false);
            this.menuStrip_MainMenu.PerformLayout();
            this.statusStrip_Main.ResumeLayout(false);
            this.statusStrip_Main.PerformLayout();
            this.flowLayoutPanel_Algorithm.ResumeLayout(false);
            this.flowLayoutPanel_Algorithm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_KilometerCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClusterCapacityLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClustersCount)).EndInit();
            this.groupBox_Algorithm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.Panel panel_Drawing;
        private System.Windows.Forms.MenuStrip menuStrip_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Main;
        private System.Windows.Forms.ListBox listBox_Statuses;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_Algorithm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Algorithm;
        private System.Windows.Forms.Label label_ClustersCount;
        private System.Windows.Forms.NumericUpDown numericUpDown_ClustersCount;
        private System.Windows.Forms.CheckBox checkBox_VehiclesCountUnlimited;
        private System.Windows.Forms.Label label_ClusterCapacityLimit;
        private System.Windows.Forms.NumericUpDown numericUpDown_ClusterCapacityLimit;
        private System.Windows.Forms.CheckBox checkBox_CapacityUnlimited;
        private System.Windows.Forms.Label label_KilometerCost;
        private System.Windows.Forms.NumericUpDown numericUpDown_KilometerCost;
        private System.Windows.Forms.Button button_StartAlgorithm;

    }
}

