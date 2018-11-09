using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2Create
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array1 = new int[2][];       //声明了 10 个子数组，但尚未创建。

            int[][] array2 = { new int[] { 3, 2, 1 }, new int[] { 7, 8 }, new int[] { 1, 1, 1, 1 } };
            //array2 有 3 行。
            //第 1 个数组有 3 行，第 2 个数组有 2 行，第 3 个数组有 4 行。

            int[][] array3;
            array3 = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6 } };

            //int[][][] three = new int[2][][];
            //int[][,] four = new int[2][,];

            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3[i].GetLength(0); j++)
                {
                    Console.Write(array3[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
