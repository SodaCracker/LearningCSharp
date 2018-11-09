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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a == b)
                Console.WriteLine("相等");
            else if (a == -b)
                Console.WriteLine("相反");
            else if (a + b == 100)
                Console.WriteLine("互补");

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            if (str1 == str2)
                Console.WriteLine("完全相等");
            else if(str1[0] == str2[1])
                Console.WriteLine("第一个字符相等");
            else
                Console.WriteLine("其他");

            //00000000 11111111 00000000 00000000
            //&00FF0000
            int color = int.Parse(Console.ReadLine());
            Console.WriteLine(color & 0xFF0000 >> 16);
        }
    }
}
