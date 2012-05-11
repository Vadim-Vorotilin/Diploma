﻿namespace Diploma
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
            this.groupBox_Generation = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_Generation = new System.Windows.Forms.FlowLayoutPanel();
            this.label_GeneratingCount = new System.Windows.Forms.Label();
            this.numericUpDown_GeneratingCount = new System.Windows.Forms.NumericUpDown();
            this.label_GeneratingVolume = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_GeneratingVolumeFrom = new System.Windows.Forms.Label();
            this.label_GeneratingVolumeTo = new System.Windows.Forms.Label();
            this.numericUpDown_GeneratingVolumeFrom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_GeneratingVolumeTo = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Node = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_Node = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Volume = new System.Windows.Forms.Label();
            this.numericUpDown_Volume = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Algorithm = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_Algorithm = new System.Windows.Forms.FlowLayoutPanel();
            this.label_ClustersCount = new System.Windows.Forms.Label();
            this.numericUpDown_ClustersCount = new System.Windows.Forms.NumericUpDown();
            this.label_ClusterCapacityLimit = new System.Windows.Forms.Label();
            this.numericUpDown_ClusterCapacityLimit = new System.Windows.Forms.NumericUpDown();
            this.label_Algorithm = new System.Windows.Forms.Label();
            this.comboBox_AlgorithmType = new System.Windows.Forms.ComboBox();
            this.button_StartAlgorithm = new System.Windows.Forms.Button();
            this.button_Iteration = new System.Windows.Forms.Button();
            this.numericUpDown_IterationsCount = new System.Windows.Forms.NumericUpDown();
            this.button_Iterate = new System.Windows.Forms.Button();
            this.button_IterateToStop = new System.Windows.Forms.Button();
            this.button_CalculateTsp = new System.Windows.Forms.Button();
            this.checkBox_LastChangedIteration = new System.Windows.Forms.CheckBox();
            this.label_LogFileName = new System.Windows.Forms.Label();
            this.textBox_LogFileName = new System.Windows.Forms.TextBox();
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
            this.button_Generate = new System.Windows.Forms.Button();
            this.groupBox_Options = new System.Windows.Forms.GroupBox();
            this.checkBox_WithDepot = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.flowLayoutPanel_Tools.SuspendLayout();
            this.groupBox_Generation.SuspendLayout();
            this.flowLayoutPanel_Generation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GeneratingCount)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GeneratingVolumeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GeneratingVolumeTo)).BeginInit();
            this.groupBox_Node.SuspendLayout();
            this.flowLayoutPanel_Node.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Volume)).BeginInit();
            this.groupBox_Algorithm.SuspendLayout();
            this.flowLayoutPanel_Algorithm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClustersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClusterCapacityLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IterationsCount)).BeginInit();
            this.menuStrip_MainMenu.SuspendLayout();
            this.statusStrip_Main.SuspendLayout();
            this.groupBox_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 2;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.tableLayoutPanel_Main.Controls.Add(this.panel_Drawing, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.groupBox_Options, 1, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 3;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1006, 575);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // flowLayoutPanel_Tools
            // 
            this.flowLayoutPanel_Tools.Controls.Add(this.button_Redraw);
            this.flowLayoutPanel_Tools.Controls.Add(this.groupBox_Generation);
            this.flowLayoutPanel_Tools.Controls.Add(this.groupBox_Node);
            this.flowLayoutPanel_Tools.Controls.Add(this.label_LogFileName);
            this.flowLayoutPanel_Tools.Controls.Add(this.textBox_LogFileName);
            this.flowLayoutPanel_Tools.Controls.Add(this.groupBox_Algorithm);
            this.flowLayoutPanel_Tools.Controls.Add(this.checkBox_LastChangedIteration);
            this.flowLayoutPanel_Tools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Tools.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Tools.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel_Tools.Name = "flowLayoutPanel_Tools";
            this.flowLayoutPanel_Tools.Size = new System.Drawing.Size(273, 492);
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
            // groupBox_Generation
            // 
            this.groupBox_Generation.Controls.Add(this.flowLayoutPanel_Generation);
            this.groupBox_Generation.Location = new System.Drawing.Point(3, 32);
            this.groupBox_Generation.Name = "groupBox_Generation";
            this.groupBox_Generation.Size = new System.Drawing.Size(130, 191);
            this.groupBox_Generation.TabIndex = 11;
            this.groupBox_Generation.TabStop = false;
            this.groupBox_Generation.Text = "Generation";
            // 
            // flowLayoutPanel_Generation
            // 
            this.flowLayoutPanel_Generation.Controls.Add(this.label_GeneratingCount);
            this.flowLayoutPanel_Generation.Controls.Add(this.numericUpDown_GeneratingCount);
            this.flowLayoutPanel_Generation.Controls.Add(this.label_GeneratingVolume);
            this.flowLayoutPanel_Generation.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel_Generation.Controls.Add(this.checkBox_WithDepot);
            this.flowLayoutPanel_Generation.Controls.Add(this.button_Generate);
            this.flowLayoutPanel_Generation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Generation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Generation.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel_Generation.Name = "flowLayoutPanel_Generation";
            this.flowLayoutPanel_Generation.Size = new System.Drawing.Size(124, 172);
            this.flowLayoutPanel_Generation.TabIndex = 0;
            // 
            // label_GeneratingCount
            // 
            this.label_GeneratingCount.AutoSize = true;
            this.label_GeneratingCount.Location = new System.Drawing.Point(3, 5);
            this.label_GeneratingCount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label_GeneratingCount.Name = "label_GeneratingCount";
            this.label_GeneratingCount.Size = new System.Drawing.Size(35, 13);
            this.label_GeneratingCount.TabIndex = 0;
            this.label_GeneratingCount.Text = "Count";
            // 
            // numericUpDown_GeneratingCount
            // 
            this.numericUpDown_GeneratingCount.Location = new System.Drawing.Point(3, 21);
            this.numericUpDown_GeneratingCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_GeneratingCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_GeneratingCount.Name = "numericUpDown_GeneratingCount";
            this.numericUpDown_GeneratingCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_GeneratingCount.TabIndex = 1;
            this.numericUpDown_GeneratingCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_GeneratingVolume
            // 
            this.label_GeneratingVolume.AutoSize = true;
            this.label_GeneratingVolume.Location = new System.Drawing.Point(3, 49);
            this.label_GeneratingVolume.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label_GeneratingVolume.Name = "label_GeneratingVolume";
            this.label_GeneratingVolume.Size = new System.Drawing.Size(42, 13);
            this.label_GeneratingVolume.TabIndex = 2;
            this.label_GeneratingVolume.Text = "Volume";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_GeneratingVolumeFrom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_GeneratingVolumeTo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_GeneratingVolumeFrom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_GeneratingVolumeTo, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(123, 42);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label_GeneratingVolumeFrom
            // 
            this.label_GeneratingVolumeFrom.AutoSize = true;
            this.label_GeneratingVolumeFrom.Location = new System.Drawing.Point(3, 0);
            this.label_GeneratingVolumeFrom.Name = "label_GeneratingVolumeFrom";
            this.label_GeneratingVolumeFrom.Size = new System.Drawing.Size(30, 13);
            this.label_GeneratingVolumeFrom.TabIndex = 0;
            this.label_GeneratingVolumeFrom.Text = "From";
            // 
            // label_GeneratingVolumeTo
            // 
            this.label_GeneratingVolumeTo.AutoSize = true;
            this.label_GeneratingVolumeTo.Location = new System.Drawing.Point(64, 0);
            this.label_GeneratingVolumeTo.Name = "label_GeneratingVolumeTo";
            this.label_GeneratingVolumeTo.Size = new System.Drawing.Size(20, 13);
            this.label_GeneratingVolumeTo.TabIndex = 1;
            this.label_GeneratingVolumeTo.Text = "To";
            // 
            // numericUpDown_GeneratingVolumeFrom
            // 
            this.numericUpDown_GeneratingVolumeFrom.Location = new System.Drawing.Point(3, 17);
            this.numericUpDown_GeneratingVolumeFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_GeneratingVolumeFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_GeneratingVolumeFrom.Name = "numericUpDown_GeneratingVolumeFrom";
            this.numericUpDown_GeneratingVolumeFrom.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_GeneratingVolumeFrom.TabIndex = 2;
            this.numericUpDown_GeneratingVolumeFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_GeneratingVolumeTo
            // 
            this.numericUpDown_GeneratingVolumeTo.Location = new System.Drawing.Point(64, 17);
            this.numericUpDown_GeneratingVolumeTo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_GeneratingVolumeTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_GeneratingVolumeTo.Name = "numericUpDown_GeneratingVolumeTo";
            this.numericUpDown_GeneratingVolumeTo.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown_GeneratingVolumeTo.TabIndex = 3;
            this.numericUpDown_GeneratingVolumeTo.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // groupBox_Node
            // 
            this.groupBox_Node.Controls.Add(this.flowLayoutPanel_Node);
            this.groupBox_Node.Location = new System.Drawing.Point(3, 229);
            this.groupBox_Node.Name = "groupBox_Node";
            this.groupBox_Node.Size = new System.Drawing.Size(130, 68);
            this.groupBox_Node.TabIndex = 1;
            this.groupBox_Node.TabStop = false;
            this.groupBox_Node.Text = "Node";
            // 
            // flowLayoutPanel_Node
            // 
            this.flowLayoutPanel_Node.Controls.Add(this.label_Volume);
            this.flowLayoutPanel_Node.Controls.Add(this.numericUpDown_Volume);
            this.flowLayoutPanel_Node.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Node.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Node.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel_Node.Name = "flowLayoutPanel_Node";
            this.flowLayoutPanel_Node.Size = new System.Drawing.Size(124, 49);
            this.flowLayoutPanel_Node.TabIndex = 3;
            // 
            // label_Volume
            // 
            this.label_Volume.AutoSize = true;
            this.label_Volume.Location = new System.Drawing.Point(3, 5);
            this.label_Volume.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label_Volume.Name = "label_Volume";
            this.label_Volume.Size = new System.Drawing.Size(42, 13);
            this.label_Volume.TabIndex = 3;
            this.label_Volume.Text = "Volume";
            // 
            // numericUpDown_Volume
            // 
            this.numericUpDown_Volume.Location = new System.Drawing.Point(3, 21);
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
            this.numericUpDown_Volume.Size = new System.Drawing.Size(118, 20);
            this.numericUpDown_Volume.TabIndex = 2;
            this.numericUpDown_Volume.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox_Algorithm
            // 
            this.groupBox_Algorithm.Controls.Add(this.flowLayoutPanel_Algorithm);
            this.groupBox_Algorithm.Location = new System.Drawing.Point(139, 3);
            this.groupBox_Algorithm.Name = "groupBox_Algorithm";
            this.groupBox_Algorithm.Size = new System.Drawing.Size(130, 317);
            this.groupBox_Algorithm.TabIndex = 7;
            this.groupBox_Algorithm.TabStop = false;
            this.groupBox_Algorithm.Text = "Algorithm";
            // 
            // flowLayoutPanel_Algorithm
            // 
            this.flowLayoutPanel_Algorithm.Controls.Add(this.label_ClustersCount);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.numericUpDown_ClustersCount);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.label_ClusterCapacityLimit);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.numericUpDown_ClusterCapacityLimit);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.label_Algorithm);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.comboBox_AlgorithmType);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.button_StartAlgorithm);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.button_Iteration);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.numericUpDown_IterationsCount);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.button_Iterate);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.button_IterateToStop);
            this.flowLayoutPanel_Algorithm.Controls.Add(this.button_CalculateTsp);
            this.flowLayoutPanel_Algorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Algorithm.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Algorithm.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel_Algorithm.Name = "flowLayoutPanel_Algorithm";
            this.flowLayoutPanel_Algorithm.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowLayoutPanel_Algorithm.Size = new System.Drawing.Size(124, 298);
            this.flowLayoutPanel_Algorithm.TabIndex = 8;
            // 
            // label_ClustersCount
            // 
            this.label_ClustersCount.AutoSize = true;
            this.label_ClustersCount.Location = new System.Drawing.Point(3, 5);
            this.label_ClustersCount.Name = "label_ClustersCount";
            this.label_ClustersCount.Size = new System.Drawing.Size(74, 13);
            this.label_ClustersCount.TabIndex = 8;
            this.label_ClustersCount.Text = "Clusters count";
            // 
            // numericUpDown_ClustersCount
            // 
            this.numericUpDown_ClustersCount.Location = new System.Drawing.Point(3, 21);
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
            // label_ClusterCapacityLimit
            // 
            this.label_ClusterCapacityLimit.AutoSize = true;
            this.label_ClusterCapacityLimit.Location = new System.Drawing.Point(3, 44);
            this.label_ClusterCapacityLimit.Name = "label_ClusterCapacityLimit";
            this.label_ClusterCapacityLimit.Size = new System.Drawing.Size(28, 13);
            this.label_ClusterCapacityLimit.TabIndex = 12;
            this.label_ClusterCapacityLimit.Text = "Limit";
            // 
            // numericUpDown_ClusterCapacityLimit
            // 
            this.numericUpDown_ClusterCapacityLimit.Location = new System.Drawing.Point(3, 60);
            this.numericUpDown_ClusterCapacityLimit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_ClusterCapacityLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ClusterCapacityLimit.Name = "numericUpDown_ClusterCapacityLimit";
            this.numericUpDown_ClusterCapacityLimit.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_ClusterCapacityLimit.TabIndex = 11;
            this.numericUpDown_ClusterCapacityLimit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_Algorithm
            // 
            this.label_Algorithm.AutoSize = true;
            this.label_Algorithm.Location = new System.Drawing.Point(3, 83);
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
            "Bees CLUST w/ LIMIT",
            "K-means CLUSTERING",
            "NearNeighChain"});
            this.comboBox_AlgorithmType.Location = new System.Drawing.Point(3, 99);
            this.comboBox_AlgorithmType.Name = "comboBox_AlgorithmType";
            this.comboBox_AlgorithmType.Size = new System.Drawing.Size(117, 21);
            this.comboBox_AlgorithmType.TabIndex = 7;
            // 
            // button_StartAlgorithm
            // 
            this.button_StartAlgorithm.Location = new System.Drawing.Point(3, 126);
            this.button_StartAlgorithm.Name = "button_StartAlgorithm";
            this.button_StartAlgorithm.Size = new System.Drawing.Size(118, 23);
            this.button_StartAlgorithm.TabIndex = 3;
            this.button_StartAlgorithm.Text = "Start";
            this.button_StartAlgorithm.UseVisualStyleBackColor = true;
            this.button_StartAlgorithm.Click += new System.EventHandler(this.button_StartAlgorithm_Click);
            // 
            // button_Iteration
            // 
            this.button_Iteration.Location = new System.Drawing.Point(3, 155);
            this.button_Iteration.Name = "button_Iteration";
            this.button_Iteration.Size = new System.Drawing.Size(118, 23);
            this.button_Iteration.TabIndex = 4;
            this.button_Iteration.Text = "Iteration";
            this.button_Iteration.UseVisualStyleBackColor = true;
            this.button_Iteration.Click += new System.EventHandler(this.button_Iteration_Click);
            // 
            // numericUpDown_IterationsCount
            // 
            this.numericUpDown_IterationsCount.Location = new System.Drawing.Point(3, 184);
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
            this.button_Iterate.Location = new System.Drawing.Point(3, 210);
            this.button_Iterate.Name = "button_Iterate";
            this.button_Iterate.Size = new System.Drawing.Size(118, 23);
            this.button_Iterate.TabIndex = 6;
            this.button_Iterate.Text = "Iterate";
            this.button_Iterate.UseVisualStyleBackColor = true;
            this.button_Iterate.Click += new System.EventHandler(this.button_Iterate_Click);
            // 
            // button_IterateToStop
            // 
            this.button_IterateToStop.Location = new System.Drawing.Point(3, 239);
            this.button_IterateToStop.Name = "button_IterateToStop";
            this.button_IterateToStop.Size = new System.Drawing.Size(117, 23);
            this.button_IterateToStop.TabIndex = 13;
            this.button_IterateToStop.Text = "Iterate to stop";
            this.button_IterateToStop.UseVisualStyleBackColor = true;
            this.button_IterateToStop.Click += new System.EventHandler(this.button_IterateToStop_Click);
            // 
            // button_CalculateTsp
            // 
            this.button_CalculateTsp.Location = new System.Drawing.Point(3, 268);
            this.button_CalculateTsp.Name = "button_CalculateTsp";
            this.button_CalculateTsp.Size = new System.Drawing.Size(117, 23);
            this.button_CalculateTsp.TabIndex = 14;
            this.button_CalculateTsp.Text = "Calc TSP";
            this.button_CalculateTsp.UseVisualStyleBackColor = true;
            this.button_CalculateTsp.Click += new System.EventHandler(this.button_CalculateTsp_Click);
            // 
            // checkBox_LastChangedIteration
            // 
            this.checkBox_LastChangedIteration.AutoSize = true;
            this.checkBox_LastChangedIteration.Checked = true;
            this.checkBox_LastChangedIteration.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LastChangedIteration.Location = new System.Drawing.Point(139, 326);
            this.checkBox_LastChangedIteration.Name = "checkBox_LastChangedIteration";
            this.checkBox_LastChangedIteration.Size = new System.Drawing.Size(105, 17);
            this.checkBox_LastChangedIteration.TabIndex = 8;
            this.checkBox_LastChangedIteration.Text = "Calc last change";
            this.checkBox_LastChangedIteration.UseVisualStyleBackColor = true;
            // 
            // label_LogFileName
            // 
            this.label_LogFileName.AutoSize = true;
            this.label_LogFileName.Location = new System.Drawing.Point(3, 300);
            this.label_LogFileName.Name = "label_LogFileName";
            this.label_LogFileName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label_LogFileName.Size = new System.Drawing.Size(41, 16);
            this.label_LogFileName.TabIndex = 10;
            this.label_LogFileName.Text = "Log file";
            // 
            // textBox_LogFileName
            // 
            this.textBox_LogFileName.Location = new System.Drawing.Point(3, 319);
            this.textBox_LogFileName.Name = "textBox_LogFileName";
            this.textBox_LogFileName.Size = new System.Drawing.Size(127, 20);
            this.textBox_LogFileName.TabIndex = 9;
            this.textBox_LogFileName.Text = "..\\..\\..\\Models\\log.txt";
            // 
            // panel_Drawing
            // 
            this.panel_Drawing.BackColor = System.Drawing.Color.White;
            this.panel_Drawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Drawing.Location = new System.Drawing.Point(3, 3);
            this.panel_Drawing.Name = "panel_Drawing";
            this.panel_Drawing.Size = new System.Drawing.Size(715, 511);
            this.panel_Drawing.TabIndex = 1;
            this.panel_Drawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Drawing_MouseClick);
            // 
            // menuStrip_MainMenu
            // 
            this.menuStrip_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MainMenu.Name = "menuStrip_MainMenu";
            this.menuStrip_MainMenu.Size = new System.Drawing.Size(1006, 24);
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
            this.newModelToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.newModelToolStripMenuItem.Text = "New model";
            this.newModelToolStripMenuItem.Click += new System.EventHandler(this.newModelToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
            // 
            // saveModelToolStripMenuItem
            // 
            this.saveModelToolStripMenuItem.Name = "saveModelToolStripMenuItem";
            this.saveModelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveModelToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.saveModelToolStripMenuItem.Text = "Save model";
            this.saveModelToolStripMenuItem.Click += new System.EventHandler(this.saveModelToolStripMenuItem_Click);
            // 
            // saveModelAsToolStripMenuItem
            // 
            this.saveModelAsToolStripMenuItem.Name = "saveModelAsToolStripMenuItem";
            this.saveModelAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.S)));
            this.saveModelAsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.saveModelAsToolStripMenuItem.Text = "Save model As...";
            this.saveModelAsToolStripMenuItem.Click += new System.EventHandler(this.saveModelAsToolStripMenuItem_Click);
            // 
            // loadModelToolStripMenuItem
            // 
            this.loadModelToolStripMenuItem.Name = "loadModelToolStripMenuItem";
            this.loadModelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadModelToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.loadModelToolStripMenuItem.Text = "Load model...";
            this.loadModelToolStripMenuItem.Click += new System.EventHandler(this.loadModelToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Main});
            this.statusStrip_Main.Location = new System.Drawing.Point(0, 577);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(1006, 22);
            this.statusStrip_Main.TabIndex = 2;
            this.statusStrip_Main.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Main
            // 
            this.toolStripStatusLabel_Main.Name = "toolStripStatusLabel_Main";
            this.toolStripStatusLabel_Main.Size = new System.Drawing.Size(0, 17);
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(3, 135);
            this.button_Generate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(118, 23);
            this.button_Generate.TabIndex = 4;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // groupBox_Options
            // 
            this.groupBox_Options.Controls.Add(this.flowLayoutPanel_Tools);
            this.groupBox_Options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Options.Location = new System.Drawing.Point(724, 3);
            this.groupBox_Options.Name = "groupBox_Options";
            this.groupBox_Options.Size = new System.Drawing.Size(279, 511);
            this.groupBox_Options.TabIndex = 2;
            this.groupBox_Options.TabStop = false;
            // 
            // checkBox_WithDepot
            // 
            this.checkBox_WithDepot.AutoSize = true;
            this.checkBox_WithDepot.Location = new System.Drawing.Point(3, 110);
            this.checkBox_WithDepot.Name = "checkBox_WithDepot";
            this.checkBox_WithDepot.Size = new System.Drawing.Size(78, 17);
            this.checkBox_WithDepot.TabIndex = 5;
            this.checkBox_WithDepot.Text = "With depot";
            this.checkBox_WithDepot.UseVisualStyleBackColor = true;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 599);
            this.Controls.Add(this.statusStrip_Main);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Controls.Add(this.menuStrip_MainMenu);
            this.Name = "GraphForm";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.GraphForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GraphForm_MouseClick);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.flowLayoutPanel_Tools.ResumeLayout(false);
            this.flowLayoutPanel_Tools.PerformLayout();
            this.groupBox_Generation.ResumeLayout(false);
            this.flowLayoutPanel_Generation.ResumeLayout(false);
            this.flowLayoutPanel_Generation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GeneratingCount)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GeneratingVolumeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GeneratingVolumeTo)).EndInit();
            this.groupBox_Node.ResumeLayout(false);
            this.flowLayoutPanel_Node.ResumeLayout(false);
            this.flowLayoutPanel_Node.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Volume)).EndInit();
            this.groupBox_Algorithm.ResumeLayout(false);
            this.flowLayoutPanel_Algorithm.ResumeLayout(false);
            this.flowLayoutPanel_Algorithm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClustersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClusterCapacityLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IterationsCount)).EndInit();
            this.menuStrip_MainMenu.ResumeLayout(false);
            this.menuStrip_MainMenu.PerformLayout();
            this.statusStrip_Main.ResumeLayout(false);
            this.statusStrip_Main.PerformLayout();
            this.groupBox_Options.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Tools;
        private System.Windows.Forms.Button button_Redraw;
        private System.Windows.Forms.Panel panel_Drawing;
        private System.Windows.Forms.GroupBox groupBox_Node;
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
        private System.Windows.Forms.Label label_ClusterCapacityLimit;
        private System.Windows.Forms.NumericUpDown numericUpDown_ClusterCapacityLimit;
        private System.Windows.Forms.CheckBox checkBox_LastChangedIteration;
        private System.Windows.Forms.Label label_LogFileName;
        private System.Windows.Forms.TextBox textBox_LogFileName;
        private System.Windows.Forms.Button button_IterateToStop;
        private System.Windows.Forms.Button button_CalculateTsp;
        private System.Windows.Forms.GroupBox groupBox_Generation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Generation;
        private System.Windows.Forms.Label label_GeneratingCount;
        private System.Windows.Forms.NumericUpDown numericUpDown_GeneratingCount;
        private System.Windows.Forms.Label label_GeneratingVolume;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_GeneratingVolumeFrom;
        private System.Windows.Forms.Label label_GeneratingVolumeTo;
        private System.Windows.Forms.NumericUpDown numericUpDown_GeneratingVolumeFrom;
        private System.Windows.Forms.NumericUpDown numericUpDown_GeneratingVolumeTo;
        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.GroupBox groupBox_Options;
        private System.Windows.Forms.CheckBox checkBox_WithDepot;

    }
}

