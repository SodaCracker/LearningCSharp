using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            Stopwatch sw = new Stopwatch();
            Steps steps = new Steps();

            sw.Start();
            Console.WriteLine(steps.PossibilityCount(30));
            Console.WriteLine(sw.ElapsedMilliseconds);

        }
    }

    class Steps
    {
        static Dictionary<int, int> d = new Dictionary<int, int>();

        public Steps()
        {
            d.Add(1, 1);
            d.Add(2, 2);
        }

        public int PossibilityCount(int steps)
        {

            if (steps == 1)
            {
                return 1;
            }
            else if (steps == 2)
            {
                return 2;
            }
            else
            {
                if (d.ContainsKey(steps - 2))
                {
                    if (d.ContainsKey(steps - 1))
                    {
                        return d[steps - 1] + d[steps - 2];
                    }
                    else
                    {
                        return PossibilityCount(steps - 1) + d[steps - 2];
                    }
                }
                else
                {
                    d[steps - 2] = PossibilityCount(steps - 2);
                }
            }
            return PossibilityCount(steps - 1) + PossibilityCount(steps - 2);
        }
    }
}
