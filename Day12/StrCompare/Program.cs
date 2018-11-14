using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("abc".CompareTo("add"));      //-1
            Console.WriteLine("abc".CompareTo("aaa"));      //1
            Console.WriteLine("abcdefgh".CompareTo("abcdeff"));      //1
            Console.WriteLine(string.Compare("hello", "hell"));     //1

            string[] str = new string[] { "chicago", "new york", "london", "tokyo" };
            Sort(str);
            foreach (string item in str)
            {
                Console.Write(item + "     ");
            }
            Console.WriteLine();

            string s1 = "abc";
            string s2 = "dbc";
            Console.WriteLine(MyCompare(s1, s2));
        }

        static void Sort(string[] str)
        {
            string temp;
            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = 0; j < str.Length - 2 - i; j++)
                {
                    if (string.Compare(str[j], str[j + 1]) > 0)
                    {
                        temp = str[j];
                        str[j] = str[j + 1];
                        str[j + 1] = temp;
                    }
                }
            }
        }

        static int MyCompare(string s1, string s2)
        {
            int index1 = s1.Length - 1;
            int index2 = s2.Length - 1;

            while (/*s1[index1] == s2[index2] && */index1 >= 0 && index2 >= 0)
            {
                if (s1[index1] != s2[index2])
                {
                    return s1[index1] - s2[index2];
                }
                index1--;
                index2--;
                if (index1 == -1 && index2 == -1)
                    return 0;
                else if (index1 < 0)
                    return -1;
                else if (index2 < 0)
                    return 1;
            }
            return 0;
        }
    }
}
