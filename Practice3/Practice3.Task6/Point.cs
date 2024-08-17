using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task6
{
    internal struct Point
    {
        public double X; public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double CalcDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

    }
}
