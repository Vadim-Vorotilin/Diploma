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
        public static int ConsumerMinSize = 4;
        public static int ConsumerMaxSize = 10;

        public static Brush DepotBrush = new SolidBrush(Color.Blue);
        public static int DepotSize = 12;

        public static Brush AuxiliaryBrush = new SolidBrush(Color.Lime);
        public static int AuxiliarySize = 9;
        
        public static Pen ConnectionsPen = new Pen(Color.Black, 2.0f);

        public static Color ClearColor = Color.White;

        public static List<Node> Nodes { get; private set; }
        public static int NodesVolume
        {
            get 
            { 
                return (from node in Nodes 
                        select node.Volume).Sum();
            }
        }

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

        public static Algorithm Algorithm { get; private set; }

        public static bool IsAlgorithmStarted
        {
            get { return Algorithm != null; }
        }

        public static Random Rnd = new Random();

        static TaskController()
        {
            Nodes = new List<Node>();
            lastFileName = "";
            Algorithm = null;
        }

        private static int minVolume = int.MaxValue;
        private static int maxVolume = int.MinValue;

        private static bool CheckVolume()
        {
            bool b = false;

            foreach (Node node in Nodes)
            {
                if (node.Volume < minVolume)
                {
                    minVolume = node.Volume;
                    b = true;
                }

                if (node.Volume > maxVolume)
                {
                    maxVolume = node.Volume;
                    b = true;
                }
            }

            return b;
        }

        public static void AddNodeAtScreen (Node.NodeType nodeType, int posX, int posY, int volume = 1)
        {
            Node newNode = new Node(Nodes.Count, nodeType, posX, posY, posX, posY) {Volume = volume};

            Nodes.Add(newNode);

            if (!CheckVolume())
            {
                DrawNode(graphicsForDraw, newNode);
            }
            else
            {
                DrawNodes();
            }
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
                if (node.Connections == null)
                    continue;

                foreach (Node.Connection connection in node.Connections)
                {
                    Pen pen = new Pen(connection.Color, ConnectionsPen.Width);

                    g.DrawLine(pen, (int)node.ScreenPosition.x, (int)node.ScreenPosition.y, (int)connection.ConnectedNode.ScreenPosition.x, (int)connection.ConnectedNode.ScreenPosition.y);
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
                    int size = maxVolume == minVolume ? (ConsumerMaxSize + ConsumerMinSize) / 2 : Convert.ToInt32((ConsumerMaxSize - ConsumerMinSize) * (double)(node.Volume - minVolume) / (double)(maxVolume - minVolume)) + ConsumerMinSize;
                    g.FillEllipse(ConsumerBrush, (int)(node.ScreenPosition.x - size / 2.0), (int)(node.ScreenPosition.y - size / 2.0), size, size);
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
            int goodSitesCount, int bestSitesCount, int neighboursForGoodSites, int neighboursForBestSites, int clusterCapacityLimit = -1)
        {
            BeesColony colony = new BeesColony();

            colony.Problem = problemType;
            colony.ClustersCount = clustersCount;
            colony.ClusterCapacityLimit = clusterCapacityLimit;

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
                node.Connections.Clear();
            }

            Algorithm = algorithm;
        }

        public static void StopAlgorithm()
        {
            Algorithm.Stop();
            Algorithm = null;
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
                CheckVolume();
                DrawNodes();
            }

            return b;
        }
    }
}
