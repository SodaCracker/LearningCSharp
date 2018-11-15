using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('a');
            sb.Append(true);
            sb.Append("我们连").Append("一起");
            string s = sb.ToString();
            Console.WriteLine(s);

            int[] numArr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numArr[i] = i;
            }
            StringBuilder sb2 = new StringBuilder();
            foreach (int item in numArr)
            {
                sb2.Append(item);
            }
            string s2 = sb2.ToString();
            Console.WriteLine(s2);

            //不停输入字符串，最后连成长字符串
            //StringBuilder sb3 = new StringBuilder();
            //while (true)
            //{
            //    string text = Console.ReadLine();
            //    if (text == "exit")
            //    {
            //        break;
            //    }
            //    sb3.Append(text);
            //}
            //string outText = sb3.ToString();
            //Console.WriteLine(outText);

            Console.WriteLine("abc".Insert(0, "a"));
        }
    }
}
