using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "abcde";
            //Console.WriteLine(s.Contains("abc"));
            //Console.WriteLine(s.Contains("ccd"));

            //让用户不停输入字符串，如果其包含？，或者以#开头，就打印格式错误，否则打印字符串
            while (true)
            {
                string s = Console.ReadLine();
                if (s.Contains("?") || s.StartsWith("#"))
                {
                    Console.WriteLine("格式错误");
                }
                else
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
