using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class SiteClustering : Site
    {
        protected Cluster[] Clusters { get; set; }

        #region Overrides of Site

        public SiteClustering(List<Node> nodes)
            : base(nodes)
        {
        }

        public SiteClustering(List<Node> nodes, int clustersCount)
            : base(nodes)
        {
            Clusters = new Cluster[clustersCount];

            GenerateClusters();
        }

        protected SiteClustering(SiteClustering site)
            : base(site.Nodes)
        {
            Clusters = new Cluster[site.Clusters.Length];

            for (int i = 0; i != Clusters.Length; i++)
            {
                Clusters[i] = new Cluster(site.Clusters[i]);
            }
        }

        protected virtual void GenerateClusters(List<Node> nodesForClusters, Node depot)
        {
            for (int i = 0; i != Clusters.Length; i++)
            {
                Clusters[i] = new Cluster();
                Clusters[i].Depot = depot;

                int nodeIndex = TaskController.Rnd.Next(nodesForClusters.Count);
                Clusters[i].Nodes.Add(nodesForClusters[nodeIndex]);
                nodesForClusters.RemoveAt(nodeIndex);
            }

            foreach (Node node in nodesForClusters)
            {
                if (node.Type == Node.NodeType.Consumer)
                {
                    int clusterIndex = TaskController.Rnd.Next(Clusters.Length);
                    Clusters[clusterIndex].Nodes.Add(node);
                }
            }
        }

        protected void GenerateClusters()
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

            GenerateClusters(nodesForClusters, depot);
        }

        protected void MoveNodeFromOneClusterToAnother(int c1, int c2)
        {
            MoveNodeFromOneClusterToAnother(Clusters[c1], Clusters[c2]);
        }

        protected void MoveNodeFromOneClusterToAnother(Cluster cluster1, Cluster cluster2)
        {
            int nodeIndex = TaskController.Rnd.Next(cluster1.Nodes.Count);

            Node node = cluster1.Nodes[nodeIndex];

            cluster1.Nodes.RemoveAt(nodeIndex);
            cluster2.Nodes.Add(node);
        }

        public void MoveNodeFromOneClusterToAnother()
        {
            int c1;
            int c2;

            do
            {
                c1 = TaskController.Rnd.Next(Clusters.Length);
            } while (Clusters[c1].Nodes.Count <= 1);

            do
            {
                c2 = TaskController.Rnd.Next(Clusters.Length);
            } while (c2 == c1);

            MoveNodeFromOneClusterToAnother(c1, c2);
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
            Clusters = (site as SiteClustering).Clusters.Clone() as Cluster[];
        }

        protected override Site GetNeighbour()
        {
            SiteClustering result = new SiteClustering(this);
            result.MoveNodeFromOneClusterToAnother();

            return result;
        }

        public override object Result
        {
            get { throw new NotImplementedException(); }
        }

        protected override void PrepareToDraw()
        {
            DrawingNodes = new List<Node>();

            foreach (Cluster cluster in Clusters)
            {
                Node center = new Node(-1, Node.NodeType.Auxiliary, (int)cluster.Center.x, (int)cluster.Center.y, cluster.Center.x, cluster.Center.y);

                foreach (Node node in cluster.Nodes)
                {
                    center.ConnectTo(node, Color.LightGray);
                    DrawingNodes.Add(node);
                }

                DrawingNodes.Add(center);
            }

            Node depot = Clusters[0].Depot;

            if (depot != null)
            {
                DrawingNodes.Add(depot);
            }
        }

        #endregion

        public override string ToString()
        {
            string str = "";

            foreach (Cluster cluster in Clusters)
            {
                str += "{";

                foreach (Node node in cluster.Nodes)
                {
                    str += node.Id + ",";
                }

                str += "}, ";
            }

            return string.Format("{0}. Price: {1}", str, Price);
        }
    }
}
