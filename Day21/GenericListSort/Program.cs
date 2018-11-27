using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> recList = new List<Rectangle>();
            recList.Add(new Rectangle(5, 5));
            recList.Add(new Rectangle(1, 2));
            recList.Add(new Rectangle(3, 4));
            //recList.Sort();
            recList.Sort(new RecCompare());
            foreach (Rectangle item in recList)
            {
                Console.WriteLine(item);
            }
        }
    }

    class RecCompare : IComparer<Rectangle>
    {
        public int Compare(Rectangle a, Rectangle b)
        {
            if (a.Width < b.Width)
            {
                return -1;
            }
            else if (a.Width > b.Width)
            {
                return 1;
            }
            return 0;
        }
    }

    class Rectangle/* : IComparable<Rectangle>*/
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area()
        {
            return Width * Height;
        }

        //public int CompareTo(Rectangle other)
        ////相比 ArrayList 不需要再向下转型了。
        //{
        //    if (Width < other.Width)
        //    {
        //        return -1;
        //    }
        //    else if (Width > other.Width)
        //    {
        //        return 1;
        //    }
        //    return 0;
        //}

        public override string ToString()
        {
            return string.Format("width: {0}\theight: {1}\tarea: {2}", Width, Height, Area());
        }
    }
}
