using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = new int();
            //i = 9;

            //Show s = new Show(ShowMessage);
            ////s();

            //s = ShowGoodbye;
            ////s();

            //s = ShowSorry + s;      //没有交换律
            //s();
            //Console.WriteLine();
            //s += ShowSorry;         //可多次重复调用
            //s();
            //Console.WriteLine();

            //Calculate c = Plus;
            //Console.WriteLine(c(1, 2));
            //c = Minus;
            //Console.WriteLine(c(1, 2));
            //Console.WriteLine();

            Get g = GetSum;
            g += GetMax;
            g(new int[] { 5, 8, 7, 0, 6, 9, 3, 5 });
            //Console.WriteLine(g(new int[] { 5, 8, 7, 0, 6, 9, 3, 5 }));
        }

        static void ShowMessage()
        {
            Console.WriteLine("Hello!");
        }

        static void ShowGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }

        static void ShowSorry()
        {
            Console.WriteLine("I'm sorry, sweetheart.");
        }

        static int Plus(int a, int b)
        {
            return a + b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }

        static int GetSum(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            Console.WriteLine(sum);
            return sum;
        }

        static int GetMax(int[] arr)
        {
            int max = arr[0];
            foreach (int item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine(max);
            return max;
        }
    }

    public delegate void Show();

    public delegate int Calculate(int a, int b);

    public delegate int Get(int[] arr);
}
