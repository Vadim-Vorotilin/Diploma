using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class SiteClusteringLimitedCapacity : SiteClustering
    {
        private int capacityLimit;
            
        public SiteClusteringLimitedCapacity (List<Node> nodes, int clustersCount, int capacityLimit) 
            : base(nodes, clustersCount)
        {
            this.capacityLimit = capacityLimit;
        }

        public SiteClusteringLimitedCapacity (SiteClusteringLimitedCapacity site)
            : base(site.Nodes, site.Clusters.Length)
        {
            this.capacityLimit = site.capacityLimit;
        }

        public int UnderLimitClustersCount { get; private set; }

        public override double Price
        {
            get
            {
                double price = 0;
                UnderLimitClustersCount = 0;

                foreach (Cluster cluster in Clusters)
                {
                    int volume = cluster.GetVolume();

                    if (volume <= capacityLimit)
                    {
                        price += cluster.GetPrice();
                        UnderLimitClustersCount++;
                    }
                    else
                    {
                        price += double.PositiveInfinity;
                    }
                }

                return price;
            }
        }

        public void MoveNodeFromBadClusterToGood()
        {
            List<Cluster> badClusters = (from cluster in Clusters
                                         where cluster.GetVolume() > capacityLimit
                                         select cluster).ToList();

            List<Cluster> goodClusters = (from cluster in Clusters
                                          where cluster.GetVolume() <= capacityLimit
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
