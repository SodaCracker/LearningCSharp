using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckNine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 8, 7, 0, 6, 9, 3, 5 };

            Thread subCheck1 = new Thread(SubCheck1);
            Thread subCheck2 = new Thread(SubCheck2);
            subCheck1.Start();
            subCheck2.Start();
        }

        static void SubCheck1(object o)
        {
            int[] array = (int[])o;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] == 9)
                {
                    Console.WriteLine("前一半有");
                    break;
                }
            }
        }

        static void SubCheck2(object o)
        {
            int[] array = (int[])o;
            for (int i = array.Length / 2; i < array.Length; i++)
            {
                if (array[i] == 9)
                {
                    Console.WriteLine("后一半有");
                    break;
                }
            }
        }
    }
}
