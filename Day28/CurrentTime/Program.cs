using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrentTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread timer = new Thread(FiveSeconds);
            timer.Start();

            while (true)
            {
                string s = Console.ReadLine();
                string reverseS = new string(s.ToCharArray().Reverse().ToArray());
                Console.WriteLine(reverseS);
            }
        }

        static void FiveSeconds()
        {
            while (true)
            {
                Thread.Sleep(5000);
                Console.WriteLine(DateTime.Now);
            }
        }
    }
}
