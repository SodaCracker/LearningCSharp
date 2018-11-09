using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            GetArray(100, 2, 2);
            //Console.WriteLine(Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Add(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        static int[] GetArray(int a, int b)
        {
            int[] array;
            if (a < b)
            {
                array = new int[b - a + 1];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = a + i;
                }
            }
            else
            {
                array = new int[a - b + 1];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = b + i;
                }
            }
            return array;
        }

        static int[] GetArray(int a, int b, int step)
        {
            int[] array;
            if (a < b)
            {
                array = new int[(b - a) / step + 1];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = a + i * step;
                }
            }
            else
            {
                array = new int[(a - b) / step + 1];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = b + i * step;
                }
            }
            return array;
        }
    }
}
