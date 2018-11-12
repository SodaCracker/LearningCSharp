using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintRect(10, 5);
            //Console.WriteLine(Steps(20));
            //Shift(new int[] { 5, 8, 7, 0, 6, 9, 3, 5 });     /////
            //int[][] array = new int[5][] { new int[] { 5, 8, 7 }, new int[] { 6 }, new int[] { 5, 4 }, new int[] { 3 }, new int[] { 5, 0, 2 } };
            //Sort2(array);
            PrintDiamond(9, 5);
        }

        static void PrintRect(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //height = 7
        //width = 7
        //   * 
        //  *** 
        // *****
        //*******
        // *****
        //  ***
        //   *

        //height = 5
        //width = 9
        //    *
        //  *****
        //*********
        //  *****
        //    *
        //9 - 1 = 8     (9 - 1) % (5 - 1) == 0

        static void PrintDiamond(int width, int height)
        {
            int step = (width - 1) / (height - 1);
            char[][] diamond = new char[height][];
            for (int i = (height - 1) / 2; i >= 0; i--)
            {
                diamond[i] = new char[width - i * step];
                diamond[height - i - 1] = new char[width - i * step];
                for (int j = 0; j < width - i * step; j++)
                {
                    diamond[i][j] = '*';
                }
                for (int j = 0; j < i * step; j++)
                {
                    diamond[i][j] = ' ';
                }
                PrintArray(diamond[i]);
            }
            for (int i = height - 1; i > (height - 1) / 2 - 1; i--)
            {
                diamond[i] = diamond[height - i - 1];
                PrintArray(diamond[i]);
            }
        }

        static void Shift(params int[] array)
        {
            int temp = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;
            PrintArray(array);
        }

        static void Shift(int[] array, int step = 1)
        {
            //step %= array.Length;
            //int[] arrayAdd = new int[step];
            //for (int i = 0; i < arrayAdd.Length; i++)
            //{
            //    arrayAdd[i] = array[array.Length - 1 - i];
            //}
            //for (int i = array.Length - 1; i >= step; i--)
            //{
            //    array[i] = array[i - step];
            //}
            //for (int i = 0; i < arrayAdd.Length; i++)
            //{
            //    array[i] = arrayAdd[arrayAdd.Length - 1 - i];
            //}
            //PrintArray(array);
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[(i + step) % array.Length] = array[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i];
            }
            PrintArray(array);
        }

        static void Shift2(int[] array, int step)       //这个好！
        {
            step %= array.Length;
            for (int i = 0; i < step; i++)
            {
                Shift(array);
            }
        }

        //按子数组的子数组长度，由小到大排列
        static void Sort(int[][] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j].Length > array[j + 1].Length)
                    {
                        Exchange(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Exchange(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        static void Sort2(int[][] array)
        {
            Sort(array);
            foreach (int[] item in array)
            {
                Sort(item);
            }
        }

        static int Steps(int step)
        {
            if (step == 1)
            {
                return 1;
            }
            else if (step == 2)
            {
                return 2;
            }
            return Steps(step - 2) + Steps(step - 1);
        }

        static void Exchange(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Exchange(ref int[] arr1, ref int[] arr2)        //数组的头也是个 int, 还是要用 ref
        {
            int[] temp = arr1;
            arr1 = arr2;
            arr2 = temp;
        }

        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void PrintArray(char[] array)
        {
            foreach (char item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}


