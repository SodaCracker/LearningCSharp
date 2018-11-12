using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(x));
        }

        //阶乘
        static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            return Factorial(n - 1) * n;
        }
    }
}
