using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Or
{
    class Program
    {
        static void Main(string[] args)
        {
            // |
            //
            string s = "255.";
            string s2 = "256.";
            //Console.WriteLine(Regex.IsMatch(s, "^0|([-]?[1-9][0-9]*)$"));
            //Console.WriteLine(Regex.IsMatch(s, "^[a-zA-z0-9\\-\\_\\.]+@[a-zA-z0-9\\-\\_\\.]+\\.(com|net|org)$"));
            //Console.WriteLine(Regex.IsMatch(s, "^(([0-9]|[1-9][0-9]|[1-2][0-9]{2}))\\.{3}([1-9]|[1-9][0-9]|[1-9][0-9]{2})$"));
            //([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])
            Console.WriteLine(Regex.IsMatch(s, "^([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.$"));
            Console.WriteLine(Regex.IsMatch(s2, "^([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.$"));


        }
    }
}
