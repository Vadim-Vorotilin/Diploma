﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Diploma
{
    public abstract class ClusteringAlgorithm : Algorithm
    {
        public List<Cluster> Clusters { get; protected set; }
        protected Node Depot;

        protected int ClustersCount;

        protected void AddCluster()
        {
            Cluster newCluster = new Cluster();
            newCluster.Depot = Depot;

            Clusters.Add(newCluster);
        }

        protected ClusteringAlgorithm(List<Node> nodes)
        {
            SetNodes(nodes);

            if (Depots.Count != 0)
            {
                Depot = Depots[0];
            }
        }

        protected ClusteringAlgorithm(List<Node> nodes, int clustersCount)
            : this(nodes)
        {
            ClustersCount = clustersCount;
            Clusters = new List<Cluster>();

            for (int i = 0; i != ClustersCount; i++)
            {
                AddCluster();
            }
        }

        public override void DrawNodes()
        {
            List<Node> drawingNodes = new List<Node>();

            for (int i = 0; i != Clusters.Count; i++)
            {
                Cluster cluster = Clusters[i];

                if (cluster.Nodes.Count == 0)
                {
                    continue;
                }

                Node center = new Node(-1, Node.NodeType.Auxiliary, (int)Clusters[i].Center.x, (int)Clusters[i].Center.y, Clusters[i].Center.x, Clusters[i].Center.y);

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

            Node depot = Clusters[0].Depot;

            if (depot != null)
            {
                drawingNodes.Add(depot);
            }

            TaskController.DrawNodes(drawingNodes);
        }

        public override double Value
        {
            get
            {
                double value = 0;

                foreach (Cluster cluster in Clusters)
                {
                    value += cluster.GetPrice();
                }

                return value;
            }
        }
    }
}
