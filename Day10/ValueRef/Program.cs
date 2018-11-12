using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRef
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 5;
            //Add(n);
            //Console.WriteLine(n);       //5
            //int[] array = { 5, 6, 7 };
            //Add(array);
            //Console.WriteLine(array[0]);        //6

            int a = 10, b = 20;
            Swap(a, b);

            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            Swap(arr1, arr2);

            int[] array = { 1, 2, 3 };
            Change(array);
        }

        static void Add(int n)
        {
            n++;
        }

        static void Add(int[] array)        //调用此方法时，把实参的值（也就是数组首项的地址）给到形参
        {
            array[0]++;
        }

        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Swap(int[] arr1, int[] arr2)
        {
            int temp = arr1[0];
            arr1[0] = arr2[0];
            arr2[0] = temp;
        }

        static void Change(int[] array)
        {
            array = new int[] { 'a', 'b', 'c' };
        }
    }
}
