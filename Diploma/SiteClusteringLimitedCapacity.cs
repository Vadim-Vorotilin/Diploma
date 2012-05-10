using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class SiteClusteringLimitedCapacity : SiteClustering
    {
        private readonly int capacityLimit;
        private Node depot;
            
        public SiteClusteringLimitedCapacity (List<Node> nodes, int clustersCount, int capacityLimit) 
            : base(nodes)
        {
            Clusters = new List<Cluster>();
            this.capacityLimit = capacityLimit;
            this.ClustersCount = clustersCount;

            GenerateClusters();
        }

        private SiteClusteringLimitedCapacity (SiteClusteringLimitedCapacity site)
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

                    if (volume <= capacityLimit)
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

            Clusters.Add(newCluster);
        }

        protected override void GenerateClusters(List<Node> nodesForClusters, Node depot)
        {
            this.depot = depot;

            while (nodesForClusters.Count != 0)
            {
                bool b = false;

                for (int i = 0; i != Clusters.Count; i++)
                {
                    if (nodesForClusters.Count == 0)
                        break;

                    int index = TaskController.Rnd.Next(nodesForClusters.Count);

                    if (Clusters[i].Volume + nodesForClusters[index].Volume <= capacityLimit)
                    {
                        Clusters[i].AddNode(nodesForClusters[index]);
                        nodesForClusters.RemoveAt(index);
                        b = true;
                    }
                }

                if (!b)
                {
                    AddCluster();
                }
            }
        }

        public bool ExchangeNodesInClusters()
        {
            int i1 = TaskController.Rnd.Next(Clusters.Count);
            int i2;

            do
            {
                i2 = TaskController.Rnd.Next(Clusters.Count);
            } while (i2 == i1);

            return ExchangeNodesInClusters(Clusters[i1], Clusters[i2]);
        }

        private bool ExchangeNodesInClusters(Cluster c1, Cluster c2)
        {
            int i1 = TaskController.Rnd.Next(c1.Nodes.Count);
            int i2 = TaskController.Rnd.Next(c2.Nodes.Count);

            Node node1 = c1.Nodes[i1];
            Node node2 = c2.Nodes[i2];

            int volume1 = c1.Volume - node1.Volume;
            int volume2 = c2.Volume - node2.Volume;

            if (volume1 + node2.Volume <= capacityLimit && volume2 + node1.Volume <= capacityLimit)
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
            SiteClusteringLimitedCapacity result = new SiteClusteringLimitedCapacity(this);

            double probability = TaskController.Rnd.NextDouble();

            if (probability < 0.5)
            {
                result.MoveNodeFromOneClusterToAnother();
            }
            else
            {
                result.ExchangeNodesInClusters();
            }

            return result;
        }

        public override int CompareTo(object obj)
        {
            SiteClusteringLimitedCapacity site = obj as SiteClusteringLimitedCapacity;

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
