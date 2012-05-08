using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class KMeans
    {
        private List<Node> nodes;
        private Cluster[] clusters;
        private Node depot;

        public KMeans(List<Node> nodes, int clustersCount)
        {
            this.nodes = new List<Node>();
            this.nodes.AddRange(nodes);

            clusters = new Cluster[clustersCount];

            foreach (Node node in nodes)
            {
                if (node.Type == Node.NodeType.Depot)
                {
                    depot = node;
                    break;
                }
            }

            for (int i = 0; i != clusters.Length; i++)
            {
                clusters[i] = new Cluster();
                clusters[i].Depot = depot;
            }
        }

        private Node.Point[] centers;

        private void SetCenters()
        {
            if (centers == null)
            {
                centers = new Node.Point[clusters.Length];

                var xs = from node in nodes
                         select node.RealPosition.x;

                double xMin = xs.Min();
                double xMax = xs.Max();

                var ys = from node in nodes
                         select node.RealPosition.y;

                double yMin = ys.Min();
                double yMax = ys.Max();

                for (int i = 0; i != centers.Length; i++)
                {
                    double cx = TaskController.Rnd.NextDouble() * (xMax - xMin) + xMin;
                    double cy = TaskController.Rnd.NextDouble() * (yMax - yMin) + yMin;

                    centers[i] = new Node.Point(cx, cy);
                }

            }
            else
            {
                for (int i = 0; i != centers.Length; i++)
                {
                    centers[i] = clusters[i].Center;
                }
            }
        }

        private void GenerateClusters()
        {
            foreach (Cluster cluster in clusters)
            {
                cluster.Nodes.Clear();
            }

            foreach (Node node in nodes)
            {
                double minDist = double.PositiveInfinity;
                Cluster closest = clusters[0];

                for (int i = 0; i < centers.Length; i++)
                {
                    double dist = Node.Point.SqrDistance(centers[i], node.RealPosition);

                    if (dist < minDist)
                    {
                        minDist = dist;
                        closest = clusters[i];
                    }
                }

                closest.Nodes.Add(node);
            }
        }

        //private void 

        public void Iteration()
        {
            SetCenters();
            GenerateClusters();
        }
    }
}
