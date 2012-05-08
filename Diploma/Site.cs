using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public abstract class Site : IComparable
    {
        protected List<Node> Nodes;
        protected List<Node> DrawingNodes;

        protected Site (List<Node> nodes)
        {
            Nodes = new List<Node>();

            for (int i = 0; i != nodes.Count; i++)
            {
                Nodes.Add(nodes[i]);
            }
        }

        protected abstract double Price { get; }

        protected abstract void GoToNeighbour(Site site);

        protected abstract Site GetNeighbour();

        public abstract object Result { get; }

        private List<Site> GenerateNeighbours(int count)
        {
            List<Site> result = new List<Site>();

            for (int i = 0; i != count; i++)
            {
                result.Add(GetNeighbour());
            }

            return result;
        }

        public bool GoToBestNeighbour(int countOfNeightbours)
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

        protected abstract void PrepareToDraw();

        public void DrawNodes ()
        {
            PrepareToDraw();

            TaskController.DrawNodes(DrawingNodes); 
        }

        public int CompareTo(object obj)
        {
            Site site = obj as Site;
            return Price.CompareTo(site.Price);
        }
    }
}
