using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Diploma
{
    public class Node : IComparable
    {
        public enum NodeType
        {
            Depot,
            Consumer,
            Auxiliary,
            Unknown
        }


        public class Point
        {
            public double x;
            public double y;

            public Point ()
            {
                x = 0;
                y = 0;
            }

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

        public class Connection
        {
            public Node ConnectedNode;
            public Color Color;
        }

        public Point ScreenPosition;
        public Point RealPosition;
        public NodeType Type;

        public int Fine;

        public int Volume;

        public int Id;

        public Node(int id, NodeType nodeType, int screenPosX, int screenPosY, double realPosX, double realPosY)
        {
            Id = id;
            Type = nodeType;
            ScreenPosition = new Point(screenPosX, screenPosY);
            RealPosition = new Point(realPosX, realPosY);

            Connections = new List<Connection>();
        }

        public Node()
        {
            Id = -1;
            Type = NodeType.Unknown;
            ScreenPosition = new Point(0, 0);
            RealPosition = new Point(0, 0);
            Volume = 0;
            Fine = 0;

            Connections = new List<Connection>();
        }

        public Node(Node node)
        {
            Id = node.Id;
            Type = node.Type;
            ScreenPosition = node.ScreenPosition;
            RealPosition = node.RealPosition;
            Volume = node.Volume;

            Connections = new List<Connection>(); 
            Connections.AddRange(node.Connections);
        }

        [XmlIgnore]
        public List<Connection> Connections;

        public void ConnectTo(Node node)
        {
            ConnectTo(node, Color.Black);
        }

        public void ConnectTo(Node node, Color color)
        {
            Connections.Add(new Connection {Color = color, ConnectedNode = node});
        }

        public void DisconnectFromAll()
        {
            Connections.Clear();
        }

        public override string ToString()
        {
            return string.Format("Node {0}:{1}. Volume: {2}", Id, Type, Volume);
        }

        public int CompareTo(object obj)
        {
            Node node = obj as Node;

            return Volume.CompareTo(node.Volume);
        }
    }
}
