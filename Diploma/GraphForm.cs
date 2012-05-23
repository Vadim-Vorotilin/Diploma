using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        }

        private void button_StartAlgorithm_Click(object sender, EventArgs eventArgs)
        {
            AlgorithmType algorithm;

            if (checkBox_CapacityUnlimited.Checked)
            {
                if (TaskController.ConsumersCount < 200)
                {
                    algorithm = AlgorithmType.BEES_CLUST;
                }
                else
                {
                    algorithm = AlgorithmType.K_MEANS_CLUST;
                }
            }
            else if (checkBox_VehiclesCountUnlimited.Checked)
            {
                if (TaskController.ConsumersCount < 200)
                {
                    algorithm = AlgorithmType.BEES_CLUST_LIMIT;
                }
                else
                {
                    algorithm = AlgorithmType.NNC_CLUST;
                }
            }
            else
            {
                algorithm = AlgorithmType.BEES_CLUST_CVRPP_NNC;
            }

            if (!StartAlgorithm(algorithm))
                return;
        }

        private int ClustersCount
        {
            get { return Convert.ToInt32(numericUpDown_ClustersCount.Value); }
        }

        private int ClusterCapacityLimit
        {
            get { return Convert.ToInt32(numericUpDown_ClusterCapacityLimit.Value); }
        }

        private double KilometerCost
        {
            get { return Convert.ToDouble(numericUpDown_KilometerCost.Value); }
        }

        private enum AlgorithmType
        {
            BEES_VRP_TSP,
            BEES_CLUST,
            BEES_CLUST_LIMIT,
            K_MEANS_CLUST,
            NNC_CLUST,
            BEES_CLUST_CVRPP,
            BEES_CLUST_CVRPP_NNC
        }

        private bool StartAlgorithm(AlgorithmType algorithm)
        {
            if (TaskController.Nodes.Count < ClustersCount)
            {
                MessageBox.Show("Model must have more or equal number of points than clusters count", "Too few points",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            TaskController.KilometerCost = KilometerCost;

            switch (algorithm)
            {
                case AlgorithmType.BEES_VRP_TSP:                //  Bees VRP -> TSP
                    TaskController.StartBeesAlgorithm(BeesColony.ProblemType.VRP_TSP, ClustersCount, 5, 3, 1, 2, 3);
                    break;
                case AlgorithmType.BEES_CLUST:                  //  Bees CLUSTERING
                    TaskController.StartBeesAlgorithm(BeesColony.ProblemType.CLUSTERING_VRP, ClustersCount, 5, 3, 1, 2, 3);
                    break;
                case AlgorithmType.BEES_CLUST_LIMIT:            //  Bees CLUST w/ LIMIT
                    if (ClusterCapacityLimit < TaskController.MaxVolume)
                    {
                        MessageBox.Show(string.Format("Max volume: {0}. Capacity: {1}", TaskController.MaxVolume, ClusterCapacityLimit), "Too few clusters",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    TaskController.StartBeesAlgorithm(BeesColony.ProblemType.CLUSTERING_CVRP, ClustersCount, 7, 3, 2, 2, 5, ClusterCapacityLimit);
                    break;
                case AlgorithmType.K_MEANS_CLUST:               //  K-means CLUSTERING
                    TaskController.StartKMeansAlgorithm(ClustersCount);
                    break;
                case AlgorithmType.NNC_CLUST:                   //  NearNeighChain
                    if (ClusterCapacityLimit < TaskController.MaxVolume)
                    {
                        MessageBox.Show(string.Format("Max volume: {0}. Capacity: {1}", TaskController.MaxVolume, ClusterCapacityLimit), "Too few clusters",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    TaskController.StartNearestNeighbourChainAlgorithm(ClusterCapacityLimit);
                    break;
                case AlgorithmType.BEES_CLUST_CVRPP:            //  Bees CLUST CVRPP
                    TaskController.StartBeesAlgorithm(BeesColony.ProblemType.CLUSTERING_CVRPP, ClustersCount, 7, 3, 2, 2, 5, ClusterCapacityLimit, KilometerCost);
                    break;
                case AlgorithmType.BEES_CLUST_CVRPP_NNC:        //  Bees CLUST CVRPP NNC
                    TaskController.StartBeesAlgorithm(BeesColony.ProblemType.CLUSTERING_CVRPP_NNC, ClustersCount, 7, 3, 2, 2, 5, ClusterCapacityLimit, KilometerCost);
                    break;
            }

            TaskController.Algorithm.LogFileName = "";

            TaskController.Algorithm.IterateToStop();
            CalculateTsp();

            return true;
        }

        private void StopAlgorithm()
        {
            TaskController.StopAlgorithm();
        }

        private void LockAlgorithmOptions(bool _lock)
        {
            label_ClustersCount.Enabled = !_lock;
            numericUpDown_ClustersCount.Enabled = !_lock;
            label_ClusterCapacityLimit.Enabled = !_lock;
            numericUpDown_ClusterCapacityLimit.Enabled = !_lock;
            label_KilometerCost.Enabled = !_lock;
            numericUpDown_KilometerCost.Enabled = !_lock;
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
                openFileDialog.Filter = "Model|*.xmdl";

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
                saveFileDialog.Filter = "Model|*.xmdl";

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
                //saveModelAsToolStripMenuItem.PerformClick();
            }
        }

        private void SetStatus(string status, bool saveToList = true)
        {
            toolStripStatusLabel_Main.Text = status;

            if (saveToList)
            {
                listBox_Statuses.Items.Add(status);
                listBox_Statuses.SelectedIndex = listBox_Statuses.Items.Count - 1;

                TaskController.SaveDrawnNodes();
            }
        }

        private double IterateToStop()
        {
            DateTime stTime = DateTime.Now;

            TaskController.Algorithm.IsCalcLastChange = true;

            TaskController.Algorithm.IterateToStop();

            TimeSpan calcTime = DateTime.Now - stTime;
            double time = calcTime.TotalMilliseconds / 1000.0;

            TaskController.Algorithm.DrawNodes();

            SetStatus(
                string.Format(
                    "Iteration {0} completed. Value: {1:0.00}. Last changed at iteration: {2}. Time: {3:0.00} s. {4}",
                    TaskController.Algorithm.IterationNumber, TaskController.Algorithm.Value,
                    TaskController.Algorithm.LastChangedIteration, time,
                    TaskController.Algorithm.Info()));

            return time;
        }

        private void button_IterateToStop_Click(object sender, EventArgs e)
        {
            IterateToStop();
        }

        private double CalculateTsp()
        {
            DateTime stTime = DateTime.Now;

            TaskController.StartClusteringToTsp();

            if (TaskController.Algorithm as ClusteringToTsp != null)
            {
                (TaskController.Algorithm as ClusteringToTsp).Calculate(5, 3, 1, 2, 3);
            }
            else
            {
                return 0;
            }

            TimeSpan calcTime = DateTime.Now - stTime;
            double time = calcTime.TotalMilliseconds / 1000.0;

            TaskController.Algorithm.DrawNodes();

            SetStatus(
                string.Format(
                    "Value: {0:0.00}. Time: {1:0.00} s. {2}",
                    TaskController.Algorithm.Value, time,
                    TaskController.Algorithm.Info()));

            return time;
        }

        private void button_CalculateTsp_Click(object sender, EventArgs e)
        {
            CalculateTsp();
        }

        private void GenerateNodes(int count, int volumeFrom, int volumeTo, bool withDepot)
        {
            for (int i = 0; i != count; i++)
            {
                int volume = TaskController.Rnd.Next(volumeFrom, volumeTo + 1);
                TaskController.AddNodeAtScreen(Node.NodeType.Consumer, TaskController.Rnd.Next(10, panel_Drawing.Width - 10), TaskController.Rnd.Next(10, panel_Drawing.Height - 10), volume, volume);
            }

            if (withDepot)
            {
                TaskController.AddNodeAtScreen(Node.NodeType.Depot,
                                               TaskController.Rnd.Next(10, panel_Drawing.Width - 10),
                                               TaskController.Rnd.Next(10, panel_Drawing.Height - 10), 0);
            }

            TaskController.DrawNodes(TaskController.Nodes);
        }

        private void listBox_Statuses_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox_Statuses_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox_Statuses.SelectedIndex >= 0)
            {
                TaskController.DrawNodes(listBox_Statuses.SelectedIndex);
            }
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ReportForm reportForm = new ReportForm())
            {
                reportForm.ShowDialog();
            }
        }

        private void checkBox_VehiclesCountUnlimited_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_ClustersCount.Enabled = !checkBox_VehiclesCountUnlimited.Checked;

            if (checkBox_VehiclesCountUnlimited.Checked && checkBox_CapacityUnlimited.Checked)
            {
                checkBox_CapacityUnlimited.Checked = false;
            }
        }

        private void checkBox_CapacityLimit_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_ClusterCapacityLimit.Enabled = !checkBox_CapacityUnlimited.Checked;

            if (checkBox_VehiclesCountUnlimited.Checked && checkBox_CapacityUnlimited.Checked)
            {
                checkBox_VehiclesCountUnlimited.Checked = false;
            }
        }

        private void GraphForm_ResizeEnd(object sender, EventArgs e)
        {
            TaskController.GraphicsForDraw = panel_Drawing.CreateGraphics();
        }
    }
}
