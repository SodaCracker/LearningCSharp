using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 32, 54, 654, 24, 25, 76, 23, };
            //ArrayUtils.Sort(array);
            //ArrayUtils.Reverse(array);
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(ArrayUtils.Seek(array, 24));
        }
    }

    static class Test                                      //静态类里的东西全是静态的（字段、方法、构造器）
    {
        private static int i;                              //静态字段

        public static int I { get; set; }                  //静态属性

        static Test()                                      //静态构造器
        {

        }

        public static void TestMethod()                    //静态方法
        {

        }
    }

    static class ArrayUtils
    {
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void Reverse(int[] array)
        {
            //int[] arrTemp = new int[array.Length];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    arrTemp[i] = array[array.Length - i - 1];
            //}
            //arrTemp = array;

            int temp;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }

        public static int Seek(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
