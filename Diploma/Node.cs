using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class Node
    {
        public enum NodeType
        {
            Depot,
            Consumer,
            Auxiliary
        }


        public class Point
        {
            public double x, y;

            public Point (double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public static double Distance (Point p1, Point p2)
            {
                return Math.Sqrt(SqrDistance(p1, p2));
            }

            public static double SqrDistance(Point p1, Point p2)
            {
                return Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2);
            }
        }

        public Point ScreenPosition;
        public Point RealPosition;
        public NodeType Type;

        public int Id;

        public Node(int id, NodeType nodeType, int screenPosX, int screenPosY, double realPosX, double realPosY)
        {
            Id = id;
            Type = nodeType;
            ScreenPosition = new Point(screenPosX, screenPosY);
            RealPosition = new Point(realPosX, realPosY);

            ConnectedNodes = new List<Node>();
        }

        public List<Node> ConnectedNodes;

        public override string ToString()
        {
            return string.Format("Node {0}:{1}", Id, Type);
        }
    }
}
