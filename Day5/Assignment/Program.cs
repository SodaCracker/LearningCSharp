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
            //求5 - 100所有质数的和，应该是 1055.
            int sum = 0;
            for (int i = 5; i < 101; i++)
            {
                bool prime = true;
                for (int j = 2; j < i / j + 1; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime == true)
                {
                    sum += i;
                }
            }
            Console.WriteLine("5 ~ 100 以内的质数和为 {0}.", sum);

            //先由程序随机生成一个1-100的整数，让用户猜。
            //程序告诉用户猜大了还是猜小了，让用户再猜.....直到猜中为止。

            Random r = new Random();
            int a = r.Next(1, 101);
            for (; ; )
            {
                int num = int.Parse(Console.ReadLine());
                if (num == a)
                {
                    Console.WriteLine("猜中了！");
                    break;
                }
                else if (num > a)
                {
                    Console.WriteLine("太大");
                }
                else
                {
                    Console.WriteLine("太小");
                }
            }

            //打印菱形。
            int line = int.Parse(Console.ReadLine());
            int line_top = line / 2;
            int line_bottom = line - line_top;

            for (int i = 0; i < line_top; i++)
            {
                for (int j = 0; j < line + i; j++)
                {
                    if (i + j > line_top - 2 && j - i < line_top)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < line_bottom + 1; i++)
            {
                for (int j = 0; j < line_bottom * 3; j++)
                {
                    if (j - i >= 1 && i + j < line_bottom + 4)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
