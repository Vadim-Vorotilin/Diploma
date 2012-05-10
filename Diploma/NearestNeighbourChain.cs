using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class NearestNeighbourChain : ClusteringAlgorithm
    {
        public NearestNeighbourChain(List<Node> nodes)
            : base(nodes)
        {
            GenerateClusters();
        }

        private void GenerateClusters()
        {
            Clusters = new List<Cluster>();

            for (int i = 0; i != Consumers.Count; i++)
            {
                AddCluster();
                Clusters[i].Nodes.Add(Consumers[i]);
            }
        }

        protected override void InnerIteration()
        {
            throw new NotImplementedException();
        }
    }
}
