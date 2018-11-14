using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,2,3,...length-1,...3,2,1,1
            //string s = "字符串截取";
            //for (int i = 1; i <= s.Length; i++)
            //{
            //    Console.WriteLine(s.Substring(0, i));
            //}
            //for (int i = s.Length - 1; i > 0; i--)
            //{
            //    Console.WriteLine(s.Substring(0, i));
            //}

            //求出所有的子字符串
        }

        static void RemoveOne(string s, string[] array, ref int index)
        {
            if (s.Length == 1)
            {
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                string sNew = s.Remove(i, 1);
                Add(sNew, array, ref index);
                RemoveOne(sNew, array, ref index);
            }
        }

        static void Add(string s, string[] array, ref int index)
        {
            for (int i = 0; i < index; i++)
            {
                if (array[i] == s)
                {
                    return;
                }
            }
            array[index] = s;
            index++;
        }


    }
}
