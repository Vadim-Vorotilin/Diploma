﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Diploma
{
    public abstract class Algorithm
    {
        protected List<Node> Nodes;
        protected List<Node> Depots;
        protected List<Node> Consumers;

        protected int DepotsCount;
        protected int ConsumersCount;
        public int IterationNumber { get; private set; }

        public abstract double Value { get; }

        protected bool Stopped { get; private set; }

        private const double Epsilon = 0.0001;

        protected Algorithm()
        {
            IterationNumber = 0;
        }

        public void SetNodes(List<Node> nodesForSet)
        {
            Nodes = new List<Node>();

            Depots = (from node in nodesForSet
                      where node.Type == Node.NodeType.Depot
                      select node).ToList();

            Nodes.AddRange(Depots);

            DepotsCount = Depots.Count;

            Consumers = (from node in nodesForSet
                         where node.Type == Node.NodeType.Consumer
                         select node).ToList();

            Nodes.AddRange(Consumers);

            ConsumersCount = Consumers.Count;
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
            if (Stopped)
                return;
            
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

            if (writer != null && !Stopped && (IterationNumber - 1) % 10 == 0)
            {
                writer.WriteLine(string.Format("{0}\t{1:0.00}", IterationNumber, newValue));
            }

            if (IsCalcLastChange && Math.Abs(lastValue - newValue) >= lastValue * Epsilon)
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

        public void IterateToStop()
        {
            while (!Stopped)
            {
                Iteration();
            }
        }

        public void Stop()
        {
            if (Stopped)
            {
                return;
            }

            if (writer != null)
            {
                writer.Close();
            }

            Stopped = true;
        }

        protected abstract void InnerIteration();

        public abstract void DrawNodes();

        public virtual string Info()
        {
            return "";
        }
    }
}
