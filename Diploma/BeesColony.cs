using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class BeesColony : Algorithm
    {
        public enum ProblemType
        {
            VRP_TSP,
            CLUSTERING_VRP,
            CLUSTERING_CVRP,
            CLUSTERING_CVRPP
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
                case ProblemType.CLUSTERING_VRP:
                    return new SiteClusteringVrp(Nodes, ClustersCount);
                case ProblemType.CLUSTERING_CVRP:
                    return new SiteClusteringCvrp(Nodes, ClustersCount, ClusterCapacityLimit);
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

        public Site BestSite
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
            if (IterationNumber > 100 && (IterationNumber < 500 && IterationNumber > LastChangedIteration * 3.0 || IterationNumber > 500 && IterationNumber > LastChangedIteration * 1.5))
            {
                Stop();
                return;
            }

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
                case ProblemType.CLUSTERING_CVRP:
                    str = string.Format("Clusters count: {0}", (BestSite as SiteClusteringCvrp).Clusters.Count);
                    break;
            }

            return str;
        }
    }
}
