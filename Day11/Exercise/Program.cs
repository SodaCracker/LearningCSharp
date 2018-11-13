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
            //Tnirp("I Love U.");
            //Echo("九城欢迎你");

            int r = 0;
            bool success = false;
            while (!success)
            {
                Console.WriteLine("请输入数字： ");
                string str = Console.ReadLine();
                success = int.TryParse(str, out r);
            }
            string s = "";
            while (s != "结束")
            {
                s = Console.ReadLine();
                switch (s)
                {
                    case "变大":
                        r++;
                        break;
                    case "变小":
                        r--;
                        break;
                    case "翻倍":
                        r *= 2;
                        break;
                    case "结束":
                        Console.WriteLine(r);
                        break;
                }

            }
        }

        //static void Tnirp(string str)
        //{
        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(str[i]);
        //    }
        //    Console.WriteLine();
        //}

        //static void Echo(string str)
        //{
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        for (int j = i; j < str.Length; j++)
        //        {
        //            Console.Write(str[j]);
        //        }
        //        Console.WriteLine();
        //    }
        //}

    }
}
