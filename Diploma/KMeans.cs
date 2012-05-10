using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class KMeans : ClusteringAlgorithm
    {
        public KMeans(List<Node> nodes, int clustersCount)
            : base(nodes, clustersCount)
        {
        }

        private Node.Point[] centers;

        private void SetCenters()
        {
            if (centers == null)
            {
                centers = new Node.Point[Clusters.Count];

                var xs = from node in Nodes
                         select node.RealPosition.x;

                double xMin = xs.Min();
                double xMax = xs.Max();

                var ys = from node in Nodes
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
                    if (Clusters[i].Nodes.Count == 0)
                        continue;

                    centers[i] = Clusters[i].Center;
                }
            }
        }

        private void GenerateClusters()
        {
            foreach (Cluster cluster in Clusters)
            {
                cluster.RemoveNodes();
            }

            foreach (Node node in Nodes)
            {
                if (node.Type != Node.NodeType.Consumer)
                    continue;

                if (IterationNumber == 0)
                {
                    bool b = false;

                    foreach (Cluster cluster in Clusters)
                    {
                        if (cluster.Nodes.Count == 0)
                        {
                            cluster.AddNode(node);

                            b = true;
                            break;
                        }
                    }

                    if (b)
                        continue;
                }

                double minDist = double.PositiveInfinity;
                Cluster closest = Clusters[0];

                for (int i = 0; i < centers.Length; i++)
                {
                    double dist = Node.Point.SqrDistance(centers[i], node.RealPosition);

                    if (dist < minDist)
                    {
                        minDist = dist;
                        closest = Clusters[i];
                    }
                }

                closest.AddNode(node);
            }
        }

        protected override void InnerIteration()
        {
            SetCenters();
            GenerateClusters();
        }


    }
}
