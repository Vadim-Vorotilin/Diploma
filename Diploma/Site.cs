﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class Site : IComparable
    {
        private int[] nodesSequence;

        public int[] NodesSequence
        {
            get { return nodesSequence; }
        }

        private double[,] prices;

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

        public Site (double[,] prices, int depotsCount, int clustersCount, int consumersCount)
        {
            this.prices = prices;
            GenerateSequence(depotsCount, clustersCount, consumersCount);
        }

        public Site (Site site)
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

        private Site GetNeighbour ()
        {
            Site result = new Site(this);

            result.InvertRandomPartOfNodesSequence();

            return result;
        }

        private void GoToNeighbour (Site site)
        {
            nodesSequence = site.NodesSequence.Clone() as int[];
        }

        private List<Site> GenerateNeighbours (int count)
        {
            List<Site> result = new List<Site>();

            for (int i = 0; i != count; i++)
            {
                result.Add(GetNeighbour());
            }

            return result;
        }

        public bool GoToBestNeighbour (int countOfNeightbours)
        {
            List<Site> neighbours = GenerateNeighbours(countOfNeightbours);

            neighbours.Sort();

            if (neighbours[0].Price < this.Price)
            {
                GoToNeighbour(neighbours[0]);
                return true;
            }

            return false;
        }

        public int CompareTo (object obj)
        {
            Site site = obj as Site;

            return Price.CompareTo(site.Price);
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
