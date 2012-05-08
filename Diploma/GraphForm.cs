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
            button_AddNode.PerformClick();
            comboBox_AlgorithmType.SelectedIndex = 0;
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
                    if (e.Button == MouseButtons.Left)
                    {
                        TaskController.AddNodeAtScreen(Node.NodeType.Consumer, e.X, e.Y);
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        TaskController.AddNodeAtScreen(Node.NodeType.Depot, e.X, e.Y);
                    }
                }
                else if (radioButton_isDepot.Checked)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        TaskController.AddNodeAtScreen(Node.NodeType.Depot, e.X, e.Y);
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        TaskController.AddNodeAtScreen(Node.NodeType.Consumer, e.X, e.Y);
                    }
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

        private KMeans kMeans;

        private void button_StartAlgorithm_MouseClick(object sender, MouseEventArgs e)
        {
            switch (comboBox_AlgorithmType.SelectedIndex)
            {
                case 0:                 //  Bees VRP -> TSP
                    TaskController.StartBeesAlgorithm(BeesColony.ProblemType.VRP_TSP, Convert.ToInt32(numericUpDown_ClustersCount.Value), 5, 3, 1, 2, 3);
                    break;
                case 1:                 //  Bees CLUSTERING
                    TaskController.StartBeesAlgorithm(BeesColony.ProblemType.CLUSTERING, Convert.ToInt32(numericUpDown_ClustersCount.Value), 5, 3, 1, 2, 3);
                    break;
                case 2:                 //  K-means CLUSTERING
                    TaskController.StartKMeansAlgorithm(Convert.ToInt32(numericUpDown_ClustersCount.Value));
                    break;
            }
        }

        private void button_Iteration_Click(object sender, EventArgs e)
        {
            TaskController.Algorithm.Iteration();
            TaskController.Algorithm.DrawNodes();

            SetStatus(string.Format("Iteration {0} completed. Value: {1:0.00}", TaskController.Algorithm.IterationNumber, TaskController.Algorithm.Value));
        }

        private void button_Iterate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i != numericUpDown_IterationsCount.Value; i++)
            {
                TaskController.Algorithm.Iteration();
            }

            TaskController.Algorithm.DrawNodes();

            SetStatus(string.Format("Iteration {0} completed. Value: {1:0.00}", TaskController.Algorithm.IterationNumber, TaskController.Algorithm.Value));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskController.CreateNewModel();
        }

        private void loadModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Model|*.mdl";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!TaskController.LoadModel(openFileDialog.FileName))
                    {
                        MessageBox.Show("Loading model failed!", "Loading failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveModelAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Model|*.mdl";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!TaskController.SaveModel(saveFileDialog.FileName))
                    {
                        MessageBox.Show("Saving model failed!", "Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TaskController.SaveModel())
            {
                saveModelAsToolStripMenuItem.PerformClick();
            }
        }

        private void SetStatus(string status)
        {
            toolStripStatusLabel_Main.Text = status;
        }
    }
}
