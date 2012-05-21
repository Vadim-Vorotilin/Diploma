namespace Diploma
{
    partial class ToXmdlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToXmdlForm));
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel_Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.groupBox_Options = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_Options = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Depot = new System.Windows.Forms.Label();
            this.comboBox_Depot = new System.Windows.Forms.ComboBox();
            this.dEPOTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vRP_Accounting_DB_DataSet = new Diploma.VRP_Accounting_DB_DataSet();
            this.label_Vehicle = new System.Windows.Forms.Label();
            this.comboBox_Vehicle = new System.Windows.Forms.ComboBox();
            this.vEHICLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPOTTableAdapter = new Diploma.VRP_Accounting_DB_DataSetTableAdapters.DEPOTTableAdapter();
            this.vEHICLETableAdapter = new Diploma.VRP_Accounting_DB_DataSetTableAdapters.VEHICLETableAdapter();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.flowLayoutPanel_Buttons.SuspendLayout();
            this.groupBox_Options.SuspendLayout();
            this.flowLayoutPanel_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEPOTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRP_Accounting_DB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            resources.ApplyResources(this.tableLayoutPanel_Main, "tableLayoutPanel_Main");
            this.tableLayoutPanel_Main.Controls.Add(this.flowLayoutPanel_Buttons, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.groupBox_Options, 0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            // 
            // flowLayoutPanel_Buttons
            // 
            resources.ApplyResources(this.flowLayoutPanel_Buttons, "flowLayoutPanel_Buttons");
            this.flowLayoutPanel_Buttons.Controls.Add(this.button_Cancel);
            this.flowLayoutPanel_Buttons.Controls.Add(this.button_Ok);
            this.flowLayoutPanel_Buttons.Name = "flowLayoutPanel_Buttons";
            // 
            // button_Cancel
            // 
            resources.ApplyResources(this.button_Cancel, "button_Cancel");
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Ok
            // 
            resources.ApplyResources(this.button_Ok, "button_Ok");
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // groupBox_Options
            // 
            resources.ApplyResources(this.groupBox_Options, "groupBox_Options");
            this.groupBox_Options.Controls.Add(this.flowLayoutPanel_Options);
            this.groupBox_Options.Name = "groupBox_Options";
            this.groupBox_Options.TabStop = false;
            // 
            // flowLayoutPanel_Options
            // 
            resources.ApplyResources(this.flowLayoutPanel_Options, "flowLayoutPanel_Options");
            this.flowLayoutPanel_Options.Controls.Add(this.label_Depot);
            this.flowLayoutPanel_Options.Controls.Add(this.comboBox_Depot);
            this.flowLayoutPanel_Options.Controls.Add(this.label_Vehicle);
            this.flowLayoutPanel_Options.Controls.Add(this.comboBox_Vehicle);
            this.flowLayoutPanel_Options.Name = "flowLayoutPanel_Options";
            // 
            // label_Depot
            // 
            resources.ApplyResources(this.label_Depot, "label_Depot");
            this.label_Depot.Name = "label_Depot";
            // 
            // comboBox_Depot
            // 
            resources.ApplyResources(this.comboBox_Depot, "comboBox_Depot");
            this.comboBox_Depot.DataSource = this.dEPOTBindingSource;
            this.comboBox_Depot.DisplayMember = "NAME";
            this.comboBox_Depot.FormattingEnabled = true;
            this.comboBox_Depot.Name = "comboBox_Depot";
            this.comboBox_Depot.ValueMember = "ID";
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
            // label_Vehicle
            // 
            resources.ApplyResources(this.label_Vehicle, "label_Vehicle");
            this.label_Vehicle.Name = "label_Vehicle";
            // 
            // comboBox_Vehicle
            // 
            resources.ApplyResources(this.comboBox_Vehicle, "comboBox_Vehicle");
            this.comboBox_Vehicle.DataSource = this.vEHICLEBindingSource;
            this.comboBox_Vehicle.DisplayMember = "NAME";
            this.comboBox_Vehicle.FormattingEnabled = true;
            this.comboBox_Vehicle.Name = "comboBox_Vehicle";
            this.comboBox_Vehicle.ValueMember = "ID";
            // 
            // vEHICLEBindingSource
            // 
            this.vEHICLEBindingSource.DataMember = "VEHICLE";
            this.vEHICLEBindingSource.DataSource = this.vRP_Accounting_DB_DataSet;
            // 
            // dEPOTTableAdapter
            // 
            this.dEPOTTableAdapter.ClearBeforeFill = true;
            // 
            // vEHICLETableAdapter
            // 
            this.vEHICLETableAdapter.ClearBeforeFill = true;
            // 
            // ToXmdlForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Name = "ToXmdlForm";
            this.Load += new System.EventHandler(this.ToXmdlForm_Load);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.flowLayoutPanel_Buttons.ResumeLayout(false);
            this.groupBox_Options.ResumeLayout(false);
            this.flowLayoutPanel_Options.ResumeLayout(false);
            this.flowLayoutPanel_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEPOTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRP_Accounting_DB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Buttons;
        private System.Windows.Forms.GroupBox groupBox_Options;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Options;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Label label_Depot;
        private System.Windows.Forms.ComboBox comboBox_Depot;
        private System.Windows.Forms.Label label_Vehicle;
        private System.Windows.Forms.ComboBox comboBox_Vehicle;
        private VRP_Accounting_DB_DataSet vRP_Accounting_DB_DataSet;
        private System.Windows.Forms.BindingSource dEPOTBindingSource;
        private VRP_Accounting_DB_DataSetTableAdapters.DEPOTTableAdapter dEPOTTableAdapter;
        private System.Windows.Forms.BindingSource vEHICLEBindingSource;
        private VRP_Accounting_DB_DataSetTableAdapters.VEHICLETableAdapter vEHICLETableAdapter;
    }
}