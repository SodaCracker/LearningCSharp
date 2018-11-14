using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //用Remove删除用户输入字符串中所有的 1
            string s1 = Console.ReadLine();
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                if (s1[i] == '1')
                {
                    s1 = s1.Remove(i, 1);
                }
            }
            Console.WriteLine(s1);

            //头尾少两个字符
            string s = "24601";
            Console.WriteLine(s);
            while (s.Length > 1)
            {
                s = s.Substring(1, s.Length - 2);
                Console.WriteLine(s);
            }

            Console.WriteLine(MyContains("He only had himself to blame.", "Hfse"));
        }

        //定义方法bool MyContains(string str,string sub),如果str包含sub，返回true，否则返回false。
        //不使用string的Contains
        //static bool MyContains(string str, string sub)
        //{
        //    char[] strArr = str.ToCharArray();
        //    for (int i = 0; i < str.Length - sub.Length + 1; i++)
        //    {
        //        if (GetSub(str, i, sub.Length) == sub)      //效率低，过程中要大量生成字符串
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //static string GetSub(string origin, int start, int length)
        //{
        //    char[] strArr = origin.ToCharArray();
        //    return new string(strArr, start, length);
        //}

        static bool MyContains(string str, string sub)
        {
            char[] strArr = str.ToCharArray();
            for (int i = 0; i < str.Length - sub.Length + 1; i++)
            {
                bool flag = true;
                for (int j = 0; j < sub.Length; j++)
                {
                    if (strArr[i + j] != sub[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    return true;
                }
                //if (str.Substring(i, sub.Length) == sub)
                //{
                //    return true;
                //}
            }
            return false;
        }
    }
}
