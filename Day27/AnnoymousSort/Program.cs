using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnoymousSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 8, 7, 0, 6, 9, 3, 5 };

            //Sort(array, delegate (int a, int b)
            //{
            //    return a - b;
            //});

            //Sort(array, (int a, int b) =>
            //{
            //    return a - b;
            //});

            Sort((int a, int b) =>
            {
                return a - b;
            }, array);

            //Sort(Small2Large, array);
            //Sort(Large2Small, array);
            //Sort(Minus9, array);

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        //static int Small2Large(int a, int b)
        //{
        //    return a - b;
        //}

        //static int Large2Small(int a, int b)
        //{
        //    return b - a;                                   //大的排前面
        //}

        //static int Minus9(int a, int b)
        //{
        //    return Math.Abs(a - 9) - Math.Abs(b - 9);       //离9远的返回正
        //}

        static void Sort(CompareMethod cm, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (cm(array[j], array[j + 1]) > 0)
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }

    public delegate int CompareMethod(int a, int b);
}
