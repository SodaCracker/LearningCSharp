using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户不停输入字符串，如果字符串等于abc,就转为大写打印，如果等于ABC，就转为小写打印，其他情况去除两边空格打印。
            //string str = "";
            //while (str != "exit")
            //{
            //    str = Console.ReadLine();
            //    switch (str)
            //    {
            //        case "abc":
            //            Console.WriteLine(str.ToUpper());
            //            break;
            //        case "ABC":
            //            Console.WriteLine(str.ToLower());
            //            break;
            //        default:
            //            Console.WriteLine(str.Trim());
            //            break;
            //    }
            //}

            //用户输入一个字符串，将其中的所有字母 + 1，z回到a,生成一个新的字符串，并打印。
            //比如a124efABz---- > b124fgBCa
            string s = Console.ReadLine();
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'z' || arr[i] == 'Z')
                {
                    arr[i] -= (char)25;
                }
                else if (arr[i] >= 'a' && arr[i] <= 'z' || (arr[i] >= 'A' && arr[i] <= 'Z'))
                {
                    arr[i] += (char)1;
                }
            }
            string newStr = new string(arr);
            Console.WriteLine(newStr);

            Console.WriteLine(RemoveSpace("  dsf5sdf  "));
        }

        //写一个方法string RemoveSpace(string s),将参数中字符串两侧的空格去除，返回一个新的字符串。
        static string RemoveSpace(string str)
        {
            int a = 0;
            int b = str.Length - 1;
            while (a < b && a < str.Length - 1)
            {
                for (int i = 0; i < str.Length; i++)        //while(array[start] == ' ')    start++;
                {
                    if (str[i] != ' ')
                    {
                        a = i;
                        break;
                    }
                }
                for (int i = str.Length - 1; i > 0; i--)        //while(array[end]  == ' ')     end--;
                {
                    if (str[i] != ' ')
                    {
                        b = i;
                        break;
                    }
                }
                break;
            }
            char[] newStr = new char[b - a + 1];
            for (int i = 0; i < newStr.Length; i++)
            {
                newStr[i] = str[i + a];
            }
            str = new string(newStr);
            return str;
        }
    }
}


