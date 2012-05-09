using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Diploma
{
    public abstract class Algorithm
    {
        protected List<Node> Nodes;

        protected int DepotsCount;
        protected int ConsumersCount;
        public int IterationNumber { get; private set; }

        public abstract double Value { get; }

        protected Algorithm()
        {
            IterationNumber = 0;
        }

        public void SetNodes(List<Node> nodesForSet)
        {
            Nodes = new List<Node>();

            var depots = from node in nodesForSet
                         where node.Type == Node.NodeType.Depot
                         select node;

            Nodes.AddRange(depots.ToList());

            DepotsCount = depots.Count();

            var consumers = from node in nodesForSet
                            where node.Type == Node.NodeType.Consumer
                            select node;

            Nodes.AddRange(consumers.ToList());

            ConsumersCount = consumers.Count();
        }

        public int LastChangedIteration { get; private set; }
        public bool IsCalcLastChange { get; set; }
        public string LogFileName { get; set; }

        private StreamWriter writer = null;

        private void OpenLogFile()
        {
            if (File.Exists(LogFileName))
            {
                writer = new StreamWriter(LogFileName, true);
                writer.WriteLine(string.Format("Starting new algorithm: {0}. Time: {1}.", GetType().Name, DateTime.Now));
            }
        }

        private double lastValue = double.PositiveInfinity;
       
        private void Iteration()
        {
            if (IterationNumber == 0)
            {
                OpenLogFile();
            }

            InnerIteration();
            IterationNumber++;

            double newValue = double.PositiveInfinity;

            if (writer != null || IsCalcLastChange)
            {
                newValue = Value;
            }

            if (writer != null)
            {
                writer.WriteLine(string.Format("{0}\t{1:0.00}", IterationNumber, newValue));
            }

            if (IsCalcLastChange && lastValue != newValue)
            {
                LastChangedIteration = IterationNumber;
            }

            lastValue = newValue;
        }

        public void Iterations (int count = 1)
        {
            for (int i = 0; i != count; i++)
            {
                Iteration();
            }
        }

        public void Stop()
        {
            if (writer != null)
            {
                writer.Close();
            }
        }

        protected abstract void InnerIteration();

        public abstract void DrawNodes();
    }
}
