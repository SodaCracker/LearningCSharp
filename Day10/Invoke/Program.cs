using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareSum(3, 4));
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Pow(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }

        static int SquareSum(int a, int b)
        {
            return Add(Pow(a, 2), Pow(b, 2));
        }
    }
}
