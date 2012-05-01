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
            Consumer
        }


        public class Point
        {
            public double x, y;

            public Point (double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public Point ScreenPosition;
        public Point RealPosition;
        public NodeType Type;

        public Node(NodeType nodeType, int screenPosX, int screenPosY, double realPosX, double realPosY)
        {
            Type = nodeType;
            ScreenPosition = new Point(screenPosX, screenPosY);
            RealPosition = new Point(realPosX, realPosY);
        }

        public List<Node> ConnectedNodes;
    }
}
