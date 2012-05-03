using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class Site
    {
        private int[] nodesSequence;

        private int[,] prices;

        private double Price
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

        public Site (int[,] prices, int depotsCount, int clustersCount, int consumersCount)
        {
            this.prices = prices;
            GenerateSequence(depotsCount, clustersCount, consumersCount);
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

            Random rnd = new Random();

            for (int i = 0; i != nodesSequence.Length; i++)
            {
                int index = rnd.Next(orderedSequence.Count);

                nodesSequence[i] = orderedSequence[index];

                orderedSequence.RemoveAt(index);
            }
        }

        public static void Invert (int[] arr, int i1, int i2)
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
    }
}
