using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "abcde";
            Console.WriteLine(ArrayMethod(CharPlusOne, myString));
            Console.WriteLine(ArrayMethod(CharUpper, myString));

            int[] myArray = new int[] { 5, 4, 3, 2, 1 };
            Sort(Small2Large, myArray);
            foreach (int item in myArray)
            {
                Console.WriteLine(item);
            }
        }

        static string ArrayMethod(CharMethod cm, string str)
        {
            char[] array = str.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = cm(array[i]);
            }
            return new string(array);
        }

        static char CharPlusOne(char c)
        {
            return (char)(c + 1);
        }

        static char CharUpper(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                return (char)(c - 32);
            }
            return c;
        }

        //static void Sort(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = 0; j < array.Length-1-i; j++)
        //        {
        //            if (array[j]>array[j+1])
        //            {
        //                int temp = array[j];
        //                array[j] = array[j + 1];
        //                array[j + 1] = temp;
        //            }
        //        }
        //    }
        //}

        static int Small2Large(ref int a, ref int b)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            return -1;
        }

        static void Sort(CompareMethod cm, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    cm(ref array[j], ref array[j + 1]);
                }
            }
        }
    }

    public delegate char CharMethod(char c);
    public delegate int CompareMethod(ref int a, ref int b);
}
