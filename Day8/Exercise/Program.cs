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
            //int[,] arr1 = new int[10, 10];
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        arr1[i, j] = (i + 1) + (j + 1);
            //        //Console.Write(arr1[i, j] + "\t");
            //    }
            //    //Console.WriteLine();
            //}

            //char[,] arr2 = new char[26, 26];
            //for (byte i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (byte j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        arr2[i, j] = (char)((i + j) % 26 + 'a');
            //        //Console.Write(arr2[i, j] + " ");
            //    }
            //    //Console.WriteLine();
            //}

            //Random r = new Random();
            //int sum = 0;
            //int[,] array = new int[10, 10];

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = r.Next(1, 101);
            //        if (i + j == array.GetLength(0) - 1)
            //        {
            //            sum += array[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine(sum);

            //九城欢迎你
            //城欢迎你
            //欢迎你
            //迎你
            //你

            string str = Console.ReadLine();
            char[] strArr = str.ToCharArray();      //把输入的文字转化为字符的 array

            char[][] arr = new char[strArr.Length][];
            for (int i = 0; i < strArr.Length; i++)
            {
                arr[i] = new char[strArr.Length - i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)     //要从0开始，不然要缺。
                {
                    arr[i][j] = strArr[j + i];      //j + i
                }
            }

        }
    }
}
