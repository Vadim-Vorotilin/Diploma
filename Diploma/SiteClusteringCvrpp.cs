using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class SiteClusteringCvrpp : SiteClusteringCvrp
    {
        protected Cluster PenaltyCluster;
        private double kilometerCost;

        private List<Cluster> allClusters;

        public SiteClusteringCvrpp(List<Node> nodes, int capacityLimit, int clustersCount, double kilometerCost)
            : base(nodes, capacityLimit, clustersCount)
        {
            PenaltyCluster = new Cluster();
            PenaltyCluster.AddNodes(RemainingNodes);

            this.kilometerCost = kilometerCost;

            FormAllClusters();
        }

        private SiteClusteringCvrpp(SiteClusteringCvrpp site) 
            : base(site)
        {
            PenaltyCluster = new Cluster(site.PenaltyCluster);
            kilometerCost = site.kilometerCost;

            FormAllClusters();
        }

        protected void FormAllClusters()
        {
            allClusters = new List<Cluster>();
            allClusters.AddRange(Clusters);
            allClusters.Add(PenaltyCluster);

            NotClusteredNodes = PenaltyCluster.Nodes;
        }

        public double EstimateLength
        {
            get { return base.Price / 500.0; }
        }

        public double Fines
        {
            get
            {
                return (from node in PenaltyCluster.Nodes 
                        select node.Fine).Sum();
            }
        }

        public static double GetPrice(double length, double kilometerCost, double fines)
        {
            return (length / 10.0) * kilometerCost + fines;
        }

        public override double Price
        {
            get { return GetPrice(EstimateLength, kilometerCost, Fines); }
        }

        protected override Site GetNeighbour()
        {
            SiteClusteringCvrpp result = new SiteClusteringCvrpp(this);

            double probability = TaskController.Rnd.NextDouble();

            if (probability < 0.5)
            {
                MoveNodeFromOneClusterToAnother(result.allClusters);
            }
            else
            {
                ExchangeNodesInClusters(result.allClusters);
            }

            return result;
        }

        public override List<Node> PrepareToDraw(System.Drawing.Color connectionsColor)
        {
            List<Node> drawingNodes = new List<Node>();
            drawingNodes.AddRange(base.PrepareToDraw(connectionsColor));

            foreach (Node node in PenaltyCluster.Nodes)
            {
                node.DisconnectFromAll();
                drawingNodes.Add(node);
            }

            return drawingNodes;
        }

        protected override void GoToNeighbour(Site site)
        {
            SiteClusteringCvrpp siteClusteringCvrpp = site as SiteClusteringCvrpp;

            Clusters = new List<Cluster>();
            Clusters.AddRange(siteClusteringCvrpp.Clusters);

            kilometerCost = siteClusteringCvrpp.kilometerCost;
            PenaltyCluster = new Cluster(siteClusteringCvrpp.PenaltyCluster);

            FormAllClusters();
        }

        public override string ToString()
        {
            return string.Format("{0}. Penalty cluster: {1}. Estimate length: {2:0.000}. Fines: {3}", base.ToString(), PenaltyCluster, EstimateLength, Fines);
        }
    }
}
