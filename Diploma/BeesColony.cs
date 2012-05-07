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
            VRP
        }

        public int ScoutsCount;
        public int GoodSitesCount;
        public int BestSitesCount;

        public int NeighboursForGoodSites;
        public int NeighboursForBestSites;

        private List<Node> nodes;
        public int ClustersCount;

        private double[,] prices;

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

        public void CreateSites ()
        {
            sites = new List<Site>();

            for (int i = 0; i != ScoutsCount; i++)
            {
                sites.Add(new Site(nodes, depotsCount, ClustersCount, consumersCount));
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
        }

        public void DrawNodes ()
        {
            for (int i = 0; i != nodes.Count; i++)
            {
                nodes[i].ConnectedNodes = new List<Node>();
            }

            for (int i = 0; i != sites[0].NodesSequence.Length - 1; i++)
            {
                nodes[sites[0].NodesSequence[i]].ConnectedNodes.Add(nodes[sites[0].NodesSequence[i + 1]]);
            }

            nodes[sites[0].NodesSequence[sites[0].NodesSequence.Length - 1]].ConnectedNodes.Add(nodes[sites[0].NodesSequence[0]]);

            TaskController.Nodes = this.nodes;

            TaskController.DrawNodes();
        }
    }
}
