using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 & 8);
            //0101
            //1000
            //0000
            Console.WriteLine(11 & 7);
            //1011
            //0111
            //0011 -> 3
            Console.WriteLine(9 & 2);
            //1001
            //0010
            //0000
        }
    }
}
