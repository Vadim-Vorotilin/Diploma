using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class SiteClusteringCvrp : SiteClusteringVrp
    {
        private readonly int capacityLimit;
        private Node depot;

        protected List<Node> RemainingNodes; 
            
        public SiteClusteringCvrp (List<Node> nodes, int capacityLimit, int clustersCount = int.MaxValue) 
            : base(nodes)
        {
            Clusters = new List<Cluster>();
            this.capacityLimit = capacityLimit;
            this.ClustersCount = clustersCount;

            RemainingNodes = GenerateClusters();
        }

        protected SiteClusteringCvrp (SiteClusteringCvrp site)
            : base(site)
        {
            this.capacityLimit = site.capacityLimit;
        }

        private int UnderLimitClustersCount { get; set; }

        public override double Price
        {
            get
            {
                double price = 0;
                UnderLimitClustersCount = 0;

                foreach (Cluster cluster in Clusters)
                {
                    int volume = cluster.Volume;

                    if (volume <= cluster.CapacityLimit)
                    {
                        price += cluster.GetPrice();
                        UnderLimitClustersCount++;
                    }
                    else
                    {
                        price += double.PositiveInfinity;   //Math.Pow(cluster.GetPrice(), 2) * (volume - capacityLimit + 1);
                    }
                }

                return price;
            }
        }

        private void AddCluster()
        {
            Cluster newCluster = new Cluster();
            newCluster.Depot = depot;
            newCluster.CapacityLimit = capacityLimit;

            Clusters.Add(newCluster);
        }

        protected override List<Node> GenerateClusters(List<Node> nodesForClusters, Node _depot)
        {
            this.depot = _depot;

            while (nodesForClusters.Count != 0)
            {
                bool b = false;

                for (int i = 0; i != Clusters.Count; i++)
                {
                    if (nodesForClusters.Count == 0)
                        break;

                    int index = TaskController.Rnd.Next(nodesForClusters.Count);

                    if (Clusters[i].Volume + nodesForClusters[index].Volume <= Clusters[i].CapacityLimit)
                    {
                        Clusters[i].AddNode(nodesForClusters[index]);
                        nodesForClusters.RemoveAt(index);
                        b = true;
                    }
                }

                if (!b && Clusters.Count == ClustersCount)
                {
                    break;
                }

                if (!b)
                {
                    AddCluster();
                }
            }

            List<Node> remainingNodes = new List<Node>();
            remainingNodes.AddRange(nodesForClusters);

            return remainingNodes;
        }

        public static bool ExchangeNodesInClusters(List<Cluster> clusters)
        {
            if (clusters.Count <= 1)
            {
                return false;
            }

            int i1 = TaskController.Rnd.Next(clusters.Count);
            int i2;

            do
            {
                i2 = TaskController.Rnd.Next(clusters.Count);
            } while (i2 == i1);

            return ExchangeNodesInClusters(clusters[i1], clusters[i2]);
        }

        protected static bool ExchangeNodesInClusters(Cluster c1, Cluster c2)
        {
            if (c1.Nodes.Count == 0 || c2.Nodes.Count == 0)
            {
                return false;
            }

            int i1 = TaskController.Rnd.Next(c1.Nodes.Count);
            int i2 = TaskController.Rnd.Next(c2.Nodes.Count);

            Node node1 = c1.Nodes[i1];
            Node node2 = c2.Nodes[i2];

            int volume1 = c1.Volume - node1.Volume;
            int volume2 = c2.Volume - node2.Volume;

            if (volume1 + node2.Volume <= c1.CapacityLimit && volume2 + node1.Volume <= c2.CapacityLimit)
            {
                c1.RemoveNode(node1);
                c2.RemoveNode(node2);

                c1.AddNode(node2);
                c2.AddNode(node1);

                return true;
            }

            return false;
        }

        protected override Site GetNeighbour()
        {
            SiteClusteringCvrp result = new SiteClusteringCvrp(this);

            double probability = TaskController.Rnd.NextDouble();

            if (probability < 0.5)
            {
                MoveNodeFromOneClusterToAnother(result.Clusters);
            }
            else
            {
                ExchangeNodesInClusters(result.Clusters);
            }

            return result;
        }

        public override int CompareTo(object obj)
        {
            SiteClusteringCvrp site = obj as SiteClusteringCvrp;

            if (double.IsPositiveInfinity(Price) && double.IsPositiveInfinity(site.Price))
            {
                return -UnderLimitClustersCount.CompareTo(site.UnderLimitClustersCount);
            }

            return Price.CompareTo(site.Price);
        }

        public override string ToString()
        {
            return string.Format("{0}. Good clusters: {1}", base.ToString(), UnderLimitClustersCount);
        }
    }
}
