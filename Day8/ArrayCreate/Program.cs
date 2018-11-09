using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] arr1 = new char[10, 30]; //10行30列

            char[,] arr2 = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' }, { 'g', 'h', 'i' } };

            string[,] arr3 = new string[2, 4]
            { { "one", "two", "three", "four" }, { "five", "six", "seven", "eight" } };

            int[,] array = { { 50, 55, 60 }, { 77, 88, 99 }, { 33, 44, 55 }, { 88, 99, 77 } };
            //打印第4行，第3列；打印第3行，第1列；打印第1行，第2列
            //打印元素总数，子数组个数，每个子数组中元素的个数
            Console.Write("{0}， {1}， {2}\r\n", array[3, 2], array[2, 0], array[0, 1]);
            Console.WriteLine(array.Length);
            Console.WriteLine(array.GetLength(0));
            Console.WriteLine(array.GetLength(1));

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
