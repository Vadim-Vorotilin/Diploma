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

            lastReviewedCluster = -1;
        }

        private void GenerateClusters()
        {
            Clusters = new List<Cluster>();

            for (int i = 0; i != Consumers.Count; i++)
            {
                AddCluster();
                Clusters[i].AddNode(Consumers[i]);
            }
        }

        private int lastReviewedCluster;

        protected override void InnerIteration()
        {
            lastReviewedCluster++;

            if (lastReviewedCluster >= Clusters.Count)
            {
                lastReviewedCluster = 0;
            }

            int startingCluster = lastReviewedCluster;

            int currentCluster = startingCluster;
            int lastCluster;

            do
            {

            } while (true);
        }
    }
}
