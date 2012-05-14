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
            this.tabPage_Consumers = new System.Windows.Forms.TabPage();
            this.tabPage_Vehicles = new System.Windows.Forms.TabPage();
            this.tabControl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Depots);
            this.tabControl_Main.Controls.Add(this.tabPage_Consumers);
            this.tabControl_Main.Controls.Add(this.tabPage_Vehicles);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(734, 414);
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_Depots
            // 
            this.tabPage_Depots.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Depots.Name = "tabPage_Depots";
            this.tabPage_Depots.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Depots.Size = new System.Drawing.Size(726, 388);
            this.tabPage_Depots.TabIndex = 0;
            this.tabPage_Depots.Text = "Depots";
            this.tabPage_Depots.UseVisualStyleBackColor = true;
            // 
            // tabPage_Consumers
            // 
            this.tabPage_Consumers.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Consumers.Name = "tabPage_Consumers";
            this.tabPage_Consumers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Consumers.Size = new System.Drawing.Size(726, 388);
            this.tabPage_Consumers.TabIndex = 1;
            this.tabPage_Consumers.Text = "Consumers";
            this.tabPage_Consumers.UseVisualStyleBackColor = true;
            // 
            // tabPage_Vehicles
            // 
            this.tabPage_Vehicles.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Vehicles.Name = "tabPage_Vehicles";
            this.tabPage_Vehicles.Size = new System.Drawing.Size(726, 388);
            this.tabPage_Vehicles.TabIndex = 2;
            this.tabPage_Vehicles.Text = "Vehicles";
            this.tabPage_Vehicles.UseVisualStyleBackColor = true;
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 414);
            this.Controls.Add(this.tabControl_Main);
            this.Name = "DBForm";
            this.Text = "Accounting";
            this.tabControl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Depots;
        private System.Windows.Forms.TabPage tabPage_Consumers;
        private System.Windows.Forms.TabPage tabPage_Vehicles;
    }
}