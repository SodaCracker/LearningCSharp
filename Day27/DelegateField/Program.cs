using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DelegateField
{
    public delegate void Check(string s);

    class Program
    {
        static void Main(string[] args)
        {
            UserInput ui = new UserInput();
            ui.check = s =>
            {
                if (s.Length > 10)
                {
                    Console.WriteLine("too long");
                }
            };

            ui.check += s =>
            {
                if (s.Contains("tmd"))
                {
                    Console.WriteLine("illegal");
                }
            };

            ui.check += s =>
            {
                if (Regex.IsMatch(s, "[0-9]"))
                {
                    Console.WriteLine("digit is not allowed");
                }
            };

            ui.Work();
        }
    }

    class UserInput
    {
        public Check check;

        public void Work()
        {
            while (true)
            {
                string line = Console.ReadLine();
                check(line);
            }
        }
    }
}
