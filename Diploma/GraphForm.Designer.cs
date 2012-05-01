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
            this.panel_Drawing = new System.Windows.Forms.Panel();
            this.groupBox_NodeType = new System.Windows.Forms.GroupBox();
            this.radioButton_isDepot = new System.Windows.Forms.RadioButton();
            this.radioButton_isConsumer = new System.Windows.Forms.RadioButton();
            this.button_AddNode = new System.Windows.Forms.Button();
            this.button_CreateColony = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.flowLayoutPanel_Tools.SuspendLayout();
            this.groupBox_NodeType.SuspendLayout();
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
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 2;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(861, 486);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // flowLayoutPanel_Tools
            // 
            this.flowLayoutPanel_Tools.Controls.Add(this.button_Redraw);
            this.flowLayoutPanel_Tools.Controls.Add(this.button_AddNode);
            this.flowLayoutPanel_Tools.Controls.Add(this.groupBox_NodeType);
            this.flowLayoutPanel_Tools.Controls.Add(this.button_CreateColony);
            this.flowLayoutPanel_Tools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Tools.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Tools.Location = new System.Drawing.Point(730, 3);
            this.flowLayoutPanel_Tools.Name = "flowLayoutPanel_Tools";
            this.flowLayoutPanel_Tools.Size = new System.Drawing.Size(128, 446);
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
            // panel_Drawing
            // 
            this.panel_Drawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Drawing.Location = new System.Drawing.Point(3, 3);
            this.panel_Drawing.Name = "panel_Drawing";
            this.panel_Drawing.Size = new System.Drawing.Size(721, 446);
            this.panel_Drawing.TabIndex = 1;
            this.panel_Drawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Drawing_MouseClick);
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
            // radioButton_isDepot
            // 
            this.radioButton_isDepot.AutoSize = true;
            this.radioButton_isDepot.Checked = true;
            this.radioButton_isDepot.Location = new System.Drawing.Point(7, 20);
            this.radioButton_isDepot.Name = "radioButton_isDepot";
            this.radioButton_isDepot.Size = new System.Drawing.Size(54, 17);
            this.radioButton_isDepot.TabIndex = 0;
            this.radioButton_isDepot.TabStop = true;
            this.radioButton_isDepot.Text = "Depot";
            this.radioButton_isDepot.UseVisualStyleBackColor = true;
            // 
            // radioButton_isConsumer
            // 
            this.radioButton_isConsumer.AutoSize = true;
            this.radioButton_isConsumer.Location = new System.Drawing.Point(7, 43);
            this.radioButton_isConsumer.Name = "radioButton_isConsumer";
            this.radioButton_isConsumer.Size = new System.Drawing.Size(72, 17);
            this.radioButton_isConsumer.TabIndex = 1;
            this.radioButton_isConsumer.Text = "Consumer";
            this.radioButton_isConsumer.UseVisualStyleBackColor = true;
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
            // button_CreateColony
            // 
            this.button_CreateColony.Location = new System.Drawing.Point(3, 133);
            this.button_CreateColony.Name = "button_CreateColony";
            this.button_CreateColony.Size = new System.Drawing.Size(116, 23);
            this.button_CreateColony.TabIndex = 3;
            this.button_CreateColony.Text = "Create colony";
            this.button_CreateColony.UseVisualStyleBackColor = true;
            this.button_CreateColony.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_CreateColony_MouseClick);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 486);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Name = "GraphForm";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.GraphForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GraphForm_MouseClick);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.flowLayoutPanel_Tools.ResumeLayout(false);
            this.groupBox_NodeType.ResumeLayout(false);
            this.groupBox_NodeType.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button_CreateColony;

    }
}

