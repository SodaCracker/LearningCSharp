using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    class Program
    {
        static void Main(string[] args)
        {


            ////1.a
            //bool[] onezero = new bool[10000];
            //for (int i = 0; i < onezero.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        onezero[i] = true;
            //    }
            //    else
            //    {
            //        onezero[i] = false;
            //    }
            //}

            //1.b
            //long[] tens = new long[50];
            //for (int i = 1; i < tens.Length; i++)
            //{
            //    tens[i] = 10 * i;
            //}

            //1.c
            //int[] numbers = new int[100];
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    numbers[i] = i * i;
            //}

            //1.d
            //long[] fibonacci = new long[50];
            //fibonacci[1] = fibonacci[0] = 1;
            //for (int i = 2; i < fibonacci.Length; i++)
            //{
            //    fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            //}

            //2.a
            //for (int i = 0; i < tens.Length / 2; i++)
            //{
            //    Console.WriteLine(tens[i * 2]);
            //}

            //2.b
            //for (int i = 0; i < tens.Length / 10; i++)
            //{
            //    Console.WriteLine(tens[i * 10]);
            //}

            //3
            //int sum = 0;
            //int min = int.MaxValue;
            //int max = int.MinValue;
            //foreach (int item in numbers)
            //{
            //    sum += item;
            //    if (item > max)
            //    {
            //        max = item;
            //    }
            //    else if (item < min)
            //    {
            //        min = item;
            //    }
            //}

            //4
            //int countz = 0;
            //int countZ = 0;
            //char[] characters = new char[10];
            //foreach (char item in characters)
            //{
            //    if (item == 'z')
            //    {
            //        countz++;
            //    }
            //    if (item == 'Z')
            //    {
            //        countZ++;
            //    }
            //}
            //Console.WriteLine("{0}，{1}", countz, countZ);

            //5
            //char[] arr = { 'g', 'e', 'z', 'd', };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write(arr[j]);
            //    }
            //    Console.WriteLine();
            //}

            //6
            //bool symm = true;
            //int[] str = { 1, 2, 1 };
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] != str[str.Length - 1 - i])
            //    {
            //        Console.WriteLine("不对称");
            //        symm = false;
            //        break;
            //    }
            //}
            //if (symm)
            //{
            //    Console.WriteLine("对称");
            //}

            //7、有两个int数组 arr1 和 arr2, 写代码将两个数组间隔合并成一个新数组，比如:
            //arr1 为 { 5, 1, 7, 2, 9, 8, 3, 0, 4, 6 }
            //arr2 为 { 56, 79, 33, 45, 18 };
            //拼接后得到{ 5, 56, 1, 79, 7, 33, 2, 9, 45, 8, 18, 3, 0, 4, 6 }

            //int[] arr1 = { 5, 1, 7, 2, 9, 8, 3, 0, 4, 6 };      //Length = 10, index_arr1 从 0 到 9
            //int[] arr2 = { 56, 79, 33, 45, 18 };        //Length = 5, index_arr2 从 0 到 4
            //int[] arr = new int[arr1.Length + arr2.Length];     //Length = 15, index 从  0 到 14
            //int index = 0;
            //int index_arr1 = 0;
            //int index_arr2 = 0;
            //bool flag = true;

            //while (index < arr1.Length + arr2.Length)
            //{
            //    if (flag && index_arr1 < arr1.Length)
            //    {
            //        arr[index] = arr1[index_arr1];
            //        index_arr1++;
            //        index++;
            //    }
            //    else if (!flag && index_arr2 < arr2.Length)
            //    {
            //        arr[index] = arr2[index_arr2];
            //        index_arr2++;
            //        index++;
            //    }
            //    //index++;
            //    flag = !flag;
            //}
            //foreach (int item in arr)
            //{
            //    Console.Write(item + ", ");
            //}
        }
    }
}
