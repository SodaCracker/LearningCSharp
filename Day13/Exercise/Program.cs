using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //替换字符
        static string Replace(string origin, char oldChar, char newChar)
        {
            char[] charArr = origin.ToCharArray();
            for (int i = 0; i < origin.Length; i++)
            {
                if (charArr[i] == oldChar)
                {
                    charArr[i] = newChar;
                }
            }
            return new string(charArr);
        }

        //替换字符串
        static string Replace(string origin, string oldString, string newString)
        {
            char[] charArr = origin.ToCharArray();
            for (int i = 0; i < origin.Length - oldString.Length + 1; i++)
            {
                bool flag = true;
                for (int j = 0; j < oldString.Length; j++)
                {
                    if (charArr[i + j] != oldString[j])
                    {
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
