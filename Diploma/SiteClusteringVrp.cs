using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class SiteClusteringVrp : Site
    {
        public List<Cluster> Clusters { get; protected set; }
        protected int ClustersCount;

        #region Overrides of Site

        public SiteClusteringVrp(List<Node> nodes)
            : base(nodes)
        {
        }

        public SiteClusteringVrp(List<Node> nodes, int clustersCount)
            : base(nodes)
        {
            Clusters = new List<Cluster>();
            ClustersCount = clustersCount;

            GenerateClusters();
        }

        protected SiteClusteringVrp(SiteClusteringVrp site)
            : base(site.Nodes)
        {
            Clusters = new List<Cluster>();

            for (int i = 0; i != site.Clusters.Count; i++)
            {
                Clusters.Add(new Cluster(site.Clusters[i]));
            }
        }

        protected virtual List<Node> GenerateClusters(List<Node> nodesForClusters, Node _depot)
        {
            for (int i = 0; i != ClustersCount; i++)
            {
                Clusters.Add(new Cluster());
                Clusters[i].Depot = _depot;

                int nodeIndex = TaskController.Rnd.Next(nodesForClusters.Count);
                Clusters[i].AddNode(nodesForClusters[nodeIndex]);
                nodesForClusters.RemoveAt(nodeIndex);
            }

            foreach (Node node in nodesForClusters)
            {
                if (node.Type == Node.NodeType.Consumer)
                {
                    int clusterIndex = TaskController.Rnd.Next(Clusters.Count);
                    Clusters[clusterIndex].AddNode(node);
                }
            }

            List<Node> remainingNodes = new List<Node>();
            remainingNodes.AddRange(nodesForClusters);

            return remainingNodes;
        }

        protected List<Node> GenerateClusters()
        {
            Node depot = null;
            
            foreach (Node node in Nodes)
            {
                if (node.Type == Node.NodeType.Depot)
                {
                    depot = node;
                    break;
                }
            }

            List<Node> nodesForClusters = (from node in Nodes 
                                           where node.Type == Node.NodeType.Consumer
                                           select node).ToList();

            return GenerateClusters(nodesForClusters, depot);
        }

        protected void MoveNodeFromOneClusterToAnother(int c1, int c2)
        {
            MoveNodeFromOneClusterToAnother(Clusters[c1], Clusters[c2]);
        }

        protected static void MoveNodeFromOneClusterToAnother(Cluster cluster1, Cluster cluster2)
        {
            int nodeIndex = TaskController.Rnd.Next(cluster1.Nodes.Count);

            Node node = cluster1.Nodes[nodeIndex];

            cluster1.RemoveNode(node);
            cluster2.AddNode(node);
        }

        public static void MoveNodeFromOneClusterToAnother(List<Cluster> clusters)
        {
            if (clusters.Count <= 1)
            {
                return;
            }

            int c1;
            int c2;

            do
            {
                c1 = TaskController.Rnd.Next(clusters.Count);
            } while (clusters[c1].Nodes.Count <= 1);

            do
            {
                c2 = TaskController.Rnd.Next(clusters.Count);
            } while (c2 == c1);

            MoveNodeFromOneClusterToAnother(clusters[c1], clusters[c2]);
        }

        public override double Price
        {
            get
            {
                double price = 0;

                foreach (Cluster cluster in Clusters)
                {
                    price += cluster.GetPrice();
                }

                return price;
            }
        }

        protected override void GoToNeighbour(Site site)
        {
            Clusters = new List<Cluster>();
            Clusters.AddRange((site as SiteClusteringVrp).Clusters);
        }

        protected override Site GetNeighbour()
        {
            SiteClusteringVrp result = new SiteClusteringVrp(this);
            MoveNodeFromOneClusterToAnother(result.Clusters);

            return result;
        }

        public override object Result
        {
            get { throw new NotImplementedException(); }
        }

        public override List<Node> PrepareToDraw(Color connectionsColor)
        {
            DrawingNodes = new List<Node>();

            foreach (Cluster cluster in Clusters)
            {
                DrawingNodes.AddRange(cluster.GetDrawingNodes(Color.LightGray));
            }

            Node depot = Clusters[0].Depot;

            if (depot != null)
            {
                DrawingNodes.Add(depot);
            }

            return DrawingNodes;
        }

        #endregion

        public override string ToString()
        {
            string str = "";

            foreach (Cluster cluster in Clusters)
            {
                str += cluster.ToString() + ", ";
            }

            return string.Format("{0}. Price: {1}", str, Price);
        }
    }
}
