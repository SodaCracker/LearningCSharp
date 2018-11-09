using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 50; i < 501; i++)
            //{
            //    Console.WriteLine(i);
            //}

            /*
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(Math.Pow(2, i));
            }

            for (int i = 1024; i > 0; i /= 2)
            {
                Console.WriteLine(i);
            }
            */

            //for (int i = 97; i < 123; i++)
            //{
            //    Console.WriteLine((char)i);
            //}

            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine(i * i);
            //}

            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    Console.WriteLine(n % i);
            //}

            string a = Console.ReadLine();
            int b = int.Parse(a);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(b / (int)(Math.Pow(10, a.Length - i - 1)) % 10);
            //}

            for (int i = b; i > 0; i /= 10)
            {
                Console.WriteLine(i % 10);
            }

            //或者用字符也可以。

        }
    }
}



