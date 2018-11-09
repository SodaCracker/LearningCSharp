using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello();
            //Print1To100();
            //PrintaToz();
            //PrintRandom();
            //AddOne(10);
            //Half(55);
            //Reverse("ILoveU");

            BetweenPro(5, 12, true);
        }

        static void Hello()
        {
            Console.WriteLine("Hello");
        }

        static void Print1To100()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.Write(i + "\t");
            }
        }

        static void PrintaToz()
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

        static void PrintRandom()
        {
            Random r = new Random();
            Console.WriteLine(r.Next(1, 101));
        }

        static void AddOne(int n)
        {
            n++;
            Console.WriteLine(n);
        }

        static void Half(int n)
        {
            Console.WriteLine(n * 1.0f / 2);
        }

        static void Square(int n)
        {
            Console.WriteLine(n * n);
        }

        static void Upper(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine((char)(c - 32));
            }
        }

        static void IsPrime(int n)
        {
            bool isPrime = true;
            for (int i = 2; i < n / i; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("质数");
            }
            else
            {
                Console.WriteLine("非质数");
            }
        }

        static void Reverse(string s)
        {
            char[] strChar = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(strChar[s.Length - 1 - i]); ;
            }
            Console.WriteLine();
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void IsTriangle(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("可以");
            }
            else
            {
                Console.WriteLine("不可以");
            }
        }

        static void Between(int a, int b)
        {
            for (int i = a; i < b + 1; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void BetweenPro(int a, int b, bool rev)
        {
            if (rev)
            {
                while (a <= b)
                {
                    Console.WriteLine(b);
                    b--;
                }
            }
            else
            {
                Between(a, b);
            }
        }
    }
}
