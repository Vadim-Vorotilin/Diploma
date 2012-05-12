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
            comboBox_AlgorithmType.SelectedIndex = 0;
            LockIterationsOptions(true);
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
            int volume = Convert.ToInt32(numericUpDown_Volume.Value);
            
            if (e.Button == MouseButtons.Left)
            {
                TaskController.AddNodeAtScreen(Node.NodeType.Consumer, e.X, e.Y, volume);
            }
            else if (e.Button == MouseButtons.Right)
            {
                TaskController.AddNodeAtScreen(Node.NodeType.Depot, e.X, e.Y, 0);
            }
        }

        private void button_StartAlgorithm_Click(object sender, EventArgs eventArgs)
        {
            if (!TaskController.IsAlgorithmStarted)
            {
                if (!StartAlgorithm())
                    return;

                LockAlgorithmOptions(true);
                LockIterationsOptions(false);
                button_StartAlgorithm.Text = "Stop";
            }
            else
            {
                StopAlgorithm();
                LockAlgorithmOptions(false);
                LockIterationsOptions(true);
                button_StartAlgorithm.Text = "Start";
            }
        }

        private int ClustersCount
        {
            get { return Convert.ToInt32(numericUpDown_ClustersCount.Value); }
        }

        private int ClusterCapacityLimit
        {
            get { return Convert.ToInt32(numericUpDown_ClusterCapacityLimit.Value); }
        }

        private bool StartAlgorithm()
        {
            if (TaskController.Nodes.Count < ClustersCount)
            {
                MessageBox.Show("Model must have more or equal number of points than clusters count", "Too few points",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            switch (comboBox_AlgorithmType.SelectedIndex)
            {
                case 0:                 //  Bees VRP -> TSP
                    TaskController.StartBeesAlgorithm(BeesColony.ProblemType.VRP_TSP, ClustersCount, 5, 3, 1, 2, 3);
                    break;
                case 1:                 //  Bees CLUSTERING
                    TaskController.StartBeesAlgorithm(BeesColony.ProblemType.CLUSTERING, ClustersCount, 5, 3, 1, 2, 3);
                    break;
                case 2:                 //  Bees CLUST w/ LIMIT
                    if (ClusterCapacityLimit < TaskController.MaxVolume)
                    {
                        MessageBox.Show(string.Format("Max volume: {0}. Capacity: {1}", TaskController.MaxVolume, ClusterCapacityLimit), "Too few clusters",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    TaskController.StartBeesAlgorithm(BeesColony.ProblemType.CLUSTERING_LIMITED_CAPASITY, ClustersCount, 7, 3, 2, 2, 5, ClusterCapacityLimit);
                    break;
                case 3:                 //  K-means CLUSTERING
                    TaskController.StartKMeansAlgorithm(ClustersCount);
                    break;
                case 4:                 //  NearNeighChain
                    if (ClusterCapacityLimit < TaskController.MaxVolume)
                    {
                        MessageBox.Show(string.Format("Max volume: {0}. Capacity: {1}", TaskController.MaxVolume, ClusterCapacityLimit), "Too few clusters",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    TaskController.StartNearestNeighbourChainAlgorithm(ClusterCapacityLimit);
                    break;
            }

            TaskController.Algorithm.LogFileName = textBox_LogFileName.Text;

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
            label_Algorithm.Enabled = !_lock;
            comboBox_AlgorithmType.Enabled = !_lock;
        }

        private void LockIterationsOptions(bool _lock)
        {
            button_Iteration.Enabled = !_lock;
            button_Iterate.Enabled = !_lock;
            button_IterateToStop.Enabled = !_lock;
            button_CalculateTsp.Enabled = !_lock;
            numericUpDown_IterationsCount.Enabled = !_lock;
        }

        private void button_Iteration_Click(object sender, EventArgs e)
        {
            TaskController.Algorithm.Iterations();
            TaskController.Algorithm.DrawNodes();

            SetStatus(string.Format("Iteration {0} completed. Value: {1:0.00}. Last changed at iteration: {2}. {3}",
                                    TaskController.Algorithm.IterationNumber, TaskController.Algorithm.Value,
                                    TaskController.Algorithm.LastChangedIteration, TaskController.Algorithm.Info()));
        }

        private void button_Iterate_Click(object sender, EventArgs e)
        {
            DateTime stTime = DateTime.Now;

            TaskController.Algorithm.IsCalcLastChange = checkBox_LastChangedIteration.Checked;

            TaskController.Algorithm.Iterations(Convert.ToInt32(numericUpDown_IterationsCount.Value));

            TimeSpan calcTime = DateTime.Now - stTime;

            TaskController.Algorithm.DrawNodes();

            SetStatus(
                string.Format(
                    "Iteration {0} completed. Value: {1:0.00}. Last changed at iteration: {2}. Time: {3:0.00} s. {4}",
                    TaskController.Algorithm.IterationNumber, TaskController.Algorithm.Value,
                    TaskController.Algorithm.LastChangedIteration, calcTime.TotalMilliseconds/1000.0,
                    TaskController.Algorithm.Info()));
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
                saveModelAsToolStripMenuItem.PerformClick();
            }
        }

        private void SetStatus(string status)
        {
            toolStripStatusLabel_Main.Text = status;

            listBox_Statuses.Items.Add(status);
            listBox_Statuses.SelectedIndex = listBox_Statuses.Items.Count - 1;

            TaskController.SaveDrawnNodes();
        }

        private void LockConsumerVolumeSettings(bool _lock)
        {
            label_Volume.Enabled = !_lock;
            numericUpDown_Volume.Enabled = !_lock;
        }

        private double IterateToStop()
        {
            DateTime stTime = DateTime.Now;

            TaskController.Algorithm.IsCalcLastChange = checkBox_LastChangedIteration.Checked;

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
                TaskController.AddNodeAtScreen(Node.NodeType.Consumer, TaskController.Rnd.Next(10, panel_Drawing.Width - 10), TaskController.Rnd.Next(10, panel_Drawing.Height - 10), TaskController.Rnd.Next(volumeFrom, volumeTo + 1));
            }

            if (withDepot)
            {
                TaskController.AddNodeAtScreen(Node.NodeType.Depot,
                                               TaskController.Rnd.Next(10, panel_Drawing.Width - 10),
                                               TaskController.Rnd.Next(10, panel_Drawing.Height - 10), 0);
            }

            TaskController.DrawNodes(TaskController.Nodes);
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            GenerateNodes(Convert.ToInt32(numericUpDown_GeneratingCount.Value),
                Convert.ToInt32(numericUpDown_GeneratingVolumeFrom.Value),
                Convert.ToInt32(numericUpDown_GeneratingVolumeTo.Value),
                checkBox_WithDepot.Checked);
        }

        private void listBox_Statuses_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox_Statuses_MouseClick(object sender, MouseEventArgs e)
        {
            TaskController.DrawNodes(listBox_Statuses.SelectedIndex);
        }

        private string GetAlgorithmName(int index)
        {
            return comboBox_AlgorithmType.Items[index].ToString();
        }

        private void button_StartSeries_Click(object sender, EventArgs e)
        {
            int consumersFrom = Convert.ToInt32(numericUpDown_ConsumersCountFrom.Value);
            int consumersTo = Convert.ToInt32(numericUpDown_ConsumersCountTo.Value);
            int consumersStep = Convert.ToInt32(numericUpDown_ConsumersCountStep.Value);

            int volumeFrom = Convert.ToInt32(numericUpDown_GeneratingVolumeFrom.Value);
            int volumeTo = Convert.ToInt32(numericUpDown_GeneratingVolumeTo.Value);

            int startsCount = Convert.ToInt32(numericUpDown_StartsInSeriesCount.Value);
            int modelsCount = Convert.ToInt32(numericUpDown_ModelsCount.Value);

            int algorithmsCount = comboBox_AlgorithmType.Items.Count;

            int seriesCount = (consumersTo - consumersFrom) / consumersStep + 1;

            string logFileName = textBox_LogFileName.Text;

            QuickAppendToFile(logFileName,
                              string.Format(
                                  "----- Series start. Clusters limit: {0}. Capacity limit: {1}. Starts in each series: {2}. Models count: {3}. Time: {4}",
                                  Convert.ToInt32(numericUpDown_ClustersCount.Value),
                                  Convert.ToInt32(numericUpDown_ClusterCapacityLimit.Value),
                                  startsCount, modelsCount, DateTime.Now));

            for (int i = 0; i != seriesCount; i++)
            {
                int consumersCount = consumersFrom + i * consumersStep;

                //QuickAppendToFile(logFileName,
                //                  string.Format("--- New models generate. Consumers count: {0}. Time: {1}", consumersCount,
                //                                DateTime.Now));

                double[] valuesAvr = new double[algorithmsCount];
                double[] timesAvr = new double[algorithmsCount];

                for (int k = 0; k != algorithmsCount; k++)
                {
                    valuesAvr[k] = 0;
                    timesAvr[k] = 0;
                }

                for (int j = 0; j != modelsCount; j++)
                {
                    TaskController.CreateNewModel();
                    GenerateNodes(consumersCount, volumeFrom, volumeTo, true);

                    for (int k = 0; k != algorithmsCount; k++)
                    {
                        comboBox_AlgorithmType.SelectedIndex = k;

                        //QuickAppendToFile(logFileName,
                        //                  string.Format("Starting model series for algorithm {0}. Time: {1}",
                        //                                GetAlgorithmName(k),
                        //                                DateTime.Now));

                        List<double> values = new List<double>();
                        List<double> times = new List<double>();

                        for (int l = 0; l != startsCount; l++)
                        {
                            StartAlgorithm();
                            TaskController.Algorithm.LogFileName = "";

                            double time = IterateToStop() + CalculateTsp();

                            values.Add(TaskController.Algorithm.Value);
                            times.Add(time);

                            //QuickAppendToFile(logFileName,
                            //                  string.Format(
                            //                      "Start #{0} completed. Result: {1:0.00}. During the: {2:0.00} s. Time: {3}",
                            //                      l,
                            //                      values[l],
                            //                      times[l],
                            //                      DateTime.Now));
                        }


                        valuesAvr[k] += values.Average();
                        timesAvr[k] += times.Average();

                        //QuickAppendToFile(logFileName,
                        //                  string.Format(
                        //                      "Model series completed. Avr result: {0:0.00}. Avr time: {1:0.00} s. Time: {2}",
                        //                      values.Average(), times.Average(), DateTime.Now));
                    }
                }

                for (int k = 0; k != algorithmsCount; k++)
                {
                    valuesAvr[k] /= modelsCount;
                    timesAvr[k] /= modelsCount;

                    QuickAppendToFile(logFileName,
                                      string.Format("Algorithm {0}. Avr result: {1:0.00}. Avr time: {2:0.00} s",
                                                    GetAlgorithmName(k), valuesAvr[k], timesAvr[k]));
                }

                QuickAppendToFile(logFileName, string.Format("--- Series #{0} completed. Time: {1}", i, DateTime.Now));
            }

            QuickAppendToFile(logFileName,
                              string.Format(
                                  "----- All series completed. Time: {0}", DateTime.Now));
        }

        private void QuickAppendToFile(string fileName, string line)
        {
            if (File.Exists(fileName))
            {
                StreamWriter writer = new StreamWriter(fileName, true);
                writer.WriteLine(line);
                writer.Close();
            }
            else
            {
                throw new Exception("No file!");
            }
        }
    }
}
