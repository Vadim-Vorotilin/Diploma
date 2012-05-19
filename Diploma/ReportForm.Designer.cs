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
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Controls.Add(this.button_Ok, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.richTextBox_Report, 0, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 2;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(376, 550);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // button_Ok
            // 
            this.button_Ok.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Ok.Location = new System.Drawing.Point(298, 521);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Ok.Size = new System.Drawing.Size(75, 26);
            this.button_Ok.TabIndex = 0;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // richTextBox_Report
            // 
            this.richTextBox_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Report.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Report.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_Report.Name = "richTextBox_Report";
            this.richTextBox_Report.ReadOnly = true;
            this.richTextBox_Report.Size = new System.Drawing.Size(370, 512);
            this.richTextBox_Report.TabIndex = 1;
            this.richTextBox_Report.Text = resources.GetString("richTextBox_Report.Text");
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(376, 24);
            this.menuStrip_Main.TabIndex = 1;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveReportToFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveReportToFileToolStripMenuItem
            // 
            this.saveReportToFileToolStripMenuItem.Name = "saveReportToFileToolStripMenuItem";
            this.saveReportToFileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveReportToFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveReportToFileToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.saveReportToFileToolStripMenuItem.Text = "Save report to file ...";
            this.saveReportToFileToolStripMenuItem.Click += new System.EventHandler(this.saveReportToFileToolStripMenuItem_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 574);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "ReportForm";
            this.Text = "Report";
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