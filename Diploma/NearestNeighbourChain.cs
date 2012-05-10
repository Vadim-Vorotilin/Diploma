using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class NearestNeighbourChain : Algorithm
    {
        private List<Cluster> clusters; 

        public override double Value
        {
            get
            {
                double value = 0;

                foreach (Cluster cluster in clusters)
                {
                    value += cluster.GetPrice();
                }

                return value;
            }
        }

        protected override void InnerIteration()
        {
            throw new NotImplementedException();
        }

        public override void DrawNodes()
        {
            throw new NotImplementedException();
        }
    }
}
