using System;
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

        public static Brush AuxiliaryBrush = new SolidBrush(Color.Lime);
        public static int AuxiliarySize = 9;
        
        public static Pen ConnectionsPen = new Pen(Color.Black, 2.0f);

        public static Color ClearColor = Color.White;

        public static List<Node> Nodes { get; private set; }

        private static string lastFileName;

        private static Graphics graphicsForDraw;
        public static Graphics GraphicsForDraw
        {
            set 
            { 
                graphicsForDraw = value; 
                graphicsForDraw.Clear(ClearColor); 
            }
        }

        public static Algorithm Algorithm;

        public static Random Rnd = new Random();

        static TaskController()
        {
            Nodes = new List<Node>();
            lastFileName = "";
        }

        public static void AddNodeAtScreen (Node.NodeType nodeType, int posX, int posY)
        {
            Node newNode = new Node(Nodes.Count, nodeType, posX, posY, posX, posY);
            DrawNode(graphicsForDraw, newNode);

            Nodes.Add(newNode);
        }

        public static void DrawNodes (List<Node> nodes = null)
        {
            DrawNodes(graphicsForDraw, nodes ?? Nodes);
        }

        public static void DrawNodes (Graphics g, List<Node> nodes)
        {
            g.Clear(ClearColor);

            foreach (Node node in nodes)
            {
                if (node.ConnectedNodes == null)
                    continue;

                foreach (Node connectedNode in node.ConnectedNodes)
                {
                    g.DrawLine(ConnectionsPen, (int)node.ScreenPosition.x, (int)node.ScreenPosition.y, (int)connectedNode.ScreenPosition.x, (int)connectedNode.ScreenPosition.y);
                }
            }

            foreach (Node node in nodes)
            {
                DrawNode(g, node);
            }
        }

        private static void DrawNode (Graphics g, Node node)
        {
            switch (node.Type)
            {
                case Node.NodeType.Consumer:
                    g.FillEllipse(ConsumerBrush, (int)(node.ScreenPosition.x - ConsumerSize / 2.0), (int)(node.ScreenPosition.y - ConsumerSize / 2.0), ConsumerSize, ConsumerSize);
                    break;

                case Node.NodeType.Depot:
                    g.FillRectangle(DepotBrush, (int)(node.ScreenPosition.x - DepotSize / 2.0), (int)(node.ScreenPosition.y - DepotSize / 2.0), DepotSize, DepotSize);
                    break;

                case Node.NodeType.Auxiliary:
                    g.FillEllipse(AuxiliaryBrush, (int)(node.ScreenPosition.x - AuxiliarySize / 2.0), (int)(node.ScreenPosition.y - AuxiliarySize / 2.0), AuxiliarySize, AuxiliarySize);
                    break;
            }
        }

        public static void StartBeesAlgorithm(BeesColony.ProblemType problemType, int clustersCount, int scoutsCount, 
            int goodSitesCount, int bestSitesCount, int neighboursForGoodSites, int neighboursForBestSites)
        {
            BeesColony colony = new BeesColony();

            colony.Problem = problemType;
            colony.ClustersCount = clustersCount;

            colony.ScoutsCount = scoutsCount;
            colony.GoodSitesCount = goodSitesCount;
            colony.BestSitesCount = bestSitesCount;
            colony.NeighboursForGoodSites = neighboursForGoodSites;
            colony.NeighboursForBestSites = neighboursForBestSites;

            colony.SetNodes(Nodes);

            colony.CreateSites();

            SetAlgorithm(colony);
        }

        public static void StartKMeansAlgorithm(int clustersCount)
        {
            KMeans kMeans = new KMeans(Nodes, clustersCount);

            SetAlgorithm(kMeans);
        }

        private static void SetAlgorithm(Algorithm algorithm)
        {
            foreach (Node node in Nodes)
            {
                node.ConnectedNodes.Clear();
            }

            Algorithm = algorithm;
        }

        public static void CreateNewModel()
        {
            Nodes = new List<Node>();
            DrawNodes();
        }

        public static bool SaveModel(string fileName = "")
        {
            if (fileName == "" && lastFileName == "")
            {
                return false;
            }

            string fName = lastFileName == "" ? fileName : lastFileName;

            SerializationData data = new SerializationData();
            data.Nodes = Nodes;

            return SerializationData.Serialize(fName, data);
        }

        public static bool LoadModel(string fileName)
        {
            SerializationData data;
            
            bool b = SerializationData.Deserialize(fileName, out data);

            if (b)
            {
                Nodes = data.Nodes;
                DrawNodes();
            }

            return b;
        }
    }
}
