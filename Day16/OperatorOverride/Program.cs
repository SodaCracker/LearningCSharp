using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(10);
            Circle c2 = new Circle(10);
            Console.WriteLine(c1 == c2);

            Rectangle r1 = new Rectangle(3, 4);
            Rectangle r2 = new Rectangle(3, 4);
            Console.WriteLine(r1 == r2);
        }
    }

    class Circle
    {
        public float Radius { set; get; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public static bool operator ==(Circle a, Circle b)
        {
            return a.Radius == b.Radius;
        }

        public static bool operator !=(Circle a, Circle b)
        {
            return a.Radius != b.Radius;
        }
    }

    class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }

        //public static bool operator ==(Rectangle a, Rectangle b)
        //{
        //    return a.Height == b.Height && a.Width == b.Width;
        //}

        //public static bool operator !=(Rectangle a, Rectangle b)
        //{
        //    return a.Height != b.Height || a.Width != b.Width;
        //}
    }
}
