namespace Diploma
{
    partial class DBForm
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
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Depots = new System.Windows.Forms.TabPage();
            this.dataGridView_Depots = new System.Windows.Forms.DataGridView();
            this.tabPage_Consumers = new System.Windows.Forms.TabPage();
            this.dataGridView_Consumers = new System.Windows.Forms.DataGridView();
            this.tabPage_Vehicles = new System.Windows.Forms.TabPage();
            this.dataGridView_Vehicles = new System.Windows.Forms.DataGridView();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solveTheProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Depots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Depots)).BeginInit();
            this.tabPage_Consumers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consumers)).BeginInit();
            this.tabPage_Vehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vehicles)).BeginInit();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Depots);
            this.tabControl_Main.Controls.Add(this.tabPage_Consumers);
            this.tabControl_Main.Controls.Add(this.tabPage_Vehicles);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 24);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.Padding = new System.Drawing.Point(30, 7);
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(738, 390);
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_Depots
            // 
            this.tabPage_Depots.Controls.Add(this.dataGridView_Depots);
            this.tabPage_Depots.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Depots.Name = "tabPage_Depots";
            this.tabPage_Depots.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Depots.Size = new System.Drawing.Size(730, 356);
            this.tabPage_Depots.TabIndex = 0;
            this.tabPage_Depots.Text = "Depots";
            this.tabPage_Depots.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Depots
            // 
            this.dataGridView_Depots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Depots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Depots.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Depots.Name = "dataGridView_Depots";
            this.dataGridView_Depots.Size = new System.Drawing.Size(724, 350);
            this.dataGridView_Depots.TabIndex = 0;
            this.dataGridView_Depots.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Depots_CellEndEdit);
            // 
            // tabPage_Consumers
            // 
            this.tabPage_Consumers.Controls.Add(this.dataGridView_Consumers);
            this.tabPage_Consumers.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Consumers.Name = "tabPage_Consumers";
            this.tabPage_Consumers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Consumers.Size = new System.Drawing.Size(730, 356);
            this.tabPage_Consumers.TabIndex = 1;
            this.tabPage_Consumers.Text = "Consumers";
            this.tabPage_Consumers.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Consumers
            // 
            this.dataGridView_Consumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Consumers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Consumers.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Consumers.Name = "dataGridView_Consumers";
            this.dataGridView_Consumers.Size = new System.Drawing.Size(724, 350);
            this.dataGridView_Consumers.TabIndex = 1;
            // 
            // tabPage_Vehicles
            // 
            this.tabPage_Vehicles.Controls.Add(this.dataGridView_Vehicles);
            this.tabPage_Vehicles.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Vehicles.Name = "tabPage_Vehicles";
            this.tabPage_Vehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Vehicles.Size = new System.Drawing.Size(730, 356);
            this.tabPage_Vehicles.TabIndex = 2;
            this.tabPage_Vehicles.Text = "Vehicles";
            this.tabPage_Vehicles.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Vehicles
            // 
            this.dataGridView_Vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Vehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Vehicles.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Vehicles.Name = "dataGridView_Vehicles";
            this.dataGridView_Vehicles.Size = new System.Drawing.Size(724, 350);
            this.dataGridView_Vehicles.TabIndex = 1;
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(738, 24);
            this.menuStrip_Main.TabIndex = 1;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToXMDLToolStripMenuItem,
            this.solveTheProblemToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToXMDLToolStripMenuItem
            // 
            this.exportToXMDLToolStripMenuItem.Name = "exportToXMDLToolStripMenuItem";
            this.exportToXMDLToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exportToXMDLToolStripMenuItem.Text = "Export to XMDL ...";
            this.exportToXMDLToolStripMenuItem.Click += new System.EventHandler(this.exportToXMDLToolStripMenuItem_Click);
            // 
            // solveTheProblemToolStripMenuItem
            // 
            this.solveTheProblemToolStripMenuItem.Name = "solveTheProblemToolStripMenuItem";
            this.solveTheProblemToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.solveTheProblemToolStripMenuItem.Text = "Solve the problem ...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 414);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "DBForm";
            this.Text = "Accounting";
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Depots.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Depots)).EndInit();
            this.tabPage_Consumers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consumers)).EndInit();
            this.tabPage_Vehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vehicles)).EndInit();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Depots;
        private System.Windows.Forms.TabPage tabPage_Consumers;
        private System.Windows.Forms.TabPage tabPage_Vehicles;
        private System.Windows.Forms.DataGridView dataGridView_Depots;
        private System.Windows.Forms.DataGridView dataGridView_Consumers;
        private System.Windows.Forms.DataGridView dataGridView_Vehicles;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToXMDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solveTheProblemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}