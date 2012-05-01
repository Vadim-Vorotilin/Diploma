using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diploma
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            TaskController.GraphicsForDraw = panel_Drawing.CreateGraphics();
        }

        private void GraphForm_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void button_Redraw_Click(object sender, EventArgs e)
        {
            TaskController.DrawNodes();
        }

        private void panel_Drawing_MouseClick(object sender, MouseEventArgs e)
        {
            if (isAddingNode)
            {
                if (radioButton_isConsumer.Checked)
                {
                    TaskController.AddNodeAtScreen(Node.NodeType.Consumer, e.X, e.Y);
                }
                else if (radioButton_isDepot.Checked)
                {
                    TaskController.AddNodeAtScreen(Node.NodeType.Depot, e.X, e.Y);                    
                }
            }
        }

        private bool isAddingNode = false;

        private void button_AddNode_Click(object sender, EventArgs e)
        {
            if (isAddingNode)
            {
                (sender as Button).Text = "Add node";
            }
            else
            {
                (sender as Button).Text = "Stop adding";
            }

            isAddingNode = !isAddingNode;
        }
    }
}
