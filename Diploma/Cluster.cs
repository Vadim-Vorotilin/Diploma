using System.Collections.Generic;

namespace Diploma
{
    public class Cluster
    {
        public List<Node> Nodes = new List<Node>();
        public Node Depot;

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
                distance += Node.Point.SqrDistance(Depot.RealPosition, center);
            }

            return distance;
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
    }
}