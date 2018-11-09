using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; ; i++)
            {
                break;
                int a = int.Parse(Console.ReadLine());
                if (a == -1)
                {
                    break;
                }
                sum += a;
                //Console.WriteLine(a * 2);
            }
            //Console.WriteLine(sum);

            Random r = new Random();
            int count = 0;
            int score = 0;
            for (; ; )
            {
                int a = r.Next(1, 101);
                int b = r.Next(1, 101);
                Console.Write("{0} + {1} = ", a, b);
                int num = int.Parse(Console.ReadLine());
                if (num == a + b)
                {
                    Console.WriteLine("Congratulations!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
                count++;
                if (count == 5)
                {
                    Console.WriteLine("答对 {0} 题，正确率： {1}%.", score, score / count * 100f);
                    break;
                }
            }
        }
    }
}
