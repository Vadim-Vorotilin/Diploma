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
            this.groupBox_Node = new System.Windows.Forms.GroupBox();
            this.radioButton_isConsumer = new System.Windows.Forms.RadioButton();
            this.radioButton_isDepot = new System.Windows.Forms.RadioButton();
            this.groupBox_Algorithm = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_Algorithm = new System.Windows.Forms.FlowLayoutPanel();
            this.label_ClustersCount = new System.Windows.Forms.Label();
            this.numericUpDown_ClustersCount = new System.Windows.Forms.NumericUpDown();
            this.label_Algorithm = new System.Windows.Forms.Label();
            this.comboBox_AlgorithmType = new System.Windows.Forms.ComboBox();
            this.button_StartAlgorithm = new System.Windows.Forms.Button();
            this.button_Iteration = new System.Windows.Forms.Button();
            this.numericUpDown_IterationsCount = new System.Windows.Forms.NumericUpDown();
            this.button_Iterate = new System.Windows.Forms.Button();
            this.panel_Drawing = new System.Windows.Forms.Panel();
            this.menuStrip_MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveModelAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Main = new System.Windows.Forms.ToolStripStatusLabel();
            this.numericUpDown_Volume = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel_Node = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Volume = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.flowLayoutPanel_Tools.SuspendLayout();
            this.groupBox_Node.SuspendLayout();
            this.groupBox_Algorithm.SuspendLayout();
            this.flowLayoutPanel_Algorithm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClustersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IterationsCount)).BeginInit();
            this.menuStrip_MainMenu.SuspendLayout();
            this.statusStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Volume)).BeginInit();
            this.flowLayoutPanel_Node.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 2;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel_Main.Controls.Add(this.flowLayoutPanel_Tools, 1, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.panel_Drawing, 0, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 3;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(927, 488);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // flowLayoutPanel_Tools
            // 
            this.flowLayoutPanel_Tools.Controls.Add(this.button_Redraw);
            this.flowLayoutPanel_Tools.Controls.Add(this.button_AddNode);
            this.flowLayoutPanel_Tools.Controls.Add(this.groupBox_Node);
            this.flowLayoutPanel_Tools.Controls.Add(this.groupBox_Algorithm);
            this.flowLayoutPanel_Tools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Tools.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Tools.Location = new System.Drawing.Point(782, 3);
            this.flowLayoutPanel_Tools.Name = "flowLayoutPanel_Tools";
            this.flowLayoutPanel_Tools.Size = new System.Drawing.Size(142, 424);
            this.flowLayoutPanel_Tools.TabIndex = 0;
            // 
            // button_Redraw
            // 
            this.button_Redraw.Location = new System.Drawing.Point(3, 3);
            this.button_Redraw.Name = "button_Redraw";
            this.button_Redraw.Size = new System.Drawing.Size(130, 23);
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
            this.button_AddNode.Size = new System.Drawing.Size(130, 23);
            this.button_AddNode.TabIndex = 2;
            this.button_AddNode.Text = "Add node";
            this.button_AddNode.UseVisualStyleBackColor = true;
            this.button_AddNode.Click += new System.EventHandler(this.button_AddNode_Click);
            // 
            // groupBox_Node
            // 
            this.groupBox_Node.Controls.Add(this.flowLayoutPanel_Node);
            this.groupBox_Node.Location = new System.Drawing.Point(3, 61);
            this.groupBox_Node.Name = "groupBox_Node";
            this.groupBox_Node.Size = new System.Drawing.Size(130, 117);
            this.groupBox_Node.TabIndex = 1;
            this.groupBox_Node.TabStop = false;
            this.groupBox_Node.Text = "Node";
            // 
            // radioButton_isConsumer
            // 
            this.radioButton_isConsumer.AutoSize = true;
            this.radioButton_isConsumer.Checked = true;
            this.radioButton_isConsumer.Location = new System.Drawing.Point(3, 26);
            this.radioButton_isConsumer.Name = "radioButton_isConsumer";
            this.radioButton_isConsumer.Size = new System.Drawing.Size(72, 17);
            this.radioButton_isConsumer.TabIndex = 1;
            this.radioButton_isConsumer.TabStop = true;
            this.radioButton_isConsumer.Text = "Consumer";
            this.radioButton_isConsumer.UseVisualStyleBackColor = true;
            this.radioButton_isConsumer.CheckedChanged += new System.EventHandler(this.radioButton_isConsumer_CheckedChanged);
            // 
            // radioButton_isDepot
            // 
            this.radioButton_isDepot.AutoSize = true;
            this.radioButton_isDepot.Location = new System.Drawing.Point(3, 3);
            this.radioButton_isDepot.Name = "radioButton_isDepot";
            this.radioButton_isDepot.Size = new System.Drawing.Size(54, 17);
            this.radioButton_isDepot.TabIndex = 0;
            this.radioButton_isDepot.Text = "Depot";
            this.radioButton_isDepot.UseVisualStyleBackColor = true;
            // 
            // groupBox_Algorithm
            // 
            this.groupBox_Algorithm.Controls.Add(this.flowLayoutPanel_Algorithm);
            this.groupBox_Algorithm.Location = new System.Drawing.Point(3, 184);
            this.groupBox_Algorithm.Name = "groupBox_Algorithm";
            this.groupBox_Algorithm.Size = new System.Drawing.Size(130, 214);
            this.groupBox_Algorithm.TabIndex = 7;
            this.groupBox_Algorithm.TabStop = false;
            this.groupBox_Algorithm.Text = "Algorithm";
            // 
            // flowLayoutPanel_Algorithm
            // 
            this.flowLayoutPanel_Algorithm.Controls.Add(this.label_ClustersCount);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.numericUpDown_ClustersCount);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.label_Algorithm);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.comboBox_AlgorithmType);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.button_StartAlgorithm);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.button_Iteration);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.numericUpDown_IterationsCount);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.button_Iterate);
            this.flowLayoutPanel_Algorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Algorithm.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Algorithm.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel_Algorithm.Name = "flowLayoutPanel_Algorithm";
            this.flowLayoutPanel_Algorithm.Size = new System.Drawing.Size(124, 195);
            this.flowLayoutPanel_Algorithm.TabIndex = 8;
            // 
            // label_ClustersCount
            // 
            this.label_ClustersCount.AutoSize = true;
            this.label_ClustersCount.Location = new System.Drawing.Point(3, 0);
            this.label_ClustersCount.Name = "label_ClustersCount";
            this.label_ClustersCount.Size = new System.Drawing.Size(74, 13);
            this.label_ClustersCount.TabIndex = 8;
            this.label_ClustersCount.Text = "Clusters count";
            // 
            // numericUpDown_ClustersCount
            // 
            this.numericUpDown_ClustersCount.Location = new System.Drawing.Point(3, 16);
            this.numericUpDown_ClustersCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ClustersCount.Name = "numericUpDown_ClustersCount";
            this.numericUpDown_ClustersCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_ClustersCount.TabIndex = 9;
            this.numericUpDown_ClustersCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label_Algorithm
            // 
            this.label_Algorithm.AutoSize = true;
            this.label_Algorithm.Location = new System.Drawing.Point(3, 39);
            this.label_Algorithm.Name = "label_Algorithm";
            this.label_Algorithm.Size = new System.Drawing.Size(50, 13);
            this.label_Algorithm.TabIndex = 10;
            this.label_Algorithm.Text = "Algorithm";
            // 
            // comboBox_AlgorithmType
            // 
            this.comboBox_AlgorithmType.FormattingEnabled = true;
            this.comboBox_AlgorithmType.Items.AddRange(new object[] {
            "Bees VRP -> TSP",
            "Bees CLUSTERING",
            "K-means CLUSTERING"});
            this.comboBox_AlgorithmType.Location = new System.Drawing.Point(3, 55);
            this.comboBox_AlgorithmType.Name = "comboBox_AlgorithmType";
            this.comboBox_AlgorithmType.Size = new System.Drawing.Size(117, 21);
            this.comboBox_AlgorithmType.TabIndex = 7;
            // 
            // button_StartAlgorithm
            // 
            this.button_StartAlgorithm.Location = new System.Drawing.Point(3, 82);
            this.button_StartAlgorithm.Name = "button_StartAlgorithm";
            this.button_StartAlgorithm.Size = new System.Drawing.Size(118, 23);
            this.button_StartAlgorithm.TabIndex = 3;
            this.button_StartAlgorithm.Text = "Start";
            this.button_StartAlgorithm.UseVisualStyleBackColor = true;
            this.button_StartAlgorithm.Click += new System.EventHandler(this.button_StartAlgorithm_Click);
            // 
            // button_Iteration
            // 
            this.button_Iteration.Location = new System.Drawing.Point(3, 111);
            this.button_Iteration.Name = "button_Iteration";
            this.button_Iteration.Size = new System.Drawing.Size(118, 23);
            this.button_Iteration.TabIndex = 4;
            this.button_Iteration.Text = "Iteration";
            this.button_Iteration.UseVisualStyleBackColor = true;
            this.button_Iteration.Click += new System.EventHandler(this.button_Iteration_Click);
            // 
            // numericUpDown_IterationsCount
            // 
            this.numericUpDown_IterationsCount.Location = new System.Drawing.Point(3, 140);
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
            this.numericUpDown_IterationsCount.Size = new System.Drawing.Size(118, 20);
            this.numericUpDown_IterationsCount.TabIndex = 5;
            this.numericUpDown_IterationsCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_Iterate
            // 
            this.button_Iterate.Location = new System.Drawing.Point(3, 166);
            this.button_Iterate.Name = "button_Iterate";
            this.button_Iterate.Size = new System.Drawing.Size(118, 23);
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
            this.panel_Drawing.Size = new System.Drawing.Size(773, 424);
            this.panel_Drawing.TabIndex = 1;
            this.panel_Drawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Drawing_MouseClick);
            // 
            // menuStrip_MainMenu
            // 
            this.menuStrip_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MainMenu.Name = "menuStrip_MainMenu";
            this.menuStrip_MainMenu.Size = new System.Drawing.Size(927, 24);
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
            this.newModelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newModelToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.newModelToolStripMenuItem.Text = "New model";
            this.newModelToolStripMenuItem.Click += new System.EventHandler(this.newModelToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // saveModelToolStripMenuItem
            // 
            this.saveModelToolStripMenuItem.Name = "saveModelToolStripMenuItem";
            this.saveModelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveModelToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
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
            // statusStrip_Main
            // 
            this.statusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Main});
            this.statusStrip_Main.Location = new System.Drawing.Point(0, 490);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(927, 22);
            this.statusStrip_Main.TabIndex = 2;
            this.statusStrip_Main.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Main
            // 
            this.toolStripStatusLabel_Main.Name = "toolStripStatusLabel_Main";
            this.toolStripStatusLabel_Main.Size = new System.Drawing.Size(0, 17);
            // 
            // numericUpDown_Volume
            // 
            this.numericUpDown_Volume.Location = new System.Drawing.Point(3, 67);
            this.numericUpDown_Volume.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Volume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Volume.Name = "numericUpDown_Volume";
            this.numericUpDown_Volume.Size = new System.Drawing.Size(114, 20);
            this.numericUpDown_Volume.TabIndex = 2;
            this.numericUpDown_Volume.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flowLayoutPanel_Node
            // 
            this.flowLayoutPanel_Node.Controls.Add(this.radioButton_isDepot);
            this.flowLayoutPanel_Node.Controls.Add(this.radioButton_isConsumer);
            this.flowLayoutPanel_Node.Controls.Add(this.label_Volume);
            this.flowLayoutPanel_Node.Controls.Add(this.numericUpDown_Volume);
            this.flowLayoutPanel_Node.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Node.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Node.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel_Node.Name = "flowLayoutPanel_Node";
            this.flowLayoutPanel_Node.Size = new System.Drawing.Size(124, 98);
            this.flowLayoutPanel_Node.TabIndex = 3;
            // 
            // label_Volume
            // 
            this.label_Volume.AutoSize = true;
            this.label_Volume.Location = new System.Drawing.Point(3, 51);
            this.label_Volume.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label_Volume.Name = "label_Volume";
            this.label_Volume.Size = new System.Drawing.Size(42, 13);
            this.label_Volume.TabIndex = 3;
            this.label_Volume.Text = "Volume";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 512);
            this.Controls.Add(this.statusStrip_Main);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Controls.Add(this.menuStrip_MainMenu);
            this.Name = "GraphForm";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.GraphForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GraphForm_MouseClick);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.flowLayoutPanel_Tools.ResumeLayout(false);
            this.groupBox_Node.ResumeLayout(false);
            this.groupBox_Algorithm.ResumeLayout(false);
            this.flowLayoutPanel_Algorithm.ResumeLayout(false);
            this.flowLayoutPanel_Algorithm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClustersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IterationsCount)).EndInit();
            this.menuStrip_MainMenu.ResumeLayout(false);
            this.menuStrip_MainMenu.PerformLayout();
            this.statusStrip_Main.ResumeLayout(false);
            this.statusStrip_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Volume)).EndInit();
            this.flowLayoutPanel_Node.ResumeLayout(false);
            this.flowLayoutPanel_Node.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Tools;
        private System.Windows.Forms.Button button_Redraw;
        private System.Windows.Forms.Panel panel_Drawing;
        private System.Windows.Forms.GroupBox groupBox_Node;
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
        private System.Windows.Forms.ComboBox comboBox_AlgorithmType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Algorithm;
        private System.Windows.Forms.Label label_ClustersCount;
        private System.Windows.Forms.NumericUpDown numericUpDown_ClustersCount;
        private System.Windows.Forms.Label label_Algorithm;
        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Main;
        private System.Windows.Forms.NumericUpDown numericUpDown_Volume;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Node;
        private System.Windows.Forms.Label label_Volume;

    }
}

