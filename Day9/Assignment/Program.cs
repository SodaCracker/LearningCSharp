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
            Console.WriteLine(Pow(2, 3));
            int[] array = new int[] { 5, 8, 7, 0, 6, 9, 3, 5 };
            Sort(array, false);
        }

        //返回arr中元素平均值
        static float Average(float[] arr)
        {
            float sum = 0;
            foreach (float item in arr)
            {
                sum += item;
            }
            return sum / arr.Length;
        }

        //返回a的b次方
        static int Pow(int a, int b)
        {
            int result = 1;
            while (b > 0)
            {
                result *= a;
                b--;
            }
            return result;
        }

        //返回字符c在arr数组中出现的次数
        static int Occur(char[] arr, char c)
        {
            int count = 0;
            foreach (char item in arr)
            {
                if (item == c)
                {
                    count++;
                }
            }
            return count;
        }

        //把arr中所有数字字符替换为 *
        static void RemoveDigit(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= '0' && arr[i] <= '9')
                {
                    arr[i] = '*';
                }
            }
        }

        //对arr排序，asc为true则升序
        static void Sort(int[] arr, bool asc)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            if (asc)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + "\t");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[arr.Length - i - 1] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
