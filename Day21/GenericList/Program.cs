using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(12);
            list1.Add(21);

            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i] * list1[i]);
            }

            //List<string> strList = new List<string>();
            //strList.Add("fadsfad");
            //strList.Add("234");
            //strList.Add("dfadf");
            //strList.Add("5435");
            //for (int i = 0; i < strList.Count; i++)
            //{
            //    Console.WriteLine(strList[i].ToUpper()); 
            //    if (strList[i].Length <= 2)
            //    {
            //        Console.WriteLine(strList[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine(strList[i].Substring(2, strList[i].Length - 2));
            //    }
            //}

            List<Rectangle> recList = new List<Rectangle>();
            recList.Add(new Rectangle(1, 2));
            recList.Add(new Square(1));
            recList.Add(new Square(5));

            foreach (Rectangle item in recList)
            {
                Console.WriteLine(item);
            }

        }
    }

    class Rectangle
    {
        int width;
        int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area()
        {
            return width * height;
        }

        public override string ToString()
        {
            return string.Format("width: {0}\theight: {1}\tarea:{2}", width, height, Area());
        }
    }

    class Square : Rectangle
    {
        public Square(int width) : base(width, width)
        {

        }
    }
}
