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
            TaskController.GraphicsForDraw = this.CreateGraphics();
        }

        private void GraphForm_MouseClick(object sender, MouseEventArgs e)
        {
            TaskController.AddNodeAtScreen(Node.NodeType.Consumer, e.X, e.Y);
        }
    }
}
