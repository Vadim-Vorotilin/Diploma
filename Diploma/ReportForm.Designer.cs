namespace Diploma
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.button_Ok = new System.Windows.Forms.Button();
            this.richTextBox_Report = new System.Windows.Forms.RichTextBox();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveReportToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            resources.ApplyResources(this.tableLayoutPanel_Main, "tableLayoutPanel_Main");
            this.tableLayoutPanel_Main.Controls.Add(this.button_Ok, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.richTextBox_Report, 0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            // 
            // button_Ok
            // 
            resources.ApplyResources(this.button_Ok, "button_Ok");
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // richTextBox_Report
            // 
            resources.ApplyResources(this.richTextBox_Report, "richTextBox_Report");
            this.richTextBox_Report.Name = "richTextBox_Report";
            this.richTextBox_Report.ReadOnly = true;
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
            this.saveReportToFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // saveReportToFileToolStripMenuItem
            // 
            resources.ApplyResources(this.saveReportToFileToolStripMenuItem, "saveReportToFileToolStripMenuItem");
            this.saveReportToFileToolStripMenuItem.Name = "saveReportToFileToolStripMenuItem";
            this.saveReportToFileToolStripMenuItem.Click += new System.EventHandler(this.saveReportToFileToolStripMenuItem_Click);
            // 
            // ReportForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "ReportForm";
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.RichTextBox richTextBox_Report;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveReportToFileToolStripMenuItem;
    }
}