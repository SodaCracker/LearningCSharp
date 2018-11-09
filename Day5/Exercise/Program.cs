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
            //for (int i = 1; i < 101; i++)
            //{
            //    if (i / 10 % 10 == 2 * (i % 10))
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i < 101; i++)
            //{
            //    if (i / 10 % 10 == 2 * (i % 10))
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i < 11; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    if (num % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(2 * num);
            //}

            //int n = int.Parse(Console.ReadLine());
            //for (int i = 2; i < n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.WriteLine("非质数");
            //        break;
            //    }
            //}

            //int m = int.Parse(Console.ReadLine());
            //for (int i = 2; i < m; i++)
            //{
            //    if (m % i == 0)
            //    {
            //        Console.WriteLine("非质数");
            //        break;
            //    }
            //    if (i == m - 1)
            //    {
            //        Console.WriteLine("质数");
            //        break;
            //    }
            //}

            int t = int.Parse(Console.ReadLine());
            bool prime = true;      //标记变量，非常好用。
            for (int i = 2; i < t / i; i++)
            {
                if (t % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            Console.WriteLine("是否质数：{0}", prime);
        }
    }
}
