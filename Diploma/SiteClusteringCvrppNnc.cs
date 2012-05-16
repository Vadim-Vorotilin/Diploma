using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class SiteClusteringCvrppNnc : SiteClusteringCvrpp
    {
        private static List<Cluster> nncClusters; 

        public SiteClusteringCvrppNnc(List<Node> nodes, int capacityLimit, int clustersCount, double kilometerCost) 
            : base(nodes, capacityLimit, clustersCount, kilometerCost)
        {
            if (IsStartingInitialized)
            {
                GenerateClustersFromNnc();
            }
        }

        protected override List<Node> GenerateClusters(List<Node> nodesForClusters, Node _depot)
        {
            return null;
        }

        private void GenerateClustersFromNnc()
        {
            PenaltyCluster = new Cluster();

            if (ClustersCount >= nncClusters.Count)
            {
                Clusters = nncClusters;
            }
            else
            {
                Clusters = new List<Cluster>();

                List<Cluster> newClusters = new List<Cluster>();
                newClusters.AddRange(nncClusters);

                for (int i = 0; i != ClustersCount; i++)
                {
                    int index = TaskController.Rnd.Next(newClusters.Count);
                    Clusters.Add(newClusters[index]);
                    newClusters.RemoveAt(index);
                }

                foreach (Cluster newCluster in newClusters)
                {
                    PenaltyCluster.Merge(newCluster);
                }
            }
        }

        public override void StartingInitialize()
        {
            base.StartingInitialize();

            List<Node> consumers = (from node in Nodes
                                    where node.Type == Node.NodeType.Consumer
                                    select node).ToList();

            NearestNeighbourChain nnc = new NearestNeighbourChain(consumers, CapacityLimit);
            nnc.IterateToStop();

            nncClusters = nnc.Clusters;
        }
    }
}
