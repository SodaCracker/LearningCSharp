using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetureBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Flower());
        }

        //static int Max(int a, int b)
        //{
        //    a > b ? return a: return b;
        //}

        static bool IsSym(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static int IndexOf(string s, char c)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    return i;
                }
            }
            return -1;
        }

        static int Flower()
        {
            for (int i = 2; i < 1001; i++)
            {
                int sum = 0;
                while (i > 0)
                {
                    sum += (int)Math.Pow(i % 10, 3);
                    i /= 10;
                    if (i == sum)
                    {
                        break;
                    }
                }
                return sum;
            }
            return -1;
        }
    }
}
