using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    class SiteClusteringCvrppNnc : SiteClusteringCvrpp
    {
        public SiteClusteringCvrppNnc(List<Node> nodes, int capacityLimit, int clustersCount, double kilometerCost) 
            : base(nodes, capacityLimit, clustersCount, kilometerCost)
        {
        }

        protected override List<Node> GenerateClusters(List<Node> nodesForClusters, Node _depot)
        {
            return base.GenerateClusters(nodesForClusters, _depot);
        }
    }
}
