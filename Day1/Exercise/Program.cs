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
            //输入两个 int 类型数字，打印两者之和。
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);

            //输入两个 long 类型数字，打印两者相除结果。
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());
            Console.WriteLine(c / d);

            //输入两个 double 类型数字，打印两者之和。
            double e = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine(e + f);

            //输入两个 float 类型数字，打印两者相除结果。
            float g = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine(g / h);

            //输入两个字符串和一个数字下标，打印字符串中下标位置的字符。
            string str = Console.ReadLine();
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(str[index]);

            //输入一个字符，打印其 ASCII 码。
            char x = char.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToInt32(x));
            Console.WriteLine((int)x);

            //输入一个数字，打印其字符。
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((char)num);
        }
    }
}
