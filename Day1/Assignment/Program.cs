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
            //让用户输入三个整数 a、b、c，打印 a+b-c 的值。
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine(a + b - c);

            //让用户输入一个小写字符，将其转为大写字符。
            char x = char.Parse(Console.ReadLine());
            Console.WriteLine((char)((int)x - 32));
        }
    }
}
