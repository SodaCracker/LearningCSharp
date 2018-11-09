using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            //int line = int.Parse(Console.ReadLine());
            /*
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < line; j++)
                {
                    if (j < line - i - 1) //if (i + j < line)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }

                //for (int j = 0; j < line - i - 1; j++)
                //{
                //    Console.Write("  ");
                //}
                //for (int j = 0; j < i + 1; j++)
                //{
                //    Console.Write("* ");
                //}

                Console.WriteLine();
            }
            */

            int line = int.Parse(Console.ReadLine());
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < line + i + 1; j++)
                {
                    if (i + j > line - 1 && j - i < line + 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

        }
    }
}
