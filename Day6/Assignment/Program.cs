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
            //随机点名程序
            string[] names = { "0", "1", "2", "3", "4", "5", "6" };
            Random r = new Random();
            Console.WriteLine(names[r.Next(0, names.Length)]);

            Console.WriteLine();

            //约瑟夫环，数到 7
            /*
            bool[] arr = new bool[10];
            int jo_num = 7;
            int i = 0;
            int count = 0;
            for (; ; )
            {
                if (jo_num > 1)
                {
                    if (arr[i % 10] == false)
                    {
                        jo_num--;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                else if (jo_num == 1)
                {
                    if (arr[i % 10] == false)
                    {
                        arr[i % 10] = true;
                        foreach (bool item in arr)
                        {
                            Console.Write(item + "\t");
                        }
                        Console.WriteLine();
                        i++;
                        jo_num = 7;
                        count++;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (count == arr.Length)
                {
                    break;
                }
            }
            */

            bool[] arr = new bool[10];
            int outNum = 0;     //出局人数
            int i = 0;      //下标
            int count = 0;      //约瑟夫数
            while (outNum < 10)
            {
                if (!arr[i % 10])
                {
                    count++;
                    if (count == 7)
                    {
                        arr[i % 10] = true;
                        count = 0;
                        outNum++;
                        Console.WriteLine("   {0}\t位出局", i % 10 + 1);
                    }
                }
                i++;
            }
        }
    }
}

//i         0   1   2   3   4   5   6   7   8   9   10
//j_num     7   6   5   4   3   2   1

