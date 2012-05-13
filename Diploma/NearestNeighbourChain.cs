using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class NearestNeighbourChain : ClusteringAlgorithm
    {
        private readonly int capacityLimit;

        public NearestNeighbourChain(List<Node> nodes, int capacityLimit)
            : base(nodes)
        {
            this.capacityLimit = capacityLimit;

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

        private int NearestCluster(int cluster)
        {
            double minDistance = double.PositiveInfinity;
            int result = -1;

            for (int i = 0; i != Clusters.Count; i++)
            {
                if (i == cluster)
                    continue;

                double dist = Node.Point.SqrDistance(Clusters[i].Center, Clusters[cluster].Center);

                if (dist < minDistance)
                {
                    minDistance = dist;
                    result = i;
                }
            }

            return result;
        }

        private bool merged = false;

        protected override void InnerIteration()
        {
            lastReviewedCluster++;

            if (lastReviewedCluster >= Clusters.Count)
            {
                if (!merged)
                {
                    Stop();
                    return;
                }

                lastReviewedCluster = 0;
                merged = false;
            }

            if (Clusters.Count <= 1)
            {
                return;
            }

            int startingCluster = lastReviewedCluster;

            int currentCluster = startingCluster;
            int lastCluster = startingCluster;

            do
            {
                int nearest = NearestCluster(currentCluster);

                if (nearest == lastCluster)
                {
                    break;
                }

                lastCluster = currentCluster;
                currentCluster = nearest;

            } while (true);

            if (Clusters[lastCluster].Volume + Clusters[currentCluster].Volume <= capacityLimit)
            {
                Clusters[lastCluster].Merge(Clusters[currentCluster]);
                Clusters.RemoveAt(currentCluster);
                merged = true;
            }
        }

        public override string Info()
        {
            return string.Format("Clusters count: {0}. Stopped: {1}", Clusters.Count, Stopped);
        }
    }
}
