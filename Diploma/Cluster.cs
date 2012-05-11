using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Diploma
{
    public class Cluster
    {
        public List<Node> Nodes = new List<Node>();
        public Node Depot;

        private bool nodesUpdated = true;
        private Node.Point center;

        private const double sqrt2 = 1.4142135623730950488016887242097;

        public Node.Point Center
        {
            get
            {
                if (!nodesUpdated)
                {
                    return center;
                }

                if (Nodes.Count == 0)
                {
                    return null;
                }

                double sx = 0;
                double sy = 0;

                foreach (Node node in Nodes)
                {
                    sx += node.RealPosition.x;
                    sy += node.RealPosition.y;
                }

                center = new Node.Point(sx / Nodes.Count, sy / Nodes.Count);
                nodesUpdated = false;

                return center;
            }
        }

        public double GetPrice ()
        {
            Node.Point center = Center;

            double distance = 0;

            foreach (Node node in Nodes)
            {
                distance += Node.Point.SqrDistance(node.RealPosition, center);
            }

            if (Depot != null)
            {
                distance += 2 * Node.Point.SqrDistance(Depot.RealPosition, center);
            }

            return distance;
        }

        public int Volume
        {
            get
            {
                int volume = 0;

                foreach (Node node in Nodes)
                {
                    volume += node.Volume;
                }

                return volume;
            }
        }

        public Cluster() {}

        public Cluster(Cluster cluster)
        {
            Nodes = new List<Node>();

            foreach (Node node in cluster.Nodes)
            {
                Nodes.Add(node);
            }

            Depot = cluster.Depot;
        }

        public List<Node> GetDrawingNodes(Color connectionsColor)
        {
            List<Node> drawingNodes = new List<Node>();

            Node center = new Node(-1, Node.NodeType.Auxiliary, (int)Center.x, (int)Center.y, Center.x, Center.y);

            foreach (Node node in Nodes)
            {
                center.ConnectTo(node, connectionsColor);
                drawingNodes.Add(node);
            }

            drawingNodes.Add(center);

            return drawingNodes;
        }

        public void Merge(Cluster cluster)
        {
            Nodes.AddRange(cluster.Nodes);
            Nodes = Nodes.Distinct().ToList();
            nodesUpdated = true;
        }

        public void AddNode(Node node)
        {
            Nodes.Add(node);
            nodesUpdated = true;
        }

        public void RemoveNodes()
        {
            Nodes.Clear();
            nodesUpdated = true;
        }

        public void RemoveNode(Node node)
        {
            Nodes.Remove(node);
            nodesUpdated = true;
        }
    }
}