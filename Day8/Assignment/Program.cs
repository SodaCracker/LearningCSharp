using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //交错数组，输入两个位置，两元素交换
            Random r = new Random();

            //声明，赋值
            int[][] array = new int[5][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[5];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = r.Next(1, 101);
                }
            }

            //打印显示
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }

            for (; ; )
            {
                //交换
                Console.Write("输入第 1 个数的行： ");
                int a0 = int.Parse(Console.ReadLine()) - 1;
                Console.Write("输入第 1 个数的列： ");
                int a1 = int.Parse(Console.ReadLine()) - 1;
                Console.Write("输入第 2 个数的行： ");
                int b0 = int.Parse(Console.ReadLine()) - 1;
                Console.Write("输入第 2 个数的列： ");
                int b1 = int.Parse(Console.ReadLine()) - 1;
                int temp = array[a0][a1];
                array[a0][a1] = array[b0][b1];
                array[b0][b1] = temp;

                //打印显示
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        Console.Write(array[i][j] + "\t");
                    }
                    Console.WriteLine();
                }
            }


            //打印直角杨辉三角
            // 1
            // 1 1
            // 1 2 1
            // 1 3 3 1
            // 1 4 6 4 1

            //声明
            int line = int.Parse(Console.ReadLine());
            int[][] triangle = new int[line][];
            for (int i = 0; i < triangle.Length; i++)
            {
                triangle[i] = new int[i + 1];
            }

            //赋值
            for (int i = 0; i < triangle.Length; i++)
            {
                triangle[i][0] = 1;
                triangle[i][triangle[i].Length - 1] = 1;
                for (int j = 1; j < triangle[i].Length - 1; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }

            //打印
            for (int i = 0; i < triangle.Length; i++)
            {
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    Console.Write(triangle[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
