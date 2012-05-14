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
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel_Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_Options = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_Options = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.label_Depot = new System.Windows.Forms.Label();
            this.comboBox_Depot = new System.Windows.Forms.ComboBox();
            this.vRP_Accounting_DB_DataSet = new Diploma.VRP_Accounting_DB_DataSet();
            this.dEPOTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_Vehicle = new System.Windows.Forms.Label();
            this.comboBox_Vehicle = new System.Windows.Forms.ComboBox();
            this.vEHICLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel_Main.SuspendLayout();
            this.flowLayoutPanel_Buttons.SuspendLayout();
            this.groupBox_Options.SuspendLayout();
            this.flowLayoutPanel_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vRP_Accounting_DB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPOTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Controls.Add(this.flowLayoutPanel_Buttons, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.groupBox_Options, 0, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 2;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(284, 157);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // flowLayoutPanel_Buttons
            // 
            this.flowLayoutPanel_Buttons.Controls.Add(this.button_Cancel);
            this.flowLayoutPanel_Buttons.Controls.Add(this.button_Ok);
            this.flowLayoutPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Buttons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel_Buttons.Location = new System.Drawing.Point(3, 125);
            this.flowLayoutPanel_Buttons.Name = "flowLayoutPanel_Buttons";
            this.flowLayoutPanel_Buttons.Size = new System.Drawing.Size(278, 29);
            this.flowLayoutPanel_Buttons.TabIndex = 0;
            // 
            // groupBox_Options
            // 
            this.groupBox_Options.Controls.Add(this.flowLayoutPanel_Options);
            this.groupBox_Options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Options.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Options.Name = "groupBox_Options";
            this.groupBox_Options.Size = new System.Drawing.Size(278, 116);
            this.groupBox_Options.TabIndex = 1;
            this.groupBox_Options.TabStop = false;
            this.groupBox_Options.Text = "Options";
            // 
            // flowLayoutPanel_Options
            // 
            this.flowLayoutPanel_Options.Controls.Add(this.label_Depot);
            this.flowLayoutPanel_Options.Controls.Add(this.comboBox_Depot);
            this.flowLayoutPanel_Options.Controls.Add(this.label_Vehicle);
            this.flowLayoutPanel_Options.Controls.Add(this.comboBox_Vehicle);
            this.flowLayoutPanel_Options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Options.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Options.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel_Options.Name = "flowLayoutPanel_Options";
            this.flowLayoutPanel_Options.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.flowLayoutPanel_Options.Size = new System.Drawing.Size(272, 97);
            this.flowLayoutPanel_Options.TabIndex = 0;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(200, 3);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(119, 3);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 1;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // label_Depot
            // 
            this.label_Depot.AutoSize = true;
            this.label_Depot.Location = new System.Drawing.Point(8, 5);
            this.label_Depot.Name = "label_Depot";
            this.label_Depot.Size = new System.Drawing.Size(36, 13);
            this.label_Depot.TabIndex = 0;
            this.label_Depot.Text = "Depot";
            // 
            // comboBox_Depot
            // 
            this.comboBox_Depot.DataSource = this.dEPOTBindingSource;
            this.comboBox_Depot.DisplayMember = "NAME";
            this.comboBox_Depot.FormattingEnabled = true;
            this.comboBox_Depot.Location = new System.Drawing.Point(8, 21);
            this.comboBox_Depot.Name = "comboBox_Depot";
            this.comboBox_Depot.Size = new System.Drawing.Size(258, 21);
            this.comboBox_Depot.TabIndex = 1;
            this.comboBox_Depot.ValueMember = "ID";
            // 
            // vRP_Accounting_DB_DataSet
            // 
            this.vRP_Accounting_DB_DataSet.DataSetName = "VRP_Accounting_DB_DataSet";
            this.vRP_Accounting_DB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEPOTBindingSource
            // 
            this.dEPOTBindingSource.DataMember = "DEPOT";
            this.dEPOTBindingSource.DataSource = this.vRP_Accounting_DB_DataSet;
            // 
            // label_Vehicle
            // 
            this.label_Vehicle.AutoSize = true;
            this.label_Vehicle.Location = new System.Drawing.Point(8, 45);
            this.label_Vehicle.Name = "label_Vehicle";
            this.label_Vehicle.Size = new System.Drawing.Size(42, 13);
            this.label_Vehicle.TabIndex = 2;
            this.label_Vehicle.Text = "Vehicle";
            // 
            // comboBox_Vehicle
            // 
            this.comboBox_Vehicle.DataSource = this.vEHICLEBindingSource;
            this.comboBox_Vehicle.DisplayMember = "NAME";
            this.comboBox_Vehicle.FormattingEnabled = true;
            this.comboBox_Vehicle.Location = new System.Drawing.Point(8, 61);
            this.comboBox_Vehicle.Name = "comboBox_Vehicle";
            this.comboBox_Vehicle.Size = new System.Drawing.Size(258, 21);
            this.comboBox_Vehicle.TabIndex = 3;
            this.comboBox_Vehicle.ValueMember = "ID";
            // 
            // vEHICLEBindingSource
            // 
            this.vEHICLEBindingSource.DataMember = "VEHICLE";
            this.vEHICLEBindingSource.DataSource = this.vRP_Accounting_DB_DataSet;
            // 
            // ToXmdlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 157);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Name = "ToXmdlForm";
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.flowLayoutPanel_Buttons.ResumeLayout(false);
            this.groupBox_Options.ResumeLayout(false);
            this.flowLayoutPanel_Options.ResumeLayout(false);
            this.flowLayoutPanel_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vRP_Accounting_DB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPOTBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource dEPOTBindingSource;
        private VRP_Accounting_DB_DataSet vRP_Accounting_DB_DataSet;
        private System.Windows.Forms.Label label_Vehicle;
        private System.Windows.Forms.ComboBox comboBox_Vehicle;
        private System.Windows.Forms.BindingSource vEHICLEBindingSource;
    }
}