using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diploma
{
    public class Node
    {
        public class Point
        {
            public double x, y;

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public Point position;
    }
}
