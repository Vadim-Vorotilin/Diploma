using System;
using System.Collections.Generic;
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
       
        public void Iteration()
        {
            InnerIteration();
            IterationNumber++;
        }

        protected abstract void InnerIteration();

        public abstract void DrawNodes();
    }
}
