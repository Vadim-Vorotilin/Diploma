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
            this.components = new System.ComponentModel.Container();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Depots = new System.Windows.Forms.TabPage();
            this.dataGridView_Depots = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vOLUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOORDINATESNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOORDINATESEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPOTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vRPAccountingDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vRP_Accounting_DB_DataSet = new Diploma.VRP_Accounting_DB_DataSet();
            this.tabPage_Consumers = new System.Windows.Forms.TabPage();
            this.dataGridView_Consumers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage_Vehicles = new System.Windows.Forms.TabPage();
            this.dataGridView_Vehicles = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUMPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEHICLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solveTheProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Depots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Depots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPOTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRPAccountingDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRP_Accounting_DB_DataSet)).BeginInit();
            this.tabPage_Consumers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consumers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMERBindingSource)).BeginInit();
            this.tabPage_Vehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).BeginInit();
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
            this.dataGridView_Depots.AutoGenerateColumns = false;
            this.dataGridView_Depots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Depots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn,
            this.vOLUMEDataGridViewTextBoxColumn,
            this.cOORDINATESNDataGridViewTextBoxColumn,
            this.cOORDINATESEDataGridViewTextBoxColumn});
            this.dataGridView_Depots.DataSource = this.dEPOTBindingSource;
            this.dataGridView_Depots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Depots.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Depots.Name = "dataGridView_Depots";
            this.dataGridView_Depots.Size = new System.Drawing.Size(724, 350);
            this.dataGridView_Depots.TabIndex = 0;
            this.dataGridView_Depots.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Depots_CellEndEdit);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 250;
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            this.aMOUNTDataGridViewTextBoxColumn.Width = 70;
            // 
            // vOLUMEDataGridViewTextBoxColumn
            // 
            this.vOLUMEDataGridViewTextBoxColumn.DataPropertyName = "VOLUME";
            this.vOLUMEDataGridViewTextBoxColumn.HeaderText = "VOLUME";
            this.vOLUMEDataGridViewTextBoxColumn.Name = "vOLUMEDataGridViewTextBoxColumn";
            this.vOLUMEDataGridViewTextBoxColumn.Width = 70;
            // 
            // cOORDINATESNDataGridViewTextBoxColumn
            // 
            this.cOORDINATESNDataGridViewTextBoxColumn.DataPropertyName = "COORDINATES_N";
            this.cOORDINATESNDataGridViewTextBoxColumn.HeaderText = "COORDINATES_N";
            this.cOORDINATESNDataGridViewTextBoxColumn.Name = "cOORDINATESNDataGridViewTextBoxColumn";
            this.cOORDINATESNDataGridViewTextBoxColumn.Width = 120;
            // 
            // cOORDINATESEDataGridViewTextBoxColumn
            // 
            this.cOORDINATESEDataGridViewTextBoxColumn.DataPropertyName = "COORDINATES_E";
            this.cOORDINATESEDataGridViewTextBoxColumn.HeaderText = "COORDINATES_E";
            this.cOORDINATESEDataGridViewTextBoxColumn.Name = "cOORDINATESEDataGridViewTextBoxColumn";
            this.cOORDINATESEDataGridViewTextBoxColumn.Width = 120;
            // 
            // dEPOTBindingSource
            // 
            this.dEPOTBindingSource.DataMember = "DEPOT";
            this.dEPOTBindingSource.DataSource = this.vRPAccountingDBDataSetBindingSource;
            // 
            // vRPAccountingDBDataSetBindingSource
            // 
            this.vRPAccountingDBDataSetBindingSource.DataSource = this.vRP_Accounting_DB_DataSet;
            this.vRPAccountingDBDataSetBindingSource.Position = 0;
            // 
            // vRP_Accounting_DB_DataSet
            // 
            this.vRP_Accounting_DB_DataSet.DataSetName = "VRP_Accounting_DB_DataSet";
            this.vRP_Accounting_DB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dataGridView_Consumers.AutoGenerateColumns = false;
            this.dataGridView_Consumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Consumers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView_Consumers.DataSource = this.cONSUMERBindingSource;
            this.dataGridView_Consumers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Consumers.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Consumers.Name = "dataGridView_Consumers";
            this.dataGridView_Consumers.Size = new System.Drawing.Size(724, 350);
            this.dataGridView_Consumers.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AMOUNT";
            this.dataGridViewTextBoxColumn3.HeaderText = "AMOUNT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "COORDINATES_N";
            this.dataGridViewTextBoxColumn5.HeaderText = "COORDINATES_N";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "COORDINATES_E";
            this.dataGridViewTextBoxColumn6.HeaderText = "COORDINATES_E";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // cONSUMERBindingSource
            // 
            this.cONSUMERBindingSource.DataMember = "CONSUMER";
            this.cONSUMERBindingSource.DataSource = this.vRPAccountingDBDataSetBindingSource;
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
            this.dataGridView_Vehicles.AutoGenerateColumns = false;
            this.dataGridView_Vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Vehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nAMEDataGridViewTextBoxColumn1,
            this.cONSUMPTIONDataGridViewTextBoxColumn,
            this.cOUNTDataGridViewTextBoxColumn});
            this.dataGridView_Vehicles.DataSource = this.vEHICLEBindingSource;
            this.dataGridView_Vehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Vehicles.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Vehicles.Name = "dataGridView_Vehicles";
            this.dataGridView_Vehicles.Size = new System.Drawing.Size(724, 350);
            this.dataGridView_Vehicles.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            this.iDDataGridViewTextBoxColumn1.Width = 50;
            // 
            // nAMEDataGridViewTextBoxColumn1
            // 
            this.nAMEDataGridViewTextBoxColumn1.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn1.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn1.Name = "nAMEDataGridViewTextBoxColumn1";
            this.nAMEDataGridViewTextBoxColumn1.Width = 250;
            // 
            // cONSUMPTIONDataGridViewTextBoxColumn
            // 
            this.cONSUMPTIONDataGridViewTextBoxColumn.DataPropertyName = "CONSUMPTION";
            this.cONSUMPTIONDataGridViewTextBoxColumn.HeaderText = "CONSUMPTION";
            this.cONSUMPTIONDataGridViewTextBoxColumn.Name = "cONSUMPTIONDataGridViewTextBoxColumn";
            // 
            // cOUNTDataGridViewTextBoxColumn
            // 
            this.cOUNTDataGridViewTextBoxColumn.DataPropertyName = "COUNT";
            this.cOUNTDataGridViewTextBoxColumn.HeaderText = "COUNT";
            this.cOUNTDataGridViewTextBoxColumn.Name = "cOUNTDataGridViewTextBoxColumn";
            // 
            // vEHICLEBindingSource
            // 
            this.vEHICLEBindingSource.DataMember = "VEHICLE";
            this.vEHICLEBindingSource.DataSource = this.vRPAccountingDBDataSetBindingSource;
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
            this.Load += new System.EventHandler(this.DBForm_Load);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Depots.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Depots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPOTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRPAccountingDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRP_Accounting_DB_DataSet)).EndInit();
            this.tabPage_Consumers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consumers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMERBindingSource)).EndInit();
            this.tabPage_Vehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource vRPAccountingDBDataSetBindingSource;
        private VRP_Accounting_DB_DataSet vRP_Accounting_DB_DataSet;
        private System.Windows.Forms.BindingSource dEPOTBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_Consumers;
        private System.Windows.Forms.BindingSource cONSUMERBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_Vehicles;
        private System.Windows.Forms.BindingSource vEHICLEBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOLUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOORDINATESNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOORDINATESEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUMPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToXMDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solveTheProblemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}