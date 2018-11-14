using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "abcde";
            //Console.WriteLine(s);
            //Console.WriteLine(s.Insert(2, "xyz"));

            string s = "abcdefghijklmnopqrstuvwxyz";

            //for (int i = 0, j = 0; i < s.Length; i++, j++)
            //{
            //    if (j == 10)
            //    {
            //        j = 0;
            //        s = s.Insert(i, "\r\n");
            //        i += 2;
            //    }
            //}
            //Console.WriteLine(s);

            //先找到最后一个
            for (int i = s.Length - 1; i > 0; i--)
            {
                if (i % 10 == 0)
                {
                    s = s.Insert(i, "\r\n");
                }
            }
            Console.WriteLine(s);
        }
    }
}
