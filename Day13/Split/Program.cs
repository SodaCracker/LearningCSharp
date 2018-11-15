using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "cat, dog - mouse; tiger";
            //string[] animals = s.Split(new char[] { ',', '-', ';' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (string item in animals)
            //{
            //    Console.WriteLine(item.Trim());
            //}

            //输入数字，空格隔开，判断是否能组成三角形
            string numStr = Console.ReadLine();
            string[] numArr = numStr.Split(' ');
            int[] array = new int[numArr.Length];
            for (int i = 0; i < numArr.Length; i++)
            {
                array[i] = int.Parse(numArr[i]);
            }
            if (array[0] + array[1] > array[2] && array[0] + array[2] > array[1] && array[1] + array[2] > array[0])
            {
                Console.WriteLine("可以");
            }
            else
            {
                Console.WriteLine("不可以");
            }
        }
    }
}
