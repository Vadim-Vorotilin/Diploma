using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Diploma
{
    class ClusteringToTsp : Algorithm
    {
        private List<Cluster> clusters;
        private List<Node> notClusteredNodes;
        private List<double> values;
        private List<BeesColony> colonies;
        private double kilometerCost;

        public ClusteringToTsp (List<Cluster> clusters, List<Node> notClusteredNodes, double kilometerCost)
        {
            this.clusters = clusters;
            this.notClusteredNodes = notClusteredNodes;
            this.kilometerCost = kilometerCost;
        }

        public void Calculate(int scoutsCount, int goodSitesCount, int bestSitesCount, int neighboursForGoodSites, int neighboursForBestSites)
        {
            values = new List<double>();
            colonies = new List<BeesColony>();

            foreach (Cluster cluster in clusters)
            {
                if (cluster.Nodes.Count == 0)
                {
                    continue;
                }

                BeesColony colony = new BeesColony();

                colony.Problem = BeesColony.ProblemType.VRP_TSP;
                colony.ClustersCount = 1;
                colony.IsCalcLastChange = true;

                colony.ScoutsCount = scoutsCount;
                colony.GoodSitesCount = goodSitesCount;
                colony.BestSitesCount = bestSitesCount;
                colony.NeighboursForGoodSites = neighboursForGoodSites;
                colony.NeighboursForBestSites = neighboursForBestSites;

                List<Node> colonyNodes = new List<Node>();
                colonyNodes.AddRange(cluster.Nodes);

                if (cluster.Depot != null)
                {
                    colonyNodes.Add(cluster.Depot);
                }

                colony.SetNodes(colonyNodes);
                colony.CreateSites();
                colony.IterateToStop();

                values.Add(colony.Value);
                colonies.Add(colony);
            }

            Stop();
        }

        private double SumValue
        {
            get 
            {
                if (values == null)
                {
                    return -1;
                }

                return values.Sum();
            }
        }

        public override double Value
        {
            get
            {
                if (notClusteredNodes == null)
                {
                    return SiteClusteringCvrpp.GetPrice(SumValue, kilometerCost, 0);
                }

                double fines = (from node in notClusteredNodes
                                select node.Fine).Sum();

                return SiteClusteringCvrpp.GetPrice(SumValue, kilometerCost, fines);
            }
        }

        protected override void InnerIteration()
        {
            //throw new NotImplementedException();
        }

        public override void DrawNodes()
        {
            List<Node> drawingNodes = new List<Node>();

            for (int i = 0; i != colonies.Count; i++)
            {
                drawingNodes.AddRange(colonies[i].BestSite.PrepareToDraw(TaskController.GetDrawingColor(i)));
            }

            if (notClusteredNodes != null)
            {
                drawingNodes.AddRange(notClusteredNodes);
            }

            TaskController.DrawNodes(drawingNodes); 
        }
    }
}
