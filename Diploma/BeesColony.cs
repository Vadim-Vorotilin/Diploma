using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class BeesColony : Algorithm
    {
        public enum ProblemType
        {
            TSP,
            VRP,
            VRP_TSP,
            CLUSTERING,
            CLUSTERING_LIMITED_CAPASITY
        }

        public ProblemType Problem;

        public int ScoutsCount;
        public int GoodSitesCount;
        public int BestSitesCount;

        public int NeighboursForGoodSites;
        public int NeighboursForBestSites;

        public int ClustersCount;
        public int ClusterCapacityLimit;

        private List<Site> sites;

        private Site CreateNewSite ()
        {
            switch (Problem)
            {
                case ProblemType.VRP_TSP:
                    return new SiteVrpTsp(Nodes, DepotsCount, ConsumersCount, ClustersCount);
                case ProblemType.CLUSTERING:
                    return new SiteClustering(Nodes, ClustersCount);
                case ProblemType.CLUSTERING_LIMITED_CAPASITY:
                    return new SiteClusteringLimitedCapacity(Nodes, ClustersCount, ClusterCapacityLimit);
                default:
                    return null;
            }
        }

        public void CreateSites ()
        {
            sites = new List<Site>();

            for (int i = 0; i != ScoutsCount; i++)
            {
                sites.Add(CreateNewSite());
            }
        }

        private Site BestSite
        {
            get
            {
                sites.Sort();

                return sites[0];
            }
        }

        public override double Value
        {
            get { return BestSite.Price; }
        }

        protected override void InnerIteration ()
        {
            sites.Sort();

            for (int i = 0; i != BestSitesCount; i++)
            {
                while (sites[i].GoToBestNeighbour(NeighboursForBestSites)) 
                {}
            }

            for (int i = BestSitesCount; i != GoodSitesCount; i++)
            {
                while (sites[i].GoToBestNeighbour(NeighboursForGoodSites))
                {}
            }

            for (int i = GoodSitesCount; i != ScoutsCount; i++)
            {
                sites[i] = CreateNewSite();
            }
        }

        public override void DrawNodes ()
        {
            BestSite.DrawNodes();
        }

        public override string Info()
        {
            string str = "";

            switch (Problem)
            {
                case ProblemType.CLUSTERING_LIMITED_CAPASITY:
                    str = string.Format("Clusters count: {0}", (BestSite as SiteClusteringLimitedCapacity).Clusters.Count);
                    break;
            }

            return str;
        }
    }
}
