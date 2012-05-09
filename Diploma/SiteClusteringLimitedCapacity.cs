using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class SiteClusteringLimitedCapacity : SiteClustering
    {
        private readonly int capacityLimit;
            
        public SiteClusteringLimitedCapacity (List<Node> nodes, int clustersCount, int capacityLimit) 
            : base(nodes)
        {
            Clusters = new Cluster[clustersCount];
            this.capacityLimit = capacityLimit;

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

        protected override void GenerateClusters(List<Node> nodesForClusters, Node depot)
        {
            for (int i = 0; i != Clusters.Length; i++)
            {
                Clusters[i] = new Cluster();
                Clusters[i].Depot = depot;
            }

            nodesForClusters.Sort();
            nodesForClusters.Reverse();

            while (nodesForClusters.Count != 0)
            {
                for (int i = 0; i != Clusters.Length; i++)
                {
                    if (nodesForClusters.Count == 0)
                        break;

                    if (Clusters[i].Volume + nodesForClusters[0].Volume <= capacityLimit)
                    {
                        Clusters[i].Nodes.Add(nodesForClusters[0]);
                        nodesForClusters.RemoveAt(0);
                    }
                }
            }
        }

        public void MoveNodeFromBadClusterToGood()
        {
            List<Cluster> badClusters = (from cluster in Clusters
                                         where cluster.Volume > capacityLimit
                                         select cluster).ToList();

            List<Cluster> goodClusters = (from cluster in Clusters
                                          where cluster.Volume <= capacityLimit
                                          select cluster).ToList();

            if (badClusters.Count == 0)
            {
                MoveNodeFromOneClusterToAnother();
            }
            else
            {
                MoveNodeFromOneClusterToAnother(badClusters[TaskController.Rnd.Next(badClusters.Count)], goodClusters[TaskController.Rnd.Next(goodClusters.Count)]);
            }
        }

        protected override Site GetNeighbour()
        {
            SiteClusteringLimitedCapacity result = new SiteClusteringLimitedCapacity(this);
            result.MoveNodeFromBadClusterToGood();

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
