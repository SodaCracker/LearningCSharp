using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int i = 2;
            bool prime = true;
            string formula = "";
            while (i <= number)
            {
                if (number % i == 0)
                {
                    if (i != number)
                    {
                        prime = false;
                    }
                    formula += i + " ";
                    number /= i;
                }
                else
                {
                    i++;
                }
            }
            if (prime == true)
            {
                Console.WriteLine("是质数");
            }
            else
            {
                Console.WriteLine(formula);
            }
        }
    }
}
