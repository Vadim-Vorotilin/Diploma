using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class KMeans : Algorithm
    {
        private Cluster[] clusters;
        private Node depot;

        public KMeans(List<Node> nodes, int clustersCount)
        {
            SetNodes(nodes);

            clusters = new Cluster[clustersCount];

            if (Nodes[0].Type == Node.NodeType.Depot)
            {
                depot = Nodes[0];
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
                    if (clusters[i].Nodes.Count == 0)
                        continue;

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

            foreach (Node node in Nodes)
            {
                if (node.Type != Node.NodeType.Consumer)
                    continue;

                if (IterationNumber == 0)
                {
                    bool b = false;

                    foreach (Cluster cluster in clusters)
                    {
                        if (cluster.Nodes.Count == 0)
                        {
                            cluster.Nodes.Add(node);

                            b = true;
                            break;
                        }
                    }

                    if (b)
                        continue;
                }

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

        public override double Value
        {
            get
            {
                double value = 0;

                foreach (Cluster cluster in clusters)
                {
                    value += cluster.GetPrice();
                }

                return value;
            }
        }

        protected override void InnerIteration()
        {
            SetCenters();
            GenerateClusters();
        }

        public override void DrawNodes()
        {
            List<Node> drawingNodes = new List<Node>();

            for (int i = 0; i != clusters.Length; i++)
            {
                Cluster cluster = clusters[i];

                Node center = new Node(-1, Node.NodeType.Auxiliary, (int)centers[i].x, (int)centers[i].y, centers[i].x, centers[i].y);

                if (cluster.Nodes.Count == 0)
                {
                    drawingNodes.Add(center);
                    continue;
                }

                foreach (Node node in cluster.Nodes)
                {
                    center.ConnectTo(node, Color.LightGray);
                    drawingNodes.Add(node);
                }

                drawingNodes.Add(center);
            }

            Node depot = clusters[0].Depot;

            if (depot != null)
            {
                drawingNodes.Add(depot);
            }

            TaskController.DrawNodes(drawingNodes); 
        }
    }
}
