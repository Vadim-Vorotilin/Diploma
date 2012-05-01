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

        public Site (int [,] prices, int depotsCount, int clustersCount, int consumersCount)
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

            nodesSequence = new int[depotsCount * clustersCount + consumersCount];

            Random rnd = new Random();

            for (int i = 0; i != nodesSequence.Length; i++)
            {
                int index = rnd.Next(orderedSequence.Count);

                nodesSequence[i] = orderedSequence[index];

                orderedSequence.RemoveAt(index);
            }
        }
    }
}
