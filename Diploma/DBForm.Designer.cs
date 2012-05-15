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
            this.vRP_Accounting_DB_DataSet = new Diploma.VRP_Accounting_DB_DataSet();
            this.tabPage_Consumers = new System.Windows.Forms.TabPage();
            this.dataGridView_Consumers = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COORDINATES_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COORDINATES_E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage_Vehicles = new System.Windows.Forms.TabPage();
            this.dataGridView_Vehicles = new System.Windows.Forms.DataGridView();
            this.vEHICLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage_DistanceConsumers = new System.Windows.Forms.TabPage();
            this.dataGridView_DistanceConsumers = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCONSUMERFROMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDCONSUMERTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dISTANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISTANCECONSUMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage_DistanceDepotConsumer = new System.Windows.Forms.TabPage();
            this.dataGridView_DistanceDepotConsumer = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDEPOTFROMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDCONSUMERTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dISTANCEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISTANCEDEPOTCONSUMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solveTheProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEPOTTableAdapter = new Diploma.VRP_Accounting_DB_DataSetTableAdapters.DEPOTTableAdapter();
            this.cONSUMERTableAdapter = new Diploma.VRP_Accounting_DB_DataSetTableAdapters.CONSUMERTableAdapter();
            this.vEHICLETableAdapter = new Diploma.VRP_Accounting_DB_DataSetTableAdapters.VEHICLETableAdapter();
            this.dISTANCE_CONSUMERSTableAdapter = new Diploma.VRP_Accounting_DB_DataSetTableAdapters.DISTANCE_CONSUMERSTableAdapter();
            this.dISTANCE_DEPOT_CONSUMERTableAdapter = new Diploma.VRP_Accounting_DB_DataSetTableAdapters.DISTANCE_DEPOT_CONSUMERTableAdapter();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUMPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOLUME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Depots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Depots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPOTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRP_Accounting_DB_DataSet)).BeginInit();
            this.tabPage_Consumers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consumers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMERBindingSource)).BeginInit();
            this.tabPage_Vehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).BeginInit();
            this.tabPage_DistanceConsumers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DistanceConsumers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISTANCECONSUMERSBindingSource)).BeginInit();
            this.tabPage_DistanceDepotConsumer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DistanceDepotConsumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISTANCEDEPOTCONSUMERBindingSource)).BeginInit();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Depots);
            this.tabControl_Main.Controls.Add(this.tabPage_Consumers);
            this.tabControl_Main.Controls.Add(this.tabPage_Vehicles);
            this.tabControl_Main.Controls.Add(this.tabPage_DistanceConsumers);
            this.tabControl_Main.Controls.Add(this.tabPage_DistanceDepotConsumer);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 24);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.Padding = new System.Drawing.Point(30, 7);
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(737, 390);
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_Depots
            // 
            this.tabPage_Depots.Controls.Add(this.dataGridView_Depots);
            this.tabPage_Depots.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Depots.Name = "tabPage_Depots";
            this.tabPage_Depots.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Depots.Size = new System.Drawing.Size(729, 356);
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
            this.dataGridView_Depots.Size = new System.Drawing.Size(723, 350);
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
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 250;
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            this.aMOUNTDataGridViewTextBoxColumn.Width = 70;
            // 
            // vOLUMEDataGridViewTextBoxColumn
            // 
            this.vOLUMEDataGridViewTextBoxColumn.DataPropertyName = "VOLUME";
            this.vOLUMEDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.vOLUMEDataGridViewTextBoxColumn.Name = "vOLUMEDataGridViewTextBoxColumn";
            this.vOLUMEDataGridViewTextBoxColumn.Width = 70;
            // 
            // cOORDINATESNDataGridViewTextBoxColumn
            // 
            this.cOORDINATESNDataGridViewTextBoxColumn.DataPropertyName = "COORDINATES_N";
            this.cOORDINATESNDataGridViewTextBoxColumn.HeaderText = "Coordinates N";
            this.cOORDINATESNDataGridViewTextBoxColumn.Name = "cOORDINATESNDataGridViewTextBoxColumn";
            this.cOORDINATESNDataGridViewTextBoxColumn.Width = 120;
            // 
            // cOORDINATESEDataGridViewTextBoxColumn
            // 
            this.cOORDINATESEDataGridViewTextBoxColumn.DataPropertyName = "COORDINATES_E";
            this.cOORDINATESEDataGridViewTextBoxColumn.HeaderText = "Coordinates E";
            this.cOORDINATESEDataGridViewTextBoxColumn.Name = "cOORDINATESEDataGridViewTextBoxColumn";
            this.cOORDINATESEDataGridViewTextBoxColumn.Width = 120;
            // 
            // dEPOTBindingSource
            // 
            this.dEPOTBindingSource.DataMember = "DEPOT";
            this.dEPOTBindingSource.DataSource = this.vRP_Accounting_DB_DataSet;
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
            this.tabPage_Consumers.Size = new System.Drawing.Size(729, 356);
            this.tabPage_Consumers.TabIndex = 1;
            this.tabPage_Consumers.Text = "Consumers";
            this.tabPage_Consumers.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Consumers
            // 
            this.dataGridView_Consumers.AutoGenerateColumns = false;
            this.dataGridView_Consumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Consumers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nAMEDataGridViewTextBoxColumn1,
            this.aMOUNTDataGridViewTextBoxColumn1,
            this.COORDINATES_N,
            this.COORDINATES_E,
            this.FINE});
            this.dataGridView_Consumers.DataSource = this.cONSUMERBindingSource;
            this.dataGridView_Consumers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Consumers.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Consumers.Name = "dataGridView_Consumers";
            this.dataGridView_Consumers.Size = new System.Drawing.Size(723, 350);
            this.dataGridView_Consumers.TabIndex = 1;
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
            this.nAMEDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nAMEDataGridViewTextBoxColumn1.Name = "nAMEDataGridViewTextBoxColumn1";
            this.nAMEDataGridViewTextBoxColumn1.Width = 250;
            // 
            // aMOUNTDataGridViewTextBoxColumn1
            // 
            this.aMOUNTDataGridViewTextBoxColumn1.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.aMOUNTDataGridViewTextBoxColumn1.Name = "aMOUNTDataGridViewTextBoxColumn1";
            this.aMOUNTDataGridViewTextBoxColumn1.Width = 70;
            // 
            // COORDINATES_N
            // 
            this.COORDINATES_N.DataPropertyName = "COORDINATES_N";
            this.COORDINATES_N.HeaderText = "Coordinates N";
            this.COORDINATES_N.Name = "COORDINATES_N";
            // 
            // COORDINATES_E
            // 
            this.COORDINATES_E.DataPropertyName = "COORDINATES_E";
            this.COORDINATES_E.HeaderText = "Coordinates E";
            this.COORDINATES_E.Name = "COORDINATES_E";
            // 
            // FINE
            // 
            this.FINE.DataPropertyName = "FINE";
            this.FINE.HeaderText = "Fine";
            this.FINE.Name = "FINE";
            // 
            // cONSUMERBindingSource
            // 
            this.cONSUMERBindingSource.DataMember = "CONSUMER";
            this.cONSUMERBindingSource.DataSource = this.vRP_Accounting_DB_DataSet;
            // 
            // tabPage_Vehicles
            // 
            this.tabPage_Vehicles.Controls.Add(this.dataGridView_Vehicles);
            this.tabPage_Vehicles.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Vehicles.Name = "tabPage_Vehicles";
            this.tabPage_Vehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Vehicles.Size = new System.Drawing.Size(729, 356);
            this.tabPage_Vehicles.TabIndex = 2;
            this.tabPage_Vehicles.Text = "Vehicles";
            this.tabPage_Vehicles.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Vehicles
            // 
            this.dataGridView_Vehicles.AutoGenerateColumns = false;
            this.dataGridView_Vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Vehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.nAMEDataGridViewTextBoxColumn2,
            this.cONSUMPTIONDataGridViewTextBoxColumn,
            this.cOUNTDataGridViewTextBoxColumn,
            this.VOLUME});
            this.dataGridView_Vehicles.DataSource = this.vEHICLEBindingSource;
            this.dataGridView_Vehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Vehicles.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Vehicles.Name = "dataGridView_Vehicles";
            this.dataGridView_Vehicles.Size = new System.Drawing.Size(723, 350);
            this.dataGridView_Vehicles.TabIndex = 1;
            // 
            // vEHICLEBindingSource
            // 
            this.vEHICLEBindingSource.DataMember = "VEHICLE";
            this.vEHICLEBindingSource.DataSource = this.vRP_Accounting_DB_DataSet;
            // 
            // tabPage_DistanceConsumers
            // 
            this.tabPage_DistanceConsumers.Controls.Add(this.dataGridView_DistanceConsumers);
            this.tabPage_DistanceConsumers.Location = new System.Drawing.Point(4, 30);
            this.tabPage_DistanceConsumers.Name = "tabPage_DistanceConsumers";
            this.tabPage_DistanceConsumers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DistanceConsumers.Size = new System.Drawing.Size(729, 356);
            this.tabPage_DistanceConsumers.TabIndex = 3;
            this.tabPage_DistanceConsumers.Text = "Consumer-Consumer";
            this.tabPage_DistanceConsumers.UseVisualStyleBackColor = true;
            // 
            // dataGridView_DistanceConsumers
            // 
            this.dataGridView_DistanceConsumers.AutoGenerateColumns = false;
            this.dataGridView_DistanceConsumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DistanceConsumers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.iDCONSUMERFROMDataGridViewTextBoxColumn,
            this.iDCONSUMERTODataGridViewTextBoxColumn,
            this.dISTANCEDataGridViewTextBoxColumn});
            this.dataGridView_DistanceConsumers.DataSource = this.dISTANCECONSUMERSBindingSource;
            this.dataGridView_DistanceConsumers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DistanceConsumers.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_DistanceConsumers.Name = "dataGridView_DistanceConsumers";
            this.dataGridView_DistanceConsumers.Size = new System.Drawing.Size(723, 350);
            this.dataGridView_DistanceConsumers.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            this.iDDataGridViewTextBoxColumn3.Visible = false;
            this.iDDataGridViewTextBoxColumn3.Width = 50;
            // 
            // iDCONSUMERFROMDataGridViewTextBoxColumn
            // 
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.DataPropertyName = "ID_CONSUMER_FROM";
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.DataSource = this.cONSUMERBindingSource;
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.DisplayMember = "NAME";
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.HeaderText = "Consumer from";
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.Name = "iDCONSUMERFROMDataGridViewTextBoxColumn";
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.ValueMember = "ID";
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.Width = 250;
            // 
            // iDCONSUMERTODataGridViewTextBoxColumn
            // 
            this.iDCONSUMERTODataGridViewTextBoxColumn.DataPropertyName = "ID_CONSUMER_TO";
            this.iDCONSUMERTODataGridViewTextBoxColumn.DataSource = this.cONSUMERBindingSource;
            this.iDCONSUMERTODataGridViewTextBoxColumn.DisplayMember = "NAME";
            this.iDCONSUMERTODataGridViewTextBoxColumn.HeaderText = "Consumer to";
            this.iDCONSUMERTODataGridViewTextBoxColumn.Name = "iDCONSUMERTODataGridViewTextBoxColumn";
            this.iDCONSUMERTODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDCONSUMERTODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDCONSUMERTODataGridViewTextBoxColumn.ValueMember = "ID";
            this.iDCONSUMERTODataGridViewTextBoxColumn.Width = 250;
            // 
            // dISTANCEDataGridViewTextBoxColumn
            // 
            this.dISTANCEDataGridViewTextBoxColumn.DataPropertyName = "DISTANCE";
            this.dISTANCEDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.dISTANCEDataGridViewTextBoxColumn.Name = "dISTANCEDataGridViewTextBoxColumn";
            // 
            // dISTANCECONSUMERSBindingSource
            // 
            this.dISTANCECONSUMERSBindingSource.DataMember = "DISTANCE_CONSUMERS";
            this.dISTANCECONSUMERSBindingSource.DataSource = this.vRP_Accounting_DB_DataSet;
            // 
            // tabPage_DistanceDepotConsumer
            // 
            this.tabPage_DistanceDepotConsumer.Controls.Add(this.dataGridView_DistanceDepotConsumer);
            this.tabPage_DistanceDepotConsumer.Location = new System.Drawing.Point(4, 30);
            this.tabPage_DistanceDepotConsumer.Name = "tabPage_DistanceDepotConsumer";
            this.tabPage_DistanceDepotConsumer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DistanceDepotConsumer.Size = new System.Drawing.Size(729, 356);
            this.tabPage_DistanceDepotConsumer.TabIndex = 4;
            this.tabPage_DistanceDepotConsumer.Text = "Depot-Consumer";
            this.tabPage_DistanceDepotConsumer.UseVisualStyleBackColor = true;
            // 
            // dataGridView_DistanceDepotConsumer
            // 
            this.dataGridView_DistanceDepotConsumer.AutoGenerateColumns = false;
            this.dataGridView_DistanceDepotConsumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DistanceDepotConsumer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn4,
            this.iDDEPOTFROMDataGridViewTextBoxColumn,
            this.iDCONSUMERTODataGridViewTextBoxColumn1,
            this.dISTANCEDataGridViewTextBoxColumn1});
            this.dataGridView_DistanceDepotConsumer.DataSource = this.dISTANCEDEPOTCONSUMERBindingSource;
            this.dataGridView_DistanceDepotConsumer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DistanceDepotConsumer.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_DistanceDepotConsumer.Name = "dataGridView_DistanceDepotConsumer";
            this.dataGridView_DistanceDepotConsumer.Size = new System.Drawing.Size(723, 350);
            this.dataGridView_DistanceDepotConsumer.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn4
            // 
            this.iDDataGridViewTextBoxColumn4.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn4.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn4.Name = "iDDataGridViewTextBoxColumn4";
            this.iDDataGridViewTextBoxColumn4.Visible = false;
            this.iDDataGridViewTextBoxColumn4.Width = 50;
            // 
            // iDDEPOTFROMDataGridViewTextBoxColumn
            // 
            this.iDDEPOTFROMDataGridViewTextBoxColumn.DataPropertyName = "ID_DEPOT_FROM";
            this.iDDEPOTFROMDataGridViewTextBoxColumn.DataSource = this.dEPOTBindingSource;
            this.iDDEPOTFROMDataGridViewTextBoxColumn.DisplayMember = "NAME";
            this.iDDEPOTFROMDataGridViewTextBoxColumn.HeaderText = "Depot from";
            this.iDDEPOTFROMDataGridViewTextBoxColumn.Name = "iDDEPOTFROMDataGridViewTextBoxColumn";
            this.iDDEPOTFROMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDDEPOTFROMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDDEPOTFROMDataGridViewTextBoxColumn.ValueMember = "ID";
            this.iDDEPOTFROMDataGridViewTextBoxColumn.Width = 250;
            // 
            // iDCONSUMERTODataGridViewTextBoxColumn1
            // 
            this.iDCONSUMERTODataGridViewTextBoxColumn1.DataPropertyName = "ID_CONSUMER_TO";
            this.iDCONSUMERTODataGridViewTextBoxColumn1.DataSource = this.cONSUMERBindingSource;
            this.iDCONSUMERTODataGridViewTextBoxColumn1.DisplayMember = "NAME";
            this.iDCONSUMERTODataGridViewTextBoxColumn1.HeaderText = "Consumer to";
            this.iDCONSUMERTODataGridViewTextBoxColumn1.Name = "iDCONSUMERTODataGridViewTextBoxColumn1";
            this.iDCONSUMERTODataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDCONSUMERTODataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDCONSUMERTODataGridViewTextBoxColumn1.ValueMember = "ID";
            this.iDCONSUMERTODataGridViewTextBoxColumn1.Width = 250;
            // 
            // dISTANCEDataGridViewTextBoxColumn1
            // 
            this.dISTANCEDataGridViewTextBoxColumn1.DataPropertyName = "DISTANCE";
            this.dISTANCEDataGridViewTextBoxColumn1.HeaderText = "Distance";
            this.dISTANCEDataGridViewTextBoxColumn1.Name = "dISTANCEDataGridViewTextBoxColumn1";
            // 
            // dISTANCEDEPOTCONSUMERBindingSource
            // 
            this.dISTANCEDEPOTCONSUMERBindingSource.DataMember = "DISTANCE_DEPOT_CONSUMER";
            this.dISTANCEDEPOTCONSUMERBindingSource.DataSource = this.vRP_Accounting_DB_DataSet;
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(737, 24);
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
            this.solveTheProblemToolStripMenuItem.Click += new System.EventHandler(this.solveTheProblemToolStripMenuItem_Click);
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
            // dEPOTTableAdapter
            // 
            this.dEPOTTableAdapter.ClearBeforeFill = true;
            // 
            // cONSUMERTableAdapter
            // 
            this.cONSUMERTableAdapter.ClearBeforeFill = true;
            // 
            // vEHICLETableAdapter
            // 
            this.vEHICLETableAdapter.ClearBeforeFill = true;
            // 
            // dISTANCE_CONSUMERSTableAdapter
            // 
            this.dISTANCE_CONSUMERSTableAdapter.ClearBeforeFill = true;
            // 
            // dISTANCE_DEPOT_CONSUMERTableAdapter
            // 
            this.dISTANCE_DEPOT_CONSUMERTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.Visible = false;
            this.iDDataGridViewTextBoxColumn2.Width = 50;
            // 
            // nAMEDataGridViewTextBoxColumn2
            // 
            this.nAMEDataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nAMEDataGridViewTextBoxColumn2.Name = "nAMEDataGridViewTextBoxColumn2";
            this.nAMEDataGridViewTextBoxColumn2.Width = 250;
            // 
            // cONSUMPTIONDataGridViewTextBoxColumn
            // 
            this.cONSUMPTIONDataGridViewTextBoxColumn.DataPropertyName = "CONSUMPTION";
            this.cONSUMPTIONDataGridViewTextBoxColumn.HeaderText = "Consumption";
            this.cONSUMPTIONDataGridViewTextBoxColumn.Name = "cONSUMPTIONDataGridViewTextBoxColumn";
            this.cONSUMPTIONDataGridViewTextBoxColumn.Width = 120;
            // 
            // cOUNTDataGridViewTextBoxColumn
            // 
            this.cOUNTDataGridViewTextBoxColumn.DataPropertyName = "COUNT";
            this.cOUNTDataGridViewTextBoxColumn.HeaderText = "Count";
            this.cOUNTDataGridViewTextBoxColumn.Name = "cOUNTDataGridViewTextBoxColumn";
            this.cOUNTDataGridViewTextBoxColumn.Width = 70;
            // 
            // VOLUME
            // 
            this.VOLUME.DataPropertyName = "VOLUME";
            this.VOLUME.HeaderText = "Volume";
            this.VOLUME.Name = "VOLUME";
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 414);
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
            ((System.ComponentModel.ISupportInitialize)(this.vRP_Accounting_DB_DataSet)).EndInit();
            this.tabPage_Consumers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consumers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMERBindingSource)).EndInit();
            this.tabPage_Vehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).EndInit();
            this.tabPage_DistanceConsumers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DistanceConsumers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISTANCECONSUMERSBindingSource)).EndInit();
            this.tabPage_DistanceDepotConsumer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DistanceDepotConsumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISTANCEDEPOTCONSUMERBindingSource)).EndInit();
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
        private VRP_Accounting_DB_DataSet vRP_Accounting_DB_DataSet;
        private System.Windows.Forms.BindingSource dEPOTBindingSource;
        private VRP_Accounting_DB_DataSetTableAdapters.DEPOTTableAdapter dEPOTTableAdapter;
        private System.Windows.Forms.BindingSource cONSUMERBindingSource;
        private VRP_Accounting_DB_DataSetTableAdapters.CONSUMERTableAdapter cONSUMERTableAdapter;
        private System.Windows.Forms.BindingSource vEHICLEBindingSource;
        private VRP_Accounting_DB_DataSetTableAdapters.VEHICLETableAdapter vEHICLETableAdapter;
        private System.Windows.Forms.TabPage tabPage_DistanceConsumers;
        private System.Windows.Forms.TabPage tabPage_DistanceDepotConsumer;
        private System.Windows.Forms.DataGridView dataGridView_DistanceConsumers;
        private System.Windows.Forms.BindingSource dISTANCECONSUMERSBindingSource;
        private VRP_Accounting_DB_DataSetTableAdapters.DISTANCE_CONSUMERSTableAdapter dISTANCE_CONSUMERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDCONSUMERFROMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDCONSUMERTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISTANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_DistanceDepotConsumer;
        private System.Windows.Forms.BindingSource dISTANCEDEPOTCONSUMERBindingSource;
        private VRP_Accounting_DB_DataSetTableAdapters.DISTANCE_DEPOT_CONSUMERTableAdapter dISTANCE_DEPOT_CONSUMERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDDEPOTFROMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDCONSUMERTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISTANCEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOLUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOORDINATESNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOORDINATESEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COORDINATES_N;
        private System.Windows.Forms.DataGridViewTextBoxColumn COORDINATES_E;
        private System.Windows.Forms.DataGridViewTextBoxColumn FINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUMPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOLUME;
    }
}