using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class BeesColony
    {
        public enum ProblemType
        {
            TSP,
            VRP,
            VRP_TSP,
            CLUSTERIZATION
        }

        public ProblemType Problem;

        public int ScoutsCount;
        public int GoodSitesCount;
        public int BestSitesCount;

        public int NeighboursForGoodSites;
        public int NeighboursForBestSites;

        private List<Node> nodes;
        public int ClustersCount;

        private int depotsCount;
        private int consumersCount;

        public void SetNodes (List<Node> nodesForSet)
        {
            nodes = new List<Node>();

            var depots = from node in nodesForSet
                         where node.Type == Node.NodeType.Depot
                         select node;

            nodes.AddRange(depots.ToList());

            depotsCount = depots.ToList().Count;

            var consumers = from node in nodesForSet
                            where node.Type == Node.NodeType.Consumer
                            select node;

            nodes.AddRange(consumers.ToList());

            consumersCount = consumers.ToList().Count;
        }

        private List<Site> sites;

        private Site CreateNewSite ()
        {
            switch (Problem)
            {
                case ProblemType.VRP_TSP:
                    return new SiteVrpTsp(nodes, depotsCount, consumersCount, ClustersCount);
                case ProblemType.CLUSTERIZATION:
                    return null;
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

        public void Iteration ()
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

        public void DrawNodes ()
        {
            for (int i = 0; i != nodes.Count; i++)
            {
                nodes[i].ConnectedNodes = new List<Node>();
            }

            int[] result = sites[0].Result as int[];

            for (int i = 0; i != result.Length - 1; i++)
            {
                nodes[result[i]].ConnectedNodes.Add(nodes[result[i + 1]]);
            }

            nodes[result[result.Length - 1]].ConnectedNodes.Add(nodes[result[0]]);

            TaskController.Nodes = this.nodes;

            TaskController.DrawNodes();
        }
    }
}
