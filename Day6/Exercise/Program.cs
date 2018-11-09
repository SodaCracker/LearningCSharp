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
            //string str = Console.ReadLine();
            //char[] arr = str.ToCharArray();

            //int count = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] >= 'a' && arr[i] <= 'z')
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //bool palindrome = true;
            //for (int i = 0; i < arr.Length / 2; i++)
            //{
            //    if (arr[i] != arr[arr.Length - i - 1])
            //    {
            //        palindrome = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(palindrome ? "回文" : "不是回文");

            ////打印回声效果
            //string str2 = Console.ReadLine();
            //char[] arr2 = str2.ToCharArray();
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    for (int j = 0; j < arr2.Length - i - 1; j++)       //int j = i; j < arr2.Length; j++
            //    {
            //        Console.Write(arr2[j]);
            //    }
            //    Console.WriteLine();
            //}

            int[] arr1 = new int[100];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr1.Length - i;
            }

            //小写转大写
            string str1 = Console.ReadLine();
            char[] arr2 = str1.ToCharArray();
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] >= 'a' && arr2[i] <= 'z')
                {
                    arr2[i] -= (char)32;
                }
            }

            //斐波那契数列
            int[] arr3 = new int[12];
            arr3[1] = arr3[0] = 1;
            for (int i = 2; i < arr3.Length; i++)
            {
                arr3[i] = arr3[i - 2] + arr3[i - 1];
            }
        }
    }
}
