using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForInFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                bool stop = false;
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("* ");
                    if (j == column - 1 && i == line - 1)
                    {
                        stop = true;
                        break;
                    }
                }
                Console.WriteLine();
                if (stop == true)
                {
                    break;
                }
            }
        }
    }
}
