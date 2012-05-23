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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBForm));
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
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUMPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOLUME = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            resources.ApplyResources(this.tabControl_Main, "tabControl_Main");
            this.tabControl_Main.Controls.Add(this.tabPage_Depots);
            this.tabControl_Main.Controls.Add(this.tabPage_Consumers);
            this.tabControl_Main.Controls.Add(this.tabPage_Vehicles);
            this.tabControl_Main.Controls.Add(this.tabPage_DistanceConsumers);
            this.tabControl_Main.Controls.Add(this.tabPage_DistanceDepotConsumer);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            // 
            // tabPage_Depots
            // 
            resources.ApplyResources(this.tabPage_Depots, "tabPage_Depots");
            this.tabPage_Depots.Controls.Add(this.dataGridView_Depots);
            this.tabPage_Depots.Name = "tabPage_Depots";
            this.tabPage_Depots.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Depots
            // 
            resources.ApplyResources(this.dataGridView_Depots, "dataGridView_Depots");
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
            this.dataGridView_Depots.Name = "dataGridView_Depots";
            this.dataGridView_Depots.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Depots_CellEndEdit);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn, "iDDataGridViewTextBoxColumn");
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            resources.ApplyResources(this.nAMEDataGridViewTextBoxColumn, "nAMEDataGridViewTextBoxColumn");
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            resources.ApplyResources(this.aMOUNTDataGridViewTextBoxColumn, "aMOUNTDataGridViewTextBoxColumn");
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            // 
            // vOLUMEDataGridViewTextBoxColumn
            // 
            this.vOLUMEDataGridViewTextBoxColumn.DataPropertyName = "VOLUME";
            resources.ApplyResources(this.vOLUMEDataGridViewTextBoxColumn, "vOLUMEDataGridViewTextBoxColumn");
            this.vOLUMEDataGridViewTextBoxColumn.Name = "vOLUMEDataGridViewTextBoxColumn";
            // 
            // cOORDINATESNDataGridViewTextBoxColumn
            // 
            this.cOORDINATESNDataGridViewTextBoxColumn.DataPropertyName = "COORDINATES_N";
            resources.ApplyResources(this.cOORDINATESNDataGridViewTextBoxColumn, "cOORDINATESNDataGridViewTextBoxColumn");
            this.cOORDINATESNDataGridViewTextBoxColumn.Name = "cOORDINATESNDataGridViewTextBoxColumn";
            // 
            // cOORDINATESEDataGridViewTextBoxColumn
            // 
            this.cOORDINATESEDataGridViewTextBoxColumn.DataPropertyName = "COORDINATES_E";
            resources.ApplyResources(this.cOORDINATESEDataGridViewTextBoxColumn, "cOORDINATESEDataGridViewTextBoxColumn");
            this.cOORDINATESEDataGridViewTextBoxColumn.Name = "cOORDINATESEDataGridViewTextBoxColumn";
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
            resources.ApplyResources(this.tabPage_Consumers, "tabPage_Consumers");
            this.tabPage_Consumers.Controls.Add(this.dataGridView_Consumers);
            this.tabPage_Consumers.Name = "tabPage_Consumers";
            this.tabPage_Consumers.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Consumers
            // 
            resources.ApplyResources(this.dataGridView_Consumers, "dataGridView_Consumers");
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
            this.dataGridView_Consumers.Name = "dataGridView_Consumers";
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn1, "iDDataGridViewTextBoxColumn1");
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // nAMEDataGridViewTextBoxColumn1
            // 
            this.nAMEDataGridViewTextBoxColumn1.DataPropertyName = "NAME";
            resources.ApplyResources(this.nAMEDataGridViewTextBoxColumn1, "nAMEDataGridViewTextBoxColumn1");
            this.nAMEDataGridViewTextBoxColumn1.Name = "nAMEDataGridViewTextBoxColumn1";
            // 
            // aMOUNTDataGridViewTextBoxColumn1
            // 
            this.aMOUNTDataGridViewTextBoxColumn1.DataPropertyName = "AMOUNT";
            resources.ApplyResources(this.aMOUNTDataGridViewTextBoxColumn1, "aMOUNTDataGridViewTextBoxColumn1");
            this.aMOUNTDataGridViewTextBoxColumn1.Name = "aMOUNTDataGridViewTextBoxColumn1";
            // 
            // COORDINATES_N
            // 
            this.COORDINATES_N.DataPropertyName = "COORDINATES_N";
            resources.ApplyResources(this.COORDINATES_N, "COORDINATES_N");
            this.COORDINATES_N.Name = "COORDINATES_N";
            // 
            // COORDINATES_E
            // 
            this.COORDINATES_E.DataPropertyName = "COORDINATES_E";
            resources.ApplyResources(this.COORDINATES_E, "COORDINATES_E");
            this.COORDINATES_E.Name = "COORDINATES_E";
            // 
            // FINE
            // 
            this.FINE.DataPropertyName = "FINE";
            resources.ApplyResources(this.FINE, "FINE");
            this.FINE.Name = "FINE";
            // 
            // cONSUMERBindingSource
            // 
            this.cONSUMERBindingSource.DataMember = "CONSUMER";
            this.cONSUMERBindingSource.DataSource = this.vRP_Accounting_DB_DataSet;
            // 
            // tabPage_Vehicles
            // 
            resources.ApplyResources(this.tabPage_Vehicles, "tabPage_Vehicles");
            this.tabPage_Vehicles.Controls.Add(this.dataGridView_Vehicles);
            this.tabPage_Vehicles.Name = "tabPage_Vehicles";
            this.tabPage_Vehicles.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Vehicles
            // 
            resources.ApplyResources(this.dataGridView_Vehicles, "dataGridView_Vehicles");
            this.dataGridView_Vehicles.AutoGenerateColumns = false;
            this.dataGridView_Vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Vehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.nAMEDataGridViewTextBoxColumn2,
            this.cONSUMPTIONDataGridViewTextBoxColumn,
            this.cOUNTDataGridViewTextBoxColumn,
            this.VOLUME});
            this.dataGridView_Vehicles.DataSource = this.vEHICLEBindingSource;
            this.dataGridView_Vehicles.Name = "dataGridView_Vehicles";
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn2, "iDDataGridViewTextBoxColumn2");
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            // 
            // nAMEDataGridViewTextBoxColumn2
            // 
            this.nAMEDataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            resources.ApplyResources(this.nAMEDataGridViewTextBoxColumn2, "nAMEDataGridViewTextBoxColumn2");
            this.nAMEDataGridViewTextBoxColumn2.Name = "nAMEDataGridViewTextBoxColumn2";
            // 
            // cONSUMPTIONDataGridViewTextBoxColumn
            // 
            this.cONSUMPTIONDataGridViewTextBoxColumn.DataPropertyName = "CONSUMPTION";
            resources.ApplyResources(this.cONSUMPTIONDataGridViewTextBoxColumn, "cONSUMPTIONDataGridViewTextBoxColumn");
            this.cONSUMPTIONDataGridViewTextBoxColumn.Name = "cONSUMPTIONDataGridViewTextBoxColumn";
            // 
            // cOUNTDataGridViewTextBoxColumn
            // 
            this.cOUNTDataGridViewTextBoxColumn.DataPropertyName = "COUNT";
            resources.ApplyResources(this.cOUNTDataGridViewTextBoxColumn, "cOUNTDataGridViewTextBoxColumn");
            this.cOUNTDataGridViewTextBoxColumn.Name = "cOUNTDataGridViewTextBoxColumn";
            // 
            // VOLUME
            // 
            this.VOLUME.DataPropertyName = "VOLUME";
            resources.ApplyResources(this.VOLUME, "VOLUME");
            this.VOLUME.Name = "VOLUME";
            // 
            // vEHICLEBindingSource
            // 
            this.vEHICLEBindingSource.DataMember = "VEHICLE";
            this.vEHICLEBindingSource.DataSource = this.vRP_Accounting_DB_DataSet;
            // 
            // tabPage_DistanceConsumers
            // 
            resources.ApplyResources(this.tabPage_DistanceConsumers, "tabPage_DistanceConsumers");
            this.tabPage_DistanceConsumers.Controls.Add(this.dataGridView_DistanceConsumers);
            this.tabPage_DistanceConsumers.Name = "tabPage_DistanceConsumers";
            this.tabPage_DistanceConsumers.UseVisualStyleBackColor = true;
            // 
            // dataGridView_DistanceConsumers
            // 
            resources.ApplyResources(this.dataGridView_DistanceConsumers, "dataGridView_DistanceConsumers");
            this.dataGridView_DistanceConsumers.AutoGenerateColumns = false;
            this.dataGridView_DistanceConsumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DistanceConsumers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.iDCONSUMERFROMDataGridViewTextBoxColumn,
            this.iDCONSUMERTODataGridViewTextBoxColumn,
            this.dISTANCEDataGridViewTextBoxColumn});
            this.dataGridView_DistanceConsumers.DataSource = this.dISTANCECONSUMERSBindingSource;
            this.dataGridView_DistanceConsumers.Name = "dataGridView_DistanceConsumers";
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn3, "iDDataGridViewTextBoxColumn3");
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            // 
            // iDCONSUMERFROMDataGridViewTextBoxColumn
            // 
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.DataPropertyName = "ID_CONSUMER_FROM";
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.DataSource = this.cONSUMERBindingSource;
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.DisplayMember = "NAME";
            resources.ApplyResources(this.iDCONSUMERFROMDataGridViewTextBoxColumn, "iDCONSUMERFROMDataGridViewTextBoxColumn");
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.Name = "iDCONSUMERFROMDataGridViewTextBoxColumn";
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDCONSUMERFROMDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // iDCONSUMERTODataGridViewTextBoxColumn
            // 
            this.iDCONSUMERTODataGridViewTextBoxColumn.DataPropertyName = "ID_CONSUMER_TO";
            this.iDCONSUMERTODataGridViewTextBoxColumn.DataSource = this.cONSUMERBindingSource;
            this.iDCONSUMERTODataGridViewTextBoxColumn.DisplayMember = "NAME";
            resources.ApplyResources(this.iDCONSUMERTODataGridViewTextBoxColumn, "iDCONSUMERTODataGridViewTextBoxColumn");
            this.iDCONSUMERTODataGridViewTextBoxColumn.Name = "iDCONSUMERTODataGridViewTextBoxColumn";
            this.iDCONSUMERTODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDCONSUMERTODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDCONSUMERTODataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // dISTANCEDataGridViewTextBoxColumn
            // 
            this.dISTANCEDataGridViewTextBoxColumn.DataPropertyName = "DISTANCE";
            resources.ApplyResources(this.dISTANCEDataGridViewTextBoxColumn, "dISTANCEDataGridViewTextBoxColumn");
            this.dISTANCEDataGridViewTextBoxColumn.Name = "dISTANCEDataGridViewTextBoxColumn";
            // 
            // dISTANCECONSUMERSBindingSource
            // 
            this.dISTANCECONSUMERSBindingSource.DataMember = "DISTANCE_CONSUMERS";
            this.dISTANCECONSUMERSBindingSource.DataSource = this.vRP_Accounting_DB_DataSet;
            // 
            // tabPage_DistanceDepotConsumer
            // 
            resources.ApplyResources(this.tabPage_DistanceDepotConsumer, "tabPage_DistanceDepotConsumer");
            this.tabPage_DistanceDepotConsumer.Controls.Add(this.dataGridView_DistanceDepotConsumer);
            this.tabPage_DistanceDepotConsumer.Name = "tabPage_DistanceDepotConsumer";
            this.tabPage_DistanceDepotConsumer.UseVisualStyleBackColor = true;
            // 
            // dataGridView_DistanceDepotConsumer
            // 
            resources.ApplyResources(this.dataGridView_DistanceDepotConsumer, "dataGridView_DistanceDepotConsumer");
            this.dataGridView_DistanceDepotConsumer.AutoGenerateColumns = false;
            this.dataGridView_DistanceDepotConsumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DistanceDepotConsumer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn4,
            this.iDDEPOTFROMDataGridViewTextBoxColumn,
            this.iDCONSUMERTODataGridViewTextBoxColumn1,
            this.dISTANCEDataGridViewTextBoxColumn1});
            this.dataGridView_DistanceDepotConsumer.DataSource = this.dISTANCEDEPOTCONSUMERBindingSource;
            this.dataGridView_DistanceDepotConsumer.Name = "dataGridView_DistanceDepotConsumer";
            // 
            // iDDataGridViewTextBoxColumn4
            // 
            this.iDDataGridViewTextBoxColumn4.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn4, "iDDataGridViewTextBoxColumn4");
            this.iDDataGridViewTextBoxColumn4.Name = "iDDataGridViewTextBoxColumn4";
            // 
            // iDDEPOTFROMDataGridViewTextBoxColumn
            // 
            this.iDDEPOTFROMDataGridViewTextBoxColumn.DataPropertyName = "ID_DEPOT_FROM";
            this.iDDEPOTFROMDataGridViewTextBoxColumn.DataSource = this.dEPOTBindingSource;
            this.iDDEPOTFROMDataGridViewTextBoxColumn.DisplayMember = "NAME";
            resources.ApplyResources(this.iDDEPOTFROMDataGridViewTextBoxColumn, "iDDEPOTFROMDataGridViewTextBoxColumn");
            this.iDDEPOTFROMDataGridViewTextBoxColumn.Name = "iDDEPOTFROMDataGridViewTextBoxColumn";
            this.iDDEPOTFROMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDDEPOTFROMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDDEPOTFROMDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // iDCONSUMERTODataGridViewTextBoxColumn1
            // 
            this.iDCONSUMERTODataGridViewTextBoxColumn1.DataPropertyName = "ID_CONSUMER_TO";
            this.iDCONSUMERTODataGridViewTextBoxColumn1.DataSource = this.cONSUMERBindingSource;
            this.iDCONSUMERTODataGridViewTextBoxColumn1.DisplayMember = "NAME";
            resources.ApplyResources(this.iDCONSUMERTODataGridViewTextBoxColumn1, "iDCONSUMERTODataGridViewTextBoxColumn1");
            this.iDCONSUMERTODataGridViewTextBoxColumn1.Name = "iDCONSUMERTODataGridViewTextBoxColumn1";
            this.iDCONSUMERTODataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDCONSUMERTODataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDCONSUMERTODataGridViewTextBoxColumn1.ValueMember = "ID";
            // 
            // dISTANCEDataGridViewTextBoxColumn1
            // 
            this.dISTANCEDataGridViewTextBoxColumn1.DataPropertyName = "DISTANCE";
            resources.ApplyResources(this.dISTANCEDataGridViewTextBoxColumn1, "dISTANCEDataGridViewTextBoxColumn1");
            this.dISTANCEDataGridViewTextBoxColumn1.Name = "dISTANCEDataGridViewTextBoxColumn1";
            // 
            // dISTANCEDEPOTCONSUMERBindingSource
            // 
            this.dISTANCEDEPOTCONSUMERBindingSource.DataMember = "DISTANCE_DEPOT_CONSUMER";
            this.dISTANCEDEPOTCONSUMERBindingSource.DataSource = this.vRP_Accounting_DB_DataSet;
            // 
            // menuStrip_Main
            // 
            resources.ApplyResources(this.menuStrip_Main, "menuStrip_Main");
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_Main.Name = "menuStrip_Main";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToXMDLToolStripMenuItem,
            this.solveTheProblemToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // exportToXMDLToolStripMenuItem
            // 
            resources.ApplyResources(this.exportToXMDLToolStripMenuItem, "exportToXMDLToolStripMenuItem");
            this.exportToXMDLToolStripMenuItem.Name = "exportToXMDLToolStripMenuItem";
            this.exportToXMDLToolStripMenuItem.Click += new System.EventHandler(this.exportToXMDLToolStripMenuItem_Click);
            // 
            // solveTheProblemToolStripMenuItem
            // 
            resources.ApplyResources(this.solveTheProblemToolStripMenuItem, "solveTheProblemToolStripMenuItem");
            this.solveTheProblemToolStripMenuItem.Name = "solveTheProblemToolStripMenuItem";
            this.solveTheProblemToolStripMenuItem.Click += new System.EventHandler(this.solveTheProblemToolStripMenuItem_Click);
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
            // DBForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "DBForm";
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
        private System.Windows.Forms.DataGridView dataGridView_DistanceDepotConsumer;
        private System.Windows.Forms.BindingSource dISTANCEDEPOTCONSUMERBindingSource;
        private VRP_Accounting_DB_DataSetTableAdapters.DISTANCE_DEPOT_CONSUMERTableAdapter dISTANCE_DEPOT_CONSUMERTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDCONSUMERFROMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDCONSUMERTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISTANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDDEPOTFROMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDCONSUMERTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISTANCEDataGridViewTextBoxColumn1;
    }
}