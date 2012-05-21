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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForm));
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Drawing = new System.Windows.Forms.Panel();
            this.listBox_Statuses = new System.Windows.Forms.ListBox();
            this.groupBox_Algorithm = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_Algorithm = new System.Windows.Forms.FlowLayoutPanel();
            this.label_ClustersCount = new System.Windows.Forms.Label();
            this.numericUpDown_ClustersCount = new System.Windows.Forms.NumericUpDown();
            this.checkBox_VehiclesCountUnlimited = new System.Windows.Forms.CheckBox();
            this.label_ClusterCapacityLimit = new System.Windows.Forms.Label();
            this.numericUpDown_ClusterCapacityLimit = new System.Windows.Forms.NumericUpDown();
            this.checkBox_CapacityUnlimited = new System.Windows.Forms.CheckBox();
            this.label_KilometerCost = new System.Windows.Forms.Label();
            this.numericUpDown_KilometerCost = new System.Windows.Forms.NumericUpDown();
            this.button_StartAlgorithm = new System.Windows.Forms.Button();
            this.menuStrip_MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Main = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.groupBox_Algorithm.SuspendLayout();
            this.flowLayoutPanel_Algorithm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClustersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClusterCapacityLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_KilometerCost)).BeginInit();
            this.menuStrip_MainMenu.SuspendLayout();
            this.statusStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            resources.ApplyResources(this.tableLayoutPanel_Main, "tableLayoutPanel_Main");
            this.tableLayoutPanel_Main.Controls.Add(this.panel_Drawing, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.listBox_Statuses, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.groupBox_Algorithm, 1, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            // 
            // panel_Drawing
            // 
            resources.ApplyResources(this.panel_Drawing, "panel_Drawing");
            this.panel_Drawing.BackColor = System.Drawing.Color.White;
            this.panel_Drawing.Name = "panel_Drawing";
            this.panel_Drawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Drawing_MouseClick);
            // 
            // listBox_Statuses
            // 
            resources.ApplyResources(this.listBox_Statuses, "listBox_Statuses");
            this.listBox_Statuses.FormattingEnabled = true;
            this.listBox_Statuses.Name = "listBox_Statuses";
            this.listBox_Statuses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox_Statuses_MouseClick);
            this.listBox_Statuses.SelectedIndexChanged += new System.EventHandler(this.listBox_Statuses_SelectedIndexChanged);
            // 
            // groupBox_Algorithm
            // 
            resources.ApplyResources(this.groupBox_Algorithm, "groupBox_Algorithm");
            this.groupBox_Algorithm.Controls.Add(this.flowLayoutPanel_Algorithm);
            this.groupBox_Algorithm.Name = "groupBox_Algorithm";
            this.groupBox_Algorithm.TabStop = false;
            // 
            // flowLayoutPanel_Algorithm
            // 
            resources.ApplyResources(this.flowLayoutPanel_Algorithm, "flowLayoutPanel_Algorithm");
            this.flowLayoutPanel_Algorithm.Controls.Add(this.label_ClustersCount);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.numericUpDown_ClustersCount);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.checkBox_VehiclesCountUnlimited);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.label_ClusterCapacityLimit);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.numericUpDown_ClusterCapacityLimit);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.checkBox_CapacityUnlimited);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.label_KilometerCost);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.numericUpDown_KilometerCost);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.button_StartAlgorithm);
            this.flowLayoutPanel_Algorithm.Name = "flowLayoutPanel_Algorithm";
            // 
            // label_ClustersCount
            // 
            resources.ApplyResources(this.label_ClustersCount, "label_ClustersCount");
            this.label_ClustersCount.Name = "label_ClustersCount";
            // 
            // numericUpDown_ClustersCount
            // 
            resources.ApplyResources(this.numericUpDown_ClustersCount, "numericUpDown_ClustersCount");
            this.numericUpDown_ClustersCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ClustersCount.Name = "numericUpDown_ClustersCount";
            this.numericUpDown_ClustersCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // checkBox_VehiclesCountUnlimited
            // 
            resources.ApplyResources(this.checkBox_VehiclesCountUnlimited, "checkBox_VehiclesCountUnlimited");
            this.checkBox_VehiclesCountUnlimited.Name = "checkBox_VehiclesCountUnlimited";
            this.checkBox_VehiclesCountUnlimited.UseVisualStyleBackColor = true;
            this.checkBox_VehiclesCountUnlimited.CheckedChanged += new System.EventHandler(this.checkBox_VehiclesCountUnlimited_CheckedChanged);
            // 
            // label_ClusterCapacityLimit
            // 
            resources.ApplyResources(this.label_ClusterCapacityLimit, "label_ClusterCapacityLimit");
            this.label_ClusterCapacityLimit.Name = "label_ClusterCapacityLimit";
            // 
            // numericUpDown_ClusterCapacityLimit
            // 
            resources.ApplyResources(this.numericUpDown_ClusterCapacityLimit, "numericUpDown_ClusterCapacityLimit");
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
            this.numericUpDown_ClusterCapacityLimit.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // checkBox_CapacityUnlimited
            // 
            resources.ApplyResources(this.checkBox_CapacityUnlimited, "checkBox_CapacityUnlimited");
            this.checkBox_CapacityUnlimited.Name = "checkBox_CapacityUnlimited";
            this.checkBox_CapacityUnlimited.UseVisualStyleBackColor = true;
            this.checkBox_CapacityUnlimited.CheckedChanged += new System.EventHandler(this.checkBox_CapacityLimit_CheckedChanged);
            // 
            // label_KilometerCost
            // 
            resources.ApplyResources(this.label_KilometerCost, "label_KilometerCost");
            this.label_KilometerCost.Name = "label_KilometerCost";
            // 
            // numericUpDown_KilometerCost
            // 
            resources.ApplyResources(this.numericUpDown_KilometerCost, "numericUpDown_KilometerCost");
            this.numericUpDown_KilometerCost.DecimalPlaces = 3;
            this.numericUpDown_KilometerCost.Name = "numericUpDown_KilometerCost";
            this.numericUpDown_KilometerCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_StartAlgorithm
            // 
            resources.ApplyResources(this.button_StartAlgorithm, "button_StartAlgorithm");
            this.button_StartAlgorithm.Name = "button_StartAlgorithm";
            this.button_StartAlgorithm.UseVisualStyleBackColor = true;
            this.button_StartAlgorithm.Click += new System.EventHandler(this.button_StartAlgorithm_Click);
            // 
            // menuStrip_MainMenu
            // 
            resources.ApplyResources(this.menuStrip_MainMenu, "menuStrip_MainMenu");
            this.menuStrip_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip_MainMenu.Name = "menuStrip_MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadModelToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // loadModelToolStripMenuItem
            // 
            resources.ApplyResources(this.loadModelToolStripMenuItem, "loadModelToolStripMenuItem");
            this.loadModelToolStripMenuItem.Name = "loadModelToolStripMenuItem";
            this.loadModelToolStripMenuItem.Click += new System.EventHandler(this.loadModelToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            resources.ApplyResources(this.reportToolStripMenuItem, "reportToolStripMenuItem");
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            // 
            // generateReportToolStripMenuItem
            // 
            resources.ApplyResources(this.generateReportToolStripMenuItem, "generateReportToolStripMenuItem");
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.Click += new System.EventHandler(this.generateReportToolStripMenuItem_Click);
            // 
            // statusStrip_Main
            // 
            resources.ApplyResources(this.statusStrip_Main, "statusStrip_Main");
            this.statusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Main});
            this.statusStrip_Main.Name = "statusStrip_Main";
            // 
            // toolStripStatusLabel_Main
            // 
            resources.ApplyResources(this.toolStripStatusLabel_Main, "toolStripStatusLabel_Main");
            this.toolStripStatusLabel_Main.Name = "toolStripStatusLabel_Main";
            // 
            // GraphForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip_Main);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Controls.Add(this.menuStrip_MainMenu);
            this.Name = "GraphForm";
            this.Load += new System.EventHandler(this.GraphForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GraphForm_MouseClick);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.groupBox_Algorithm.ResumeLayout(false);
            this.flowLayoutPanel_Algorithm.ResumeLayout(false);
            this.flowLayoutPanel_Algorithm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClustersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClusterCapacityLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_KilometerCost)).EndInit();
            this.menuStrip_MainMenu.ResumeLayout(false);
            this.menuStrip_MainMenu.PerformLayout();
            this.statusStrip_Main.ResumeLayout(false);
            this.statusStrip_Main.PerformLayout();
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

