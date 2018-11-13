using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperLowerTrim
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //Console.WriteLine(s.ToLower());
            //Console.WriteLine(s.ToUpper());
            //Console.WriteLine(s.Trim());

            while (true)
            {
                string s = Console.ReadLine().Trim();
                int r = 0;
                if (s == "exit")
                {
                    break;
                }
                else if (int.TryParse(s, out r))
                {
                    Console.WriteLine(r * r);
                }
                else
                {
                    Console.WriteLine(s.ToUpper());
                }
            }
        }
    }
}
