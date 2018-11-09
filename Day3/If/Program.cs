using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //    Console.WriteLine("偶数");
            //else
            //    Console.WriteLine("奇数");
            Console.WriteLine(num % 2 == 0 ? "偶数" : "奇数");
            if (num < 100)
                Console.WriteLine(num * num);
            else
                Console.WriteLine(2 * num);

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine((a + b > c && a + c > b && b + c > a) ? ((a == b && b == c) ? "等边三角形" : "非等边三角形") : "非三角形");
            //if (a + b > c && a + c > b && b + c > a)
            //{
            //    Console.WriteLine("三角形");
            //    if (a == b && b == c)
            //        Console.WriteLine("等边三角形");
            //    else
            //        Console.WriteLine("非等边三角形");
            //}
            //else
            //    Console.WriteLine("非三角形");

            float wage = float.Parse(Console.ReadLine());
            Console.WriteLine(wage <= 1000 ? wage : 0.95f * wage + 50);
        }
    }
}