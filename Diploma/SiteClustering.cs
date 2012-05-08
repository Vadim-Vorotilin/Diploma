using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class SiteClustering : Site
    {
        public Cluster[] Clusters { get; private set; }

        #region Overrides of Site

        public SiteClustering(List<Node> nodes, int clustersCount)
            : base(nodes)
        {
            Clusters = new Cluster[clustersCount];

            GenerateClusters();
        }

        private SiteClustering(SiteClustering site)
            : base(site.Nodes)
        {
            Clusters = new Cluster[site.Clusters.Length];

            for (int i = 0; i != Clusters.Length; i++)
            {
                Clusters[i] = new Cluster(site.Clusters[i]);
            }
        }

        private void GenerateClusters()
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

            List<Node> nodesForClusters = new List<Node>();
            nodesForClusters.AddRange(Nodes);

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

            int nodeIndex = TaskController.Rnd.Next(Clusters[c1].Nodes.Count);

            Node node = Clusters[c1].Nodes[nodeIndex];

            Clusters[c1].Nodes.RemoveAt(nodeIndex);
            Clusters[c2].Nodes.Add(node);
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
                    center.ConnectedNodes.Add(node);
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
