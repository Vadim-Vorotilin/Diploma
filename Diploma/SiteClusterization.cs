using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class SiteClusterization : Site
    {
        private Cluster[] clusters;

        private class Cluster
        {
            public List<Node> Nodes = new List<Node>();

            public Node.Point Center
            {
                get
                {
                    double sx = 0;
                    double sy = 0;

                    foreach (Node node in Nodes)
                    {
                        sx += node.RealPosition.x;
                        sy += node.RealPosition.y;
                    }

                    return new Node.Point(sx / Nodes.Count, sy / Nodes.Count);
                }
            }
        }

        #region Overrides of Site

        public SiteClusterization(List<Node> nodes, int clustersCount)
            : base(nodes)
        {
            clusters = new Cluster[clustersCount];
            GenerateClusters();
        }

        private void GenerateClusters()
        {
            foreach (Node node in Nodes)
            {
                if (node.Type == Node.NodeType.Consumer)
                {
                    int clusterIndex = TaskController.Rnd.Next(clusters.Length);
                    clusters[clusterIndex].Nodes.Add(node);
                }
            }
        }

        protected override double Price
        {
            get { throw new NotImplementedException(); }
        }

        protected override void GoToNeighbour(Site site)
        {
            throw new NotImplementedException();
        }

        protected override Site GetNeighbour()
        {
            throw new NotImplementedException();
        }

        public override object Result
        {
            get { throw new NotImplementedException(); }
        }

        protected override void PrepareToDraw()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
