using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSym("abcba"));
            //Console.WriteLine(IsSym("abcb"));
            //Console.WriteLine(GetCharInString("abc", 0));
        }

        static int Negative(int n)
        {
            return -n;
        }

        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        static bool IsLetter(char c)
        {
            return ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) ? true : false;
        }

        static bool IsSym(string s)
        {
            char[] array = s.ToCharArray();
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    return false;;
                }
            }
            return true;
        }
        static char GetCharInString(string s, int pos)
        {
            return s[pos];
        }
    }
}

