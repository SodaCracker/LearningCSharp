using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            if (i < 20)
            {
                int j = 100;
                int m = 60;                 //
                if (i % 2 == 0)
                {
                    int k = 50;
                    m = 80;                 //
                    Console.WriteLine(k);
                }
                Console.WriteLine(j);
                Console.WriteLine(m);
            }
        }
    }
}
