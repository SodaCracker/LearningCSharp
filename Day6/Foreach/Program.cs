using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'c' };
            foreach (char item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            float sum = 0;
            foreach (int item in arr2)
            {
                sum += item;
            }
            Console.WriteLine(sum);

            int max = int.MinValue;
            foreach (int item in arr2)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine(max);

            string str = Console.ReadLine();
            char[] arr3 = str.ToCharArray();
            int count = 0;
            foreach (char item in arr3)
            {
                if (item >= 'a' && item <= 'z')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
