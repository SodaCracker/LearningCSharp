using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line(0, 0, 100, 100);
            Console.WriteLine(line.Distance());
            line.Move(10, -20);
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    class Line
    {
        private Point p1;
        private Point p2;

        public Line(double x1, double y1, double x2, double y2)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
        }

        public double Distance()
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }

        public void Move(float x, float y)
        {
            p1.X += x;
            p2.X += x;
            p1.Y += y;
            p2.Y += y;
        }
    }
}
