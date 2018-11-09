using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                //Console.WriteLine(i);
                if (i % 10 + i / 10 % 10 == 15)
                {
                    break;
                }
            }

            for (int i = 1; i < 101; i++)
            {
                if (i % 10 + i / 10 % 10 == 15)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
