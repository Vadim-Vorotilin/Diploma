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
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel_Tools = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Redraw = new System.Windows.Forms.Button();
            this.button_AddNode = new System.Windows.Forms.Button();
            this.groupBox_NodeType = new System.Windows.Forms.GroupBox();
            this.radioButton_isConsumer = new System.Windows.Forms.RadioButton();
            this.radioButton_isDepot = new System.Windows.Forms.RadioButton();
            this.button_StartAlgorithm = new System.Windows.Forms.Button();
            this.button_Iteration = new System.Windows.Forms.Button();
            this.numericUpDown_IterationsCount = new System.Windows.Forms.NumericUpDown();
            this.button_Iterate = new System.Windows.Forms.Button();
            this.panel_Drawing = new System.Windows.Forms.Panel();
            this.menuStrip_MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveModelAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox_Algorithm = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.flowLayoutPanel_Tools.SuspendLayout();
            this.groupBox_NodeType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IterationsCount)).BeginInit();
            this.menuStrip_MainMenu.SuspendLayout();
            this.groupBox_Algorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 2;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel_Main.Controls.Add(this.flowLayoutPanel_Tools, 1, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.panel_Drawing, 0, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 2;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(922, 462);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // flowLayoutPanel_Tools
            // 
            this.flowLayoutPanel_Tools.Controls.Add(this.button_Redraw);
            this.flowLayoutPanel_Tools.Controls.Add(this.button_AddNode);
            this.flowLayoutPanel_Tools.Controls.Add(this.groupBox_NodeType);
            this.flowLayoutPanel_Tools.Controls.Add(this.groupBox_Algorithm);
            this.flowLayoutPanel_Tools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Tools.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Tools.Location = new System.Drawing.Point(791, 3);
            this.flowLayoutPanel_Tools.Name = "flowLayoutPanel_Tools";
            this.flowLayoutPanel_Tools.Size = new System.Drawing.Size(128, 422);
            this.flowLayoutPanel_Tools.TabIndex = 0;
            // 
            // button_Redraw
            // 
            this.button_Redraw.Location = new System.Drawing.Point(3, 3);
            this.button_Redraw.Name = "button_Redraw";
            this.button_Redraw.Size = new System.Drawing.Size(116, 23);
            this.button_Redraw.TabIndex = 0;
            this.button_Redraw.Text = "Redraw";
            this.button_Redraw.UseVisualStyleBackColor = true;
            this.button_Redraw.Click += new System.EventHandler(this.button_Redraw_Click);
            // 
            // button_AddNode
            // 
            this.button_AddNode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_AddNode.Location = new System.Drawing.Point(3, 32);
            this.button_AddNode.Name = "button_AddNode";
            this.button_AddNode.Size = new System.Drawing.Size(116, 23);
            this.button_AddNode.TabIndex = 2;
            this.button_AddNode.Text = "Add node";
            this.button_AddNode.UseVisualStyleBackColor = true;
            this.button_AddNode.Click += new System.EventHandler(this.button_AddNode_Click);
            // 
            // groupBox_NodeType
            // 
            this.groupBox_NodeType.Controls.Add(this.radioButton_isConsumer);
            this.groupBox_NodeType.Controls.Add(this.radioButton_isDepot);
            this.groupBox_NodeType.Location = new System.Drawing.Point(3, 61);
            this.groupBox_NodeType.Name = "groupBox_NodeType";
            this.groupBox_NodeType.Size = new System.Drawing.Size(116, 66);
            this.groupBox_NodeType.TabIndex = 1;
            this.groupBox_NodeType.TabStop = false;
            this.groupBox_NodeType.Text = "Node type";
            // 
            // radioButton_isConsumer
            // 
            this.radioButton_isConsumer.AutoSize = true;
            this.radioButton_isConsumer.Checked = true;
            this.radioButton_isConsumer.Location = new System.Drawing.Point(7, 43);
            this.radioButton_isConsumer.Name = "radioButton_isConsumer";
            this.radioButton_isConsumer.Size = new System.Drawing.Size(72, 17);
            this.radioButton_isConsumer.TabIndex = 1;
            this.radioButton_isConsumer.TabStop = true;
            this.radioButton_isConsumer.Text = "Consumer";
            this.radioButton_isConsumer.UseVisualStyleBackColor = true;
            // 
            // radioButton_isDepot
            // 
            this.radioButton_isDepot.AutoSize = true;
            this.radioButton_isDepot.Location = new System.Drawing.Point(7, 20);
            this.radioButton_isDepot.Name = "radioButton_isDepot";
            this.radioButton_isDepot.Size = new System.Drawing.Size(54, 17);
            this.radioButton_isDepot.TabIndex = 0;
            this.radioButton_isDepot.Text = "Depot";
            this.radioButton_isDepot.UseVisualStyleBackColor = true;
            // 
            // button_StartAlgorithm
            // 
            this.button_StartAlgorithm.Location = new System.Drawing.Point(6, 19);
            this.button_StartAlgorithm.Name = "button_StartAlgorithm";
            this.button_StartAlgorithm.Size = new System.Drawing.Size(104, 23);
            this.button_StartAlgorithm.TabIndex = 3;
            this.button_StartAlgorithm.Text = "Start";
            this.button_StartAlgorithm.UseVisualStyleBackColor = true;
            this.button_StartAlgorithm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_StartAlgorithm_MouseClick);
            // 
            // button_Iteration
            // 
            this.button_Iteration.Location = new System.Drawing.Point(6, 48);
            this.button_Iteration.Name = "button_Iteration";
            this.button_Iteration.Size = new System.Drawing.Size(104, 23);
            this.button_Iteration.TabIndex = 4;
            this.button_Iteration.Text = "Iteration";
            this.button_Iteration.UseVisualStyleBackColor = true;
            this.button_Iteration.Click += new System.EventHandler(this.button_Iteration_Click);
            // 
            // numericUpDown_IterationsCount
            // 
            this.numericUpDown_IterationsCount.Location = new System.Drawing.Point(6, 77);
            this.numericUpDown_IterationsCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_IterationsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_IterationsCount.Name = "numericUpDown_IterationsCount";
            this.numericUpDown_IterationsCount.Size = new System.Drawing.Size(104, 20);
            this.numericUpDown_IterationsCount.TabIndex = 5;
            this.numericUpDown_IterationsCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_Iterate
            // 
            this.button_Iterate.Location = new System.Drawing.Point(6, 103);
            this.button_Iterate.Name = "button_Iterate";
            this.button_Iterate.Size = new System.Drawing.Size(104, 23);
            this.button_Iterate.TabIndex = 6;
            this.button_Iterate.Text = "Iterate";
            this.button_Iterate.UseVisualStyleBackColor = true;
            this.button_Iterate.Click += new System.EventHandler(this.button_Iterate_Click);
            // 
            // panel_Drawing
            // 
            this.panel_Drawing.BackColor = System.Drawing.Color.White;
            this.panel_Drawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Drawing.Location = new System.Drawing.Point(3, 3);
            this.panel_Drawing.Name = "panel_Drawing";
            this.panel_Drawing.Size = new System.Drawing.Size(782, 422);
            this.panel_Drawing.TabIndex = 1;
            this.panel_Drawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Drawing_MouseClick);
            // 
            // menuStrip_MainMenu
            // 
            this.menuStrip_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MainMenu.Name = "menuStrip_MainMenu";
            this.menuStrip_MainMenu.Size = new System.Drawing.Size(922, 24);
            this.menuStrip_MainMenu.TabIndex = 1;
            this.menuStrip_MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newModelToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveModelToolStripMenuItem,
            this.saveModelAsToolStripMenuItem,
            this.loadModelToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newModelToolStripMenuItem
            // 
            this.newModelToolStripMenuItem.Name = "newModelToolStripMenuItem";
            this.newModelToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.newModelToolStripMenuItem.Text = "New model";
            this.newModelToolStripMenuItem.Click += new System.EventHandler(this.newModelToolStripMenuItem_Click);
            // 
            // saveModelToolStripMenuItem
            // 
            this.saveModelToolStripMenuItem.Name = "saveModelToolStripMenuItem";
            this.saveModelToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveModelToolStripMenuItem.Text = "Save model";
            this.saveModelToolStripMenuItem.Click += new System.EventHandler(this.saveModelToolStripMenuItem_Click);
            // 
            // saveModelAsToolStripMenuItem
            // 
            this.saveModelAsToolStripMenuItem.Name = "saveModelAsToolStripMenuItem";
            this.saveModelAsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveModelAsToolStripMenuItem.Text = "Save model As...";
            this.saveModelAsToolStripMenuItem.Click += new System.EventHandler(this.saveModelAsToolStripMenuItem_Click);
            // 
            // loadModelToolStripMenuItem
            // 
            this.loadModelToolStripMenuItem.Name = "loadModelToolStripMenuItem";
            this.loadModelToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.loadModelToolStripMenuItem.Text = "Load model...";
            this.loadModelToolStripMenuItem.Click += new System.EventHandler(this.loadModelToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // groupBox_Algorithm
            // 
            this.groupBox_Algorithm.Controls.Add(this.button_StartAlgorithm);
            this.groupBox_Algorithm.Controls.Add(this.button_Iterate);
            this.groupBox_Algorithm.Controls.Add(this.numericUpDown_IterationsCount);
            this.groupBox_Algorithm.Controls.Add(this.button_Iteration);
            this.groupBox_Algorithm.Location = new System.Drawing.Point(3, 133);
            this.groupBox_Algorithm.Name = "groupBox_Algorithm";
            this.groupBox_Algorithm.Size = new System.Drawing.Size(116, 163);
            this.groupBox_Algorithm.TabIndex = 7;
            this.groupBox_Algorithm.TabStop = false;
            this.groupBox_Algorithm.Text = "Algorithm";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 486);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Controls.Add(this.menuStrip_MainMenu);
            this.Name = "GraphForm";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.GraphForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GraphForm_MouseClick);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.flowLayoutPanel_Tools.ResumeLayout(false);
            this.groupBox_NodeType.ResumeLayout(false);
            this.groupBox_NodeType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IterationsCount)).EndInit();
            this.menuStrip_MainMenu.ResumeLayout(false);
            this.menuStrip_MainMenu.PerformLayout();
            this.groupBox_Algorithm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Tools;
        private System.Windows.Forms.Button button_Redraw;
        private System.Windows.Forms.Panel panel_Drawing;
        private System.Windows.Forms.GroupBox groupBox_NodeType;
        private System.Windows.Forms.RadioButton radioButton_isConsumer;
        private System.Windows.Forms.RadioButton radioButton_isDepot;
        private System.Windows.Forms.Button button_AddNode;
        private System.Windows.Forms.Button button_StartAlgorithm;
        private System.Windows.Forms.Button button_Iteration;
        private System.Windows.Forms.NumericUpDown numericUpDown_IterationsCount;
        private System.Windows.Forms.Button button_Iterate;
        private System.Windows.Forms.MenuStrip menuStrip_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveModelAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_Algorithm;

    }
}

