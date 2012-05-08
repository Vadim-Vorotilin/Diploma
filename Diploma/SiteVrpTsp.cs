using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class SiteVrpTsp : Site
    {
        private int[] nodesSequence;

        public int[] NodesSequence
        {
            get { return nodesSequence; }
        }

        private double[,] prices;

        private int depotsCount;
        private int consumersCount;

        protected override double Price
        {
            get
            {
                double price = 0;

                for (int i = 0; i != nodesSequence.Length - 1; i++)
                {
                    price += prices[nodesSequence[i], nodesSequence[i + 1]];
                }

                price += prices[nodesSequence[nodesSequence.Length - 1], nodesSequence[0]];

                return price;
            }
        }

        public override object Result
        {
            get { return nodesSequence; }
        }

        protected override void PrepareToDraw()
        {
            for (int i = 0; i != Nodes.Count; i++)
            {
                Nodes[i].ConnectedNodes = new List<Node>();
            }

            int[] result = Result as int[];

            for (int i = 0; i != result.Length - 1; i++)
            {
                Nodes[result[i]].ConnectedNodes.Add(Nodes[result[i + 1]]);
            }

            Nodes[result[result.Length - 1]].ConnectedNodes.Add(Nodes[result[0]]);
        }

        private static double GetDistance(Node node1, Node node2)
        {
            return Math.Sqrt(Math.Pow(node1.RealPosition.x - node2.RealPosition.x, 2) + Math.Pow(node1.RealPosition.y - node2.RealPosition.y, 2));
        }

        private static double[,] GeneratePricesByPositions(List<Node> nodes, int depotsCount, int consumersCount)
        {
            double[,] prices = new double[depotsCount + consumersCount, depotsCount + consumersCount];

            for (int i = 0; i != prices.GetLength(0); i++)
            {
                for (int j = 0; j != prices.GetLength(0); j++)
                {
                    if (i < depotsCount && j < depotsCount)
                    {
                        prices[i, j] = double.PositiveInfinity;
                    }
                    else
                    {
                        prices[i, j] = GetDistance(nodes[i], nodes[j]);
                    }
                }
            }

            return prices;
        }

        public SiteVrpTsp(List<Node> nodes, int depotsCount, int consumersCount, int clustersCount)
            : base(nodes)
        {
            this.prices = GeneratePricesByPositions(nodes, depotsCount, consumersCount);
            this.depotsCount = depotsCount;
            this.consumersCount = consumersCount;
            GenerateSequence(depotsCount, clustersCount, consumersCount);
            
        }

        private SiteVrpTsp (SiteVrpTsp site)
            : base(site.Nodes)
        {
            this.prices = site.prices.Clone() as double[,];
            this.nodesSequence = site.nodesSequence.Clone() as int[];
        }

        private void GenerateSequence (int depotsCount, int clustersCount, int consumersCount)
        {
            List<int> orderedSequence = new List<int>();

            for (int i = 0; i != depotsCount; i++)
            {
                for (int j = 0; j != clustersCount; j++)
                {
                    orderedSequence.Add(i);
                }
            }

            for (int i = depotsCount; i != depotsCount + consumersCount; i++)
            {
                orderedSequence.Add(i);
            }

            nodesSequence = new int[depotsCount*clustersCount + consumersCount];

            for (int i = 0; i != nodesSequence.Length; i++)
            {
                int index = TaskController.Rnd.Next(orderedSequence.Count);

                nodesSequence[i] = orderedSequence[index];

                orderedSequence.RemoveAt(index);
            }
        }

        private static void Invert (int[] arr, int i1, int i2)
        {
            int end_ = ((i1 + Math.Abs(i1 - i2)/2 + 1)%arr.Length >= 0
                            ? (i1 + Math.Abs(i1 - i2)/2 + 1)%arr.Length
                            : (i1 + Math.Abs(i1 - i2)/2 + 1)%arr.Length + arr.Length);


            for (int i = i1; i != end_; i++)
            {
                int i1_ = (i%arr.Length >= 0 ? i%arr.Length : i%arr.Length + arr.Length);

                if (i1_ == end_) break;

                int i2_ = ((i1 + i2 - i)%arr.Length >= 0
                               ? (i1 + i2 - i)%arr.Length
                               : (i1 + i2 - i)%arr.Length + arr.Length);

                Interchange(arr, i1_, i2_);
            }
        }

        private static void Interchange (int[] arr, int i1, int i2)
        {
            var temp = arr[i1];
            arr[i1] = arr[i2];
            arr[i2] = temp;
        }

        public void InvertRandomPartOfNodesSequence ()
        {
            int i1 = TaskController.Rnd.Next(nodesSequence.Length);
            int i2;

            do
            {
                i2 = TaskController.Rnd.Next(nodesSequence.Length);
            } while (i1 == i2);

            Invert(nodesSequence, i1, i2);
        }

        protected override Site GetNeighbour ()
        {
            SiteVrpTsp result = new SiteVrpTsp(this);

            result.InvertRandomPartOfNodesSequence();

            return result;
        }

        protected override void GoToNeighbour (Site site)
        {
            SiteVrpTsp siteVrpTsp = site as SiteVrpTsp;
            nodesSequence = siteVrpTsp.NodesSequence.Clone() as int[];
        }

        public override string ToString()
        {
            string sequence = "{";

            for (int i = 0; i != nodesSequence.Length; i++)
            {
                sequence += nodesSequence[i] + (i != nodesSequence.Length - 1 ? " " : "}");
            }

            return string.Format("{0}. Price: {1}", sequence, Price);
        }
    }
}
