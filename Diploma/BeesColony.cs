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

        private List<Node> nodes;
        public int ClustersCount;

        public double[,] Prices;

        private int depotsCount;
        private int consumersCount;

        public void GeneratePricesByPositions ()
        {
            Prices = new double[depotsCount * ClustersCount + consumersCount, depotsCount * ClustersCount + consumersCount];

            for (int i = 0; i != Prices.GetLength(0); i++)
            {
                for (int j = 0; j != Prices.GetLength(0); j++)
                {
                    if (i < depotsCount * ClustersCount && j < depotsCount * ClustersCount)
                    {
                        Prices[i, j] = double.PositiveInfinity;
                    }
                    else if (i < depotsCount * ClustersCount)
                    {
                        Prices[i, j] = GetDistance(nodes[i / ClustersCount], nodes[j - ((ClustersCount - 1) * depotsCount)]);
                    }
                    else if (j < depotsCount * ClustersCount)
                    {
                        Prices[i, j] = GetDistance(nodes[i - ((ClustersCount - 1) * depotsCount)], nodes[j / ClustersCount]);
                    }
                    else
                    {
                        Prices[i, j] = GetDistance(nodes[i - ((ClustersCount - 1) * depotsCount)], nodes[j - ((ClustersCount - 1) * depotsCount)]);
                    }
                }
            }
        }

        private double GetDistance (Node node1, Node node2)
        {
            return Math.Sqrt(Math.Pow(node1.RealPosition.x - node2.RealPosition.x, 2) + Math.Pow(node1.RealPosition.y - node2.RealPosition.y, 2));
        }

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
    }
}
