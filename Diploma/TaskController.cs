﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Diploma
{
    public static class TaskController
    {
        public static Brush ConsumerBrush = new SolidBrush(Color.Red);
        public static int ConsumerSize = 7;

        public static Brush DepotBrush = new SolidBrush(Color.Blue);
        public static int DepotSize = 12;

        public static Pen ConnectionsPen = new Pen(Color.Black, 2.0f);

        public static Color ClearColor = Color.White;

        public static List<Node> Nodes = new List<Node>();

        private static Graphics graphicsForDraw;
        public static Graphics GraphicsForDraw
        {
            set 
            { 
                graphicsForDraw = value; 
                graphicsForDraw.Clear(ClearColor); 
            }
        }

        public static void AddNodeAtScreen (Node.NodeType nodeType, int posX, int posY)
        {
            Node newNode = new Node(nodeType, posX, posY, posX, posY);
            DrawNode(graphicsForDraw, newNode);

            Nodes.Add(newNode);
        }

        public static void DrawNodes ()
        {
            DrawNodes(graphicsForDraw);
        }

        public static void DrawNodes (Graphics g)
        {
            g.Clear(ClearColor);

            foreach (Node node in Nodes)
            {
                DrawNode(g, node);

                foreach (Node connectedNode in node.ConnectedNodes)
                {
                    g.DrawLine(ConnectionsPen, (int)node.ScreenPosition.x, (int)node.ScreenPosition.y, (int)connectedNode.ScreenPosition.x, (int)connectedNode.ScreenPosition.y);
                }
            }
        }

        private static void DrawNode (Graphics g, Node node)
        {
            switch (node.Type)
            {
                case Node.NodeType.Consumer:
                    g.FillEllipse(ConsumerBrush, (int)node.ScreenPosition.x, (int)node.ScreenPosition.y, ConsumerSize, ConsumerSize);
                    break;

                case Node.NodeType.Depot:
                    g.FillRectangle(DepotBrush, (int)(node.ScreenPosition.x - DepotSize / 2.0), (int)(node.ScreenPosition.y - DepotSize / 2.0), DepotSize, DepotSize);
                    break;
            }
        }
    }
}
