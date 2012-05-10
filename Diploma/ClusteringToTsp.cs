using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    class ClusteringToTsp : Algorithm
    {
        private List<Cluster> clusters;
        private List<double> values;
        private List<BeesColony> colonies; 

        public ClusteringToTsp (List<Cluster> clusters)
        {
            this.clusters = clusters;
        }

        public void Calculate(int scoutsCount, int goodSitesCount, int bestSitesCount, int neighboursForGoodSites, int neighboursForBestSites)
        {
            values = new List<double>();
            colonies = new List<BeesColony>();

            foreach (Cluster cluster in clusters)
            {
                BeesColony colony = new BeesColony();

                colony.Problem = BeesColony.ProblemType.VRP_TSP;
                colony.ClustersCount = 1;

                colony.ScoutsCount = scoutsCount;
                colony.GoodSitesCount = goodSitesCount;
                colony.BestSitesCount = bestSitesCount;
                colony.NeighboursForGoodSites = neighboursForGoodSites;
                colony.NeighboursForBestSites = neighboursForBestSites;

                List<Node> colonyNodes = new List<Node>();
                colonyNodes.AddRange(cluster.Nodes);
                colonyNodes.Add(cluster.Depot);

                colony.SetNodes(colonyNodes);

                colony.CreateSites();

                colony.IterateToStop();

                values.Add(colony.Value);
                colonies.Add(colony);
            }
        }

        public override double Value
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

        protected override void InnerIteration()
        {
            throw new NotImplementedException();
        }

        public override void DrawNodes()
        {
            List<Node> drawingNodes = new List<Node>();

            foreach (BeesColony colony in colonies)
            {
                colony.BestSite.PrepareToDraw();
                drawingNodes.AddRange(colony.BestSite.DrawingNodes);
                
            }

            foreach (Cluster cluster in clusters)
            {
                drawingNodes.AddRange(cluster.GetDrawingNodes());
            }

            TaskController.DrawNodes(drawingNodes); 
        }
    }
}
