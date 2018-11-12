using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print(new int[] { 1, 2, 3, 4, 5 });
            Print(1, 2, 3, 4, 5);
        }

        static void Print(params int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
