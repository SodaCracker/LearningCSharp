using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            Stack<string> stack = new Stack<string>();
            string s = Console.ReadLine();
            string[] origin = GetSubstring(s);

            //先把第一次取子字符串拿到的字符串元素扔到 stack 里
            foreach (string item in origin)
            {
                stack.Push(item);
            }

            //stack 里取光了就结束了
            while (stack.Count > 0)
            {
                string topString = stack.Pop();

                //把堆里最上面一个拿出来
                //判断字典里有没有，没有先加进去
                if (dict.ContainsKey(topString))
                {
                    continue;
                }
                else
                {
                    dict.Add(topString, null);
                    Console.WriteLine(topString);
                }

                //把拿出来的第一个再做一次子字符串处理，把 topString 变成 topArray 数组
                string[] topArray = GetSubstring(topString);

                //如果这个子字符串数组的长度只有 2 了，说明之前那个 topString 是两个字符的，然后拆成两个单个字符
                //子字符串数组的长度不会小于 2
                if (topArray.Length >= 2)
                {
                    foreach (string item in topArray)
                    {
                        stack.Push(item);
                    }
                }
                //if (topArray.Length < 2)
                //{
                //    continue;
                //}
            }
        }

        //把字符串拆成减一位的字符串组
        static string[] GetSubstring(string s)
        {
            int length = s.Length;
            string[] array = new string[length];
            for (int i = 0; i < length; i++)
            {
                StringBuilder sb = new StringBuilder(s);
                sb.Remove(i, 1);
                array[i] = sb.ToString();
            }
            return array;
        }

        static int Add(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            return Add(x - 1) + x;
        }
    }
}
