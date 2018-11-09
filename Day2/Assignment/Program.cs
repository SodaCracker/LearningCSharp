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
            //用户输入一个整数代表年份，判断是否为闰年。
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine("闰年");
            else
                Console.WriteLine("普通年");

            //用户输入一个字符，如果在 a~z 之间，打印小写字母，否则如果在 A~Z 之间，打印大写字母，否则如果在 48~57 之间，打印数字，否则打印其他。
            char x = char.Parse(Console.ReadLine());
            if (x >= 97 && x <= 122)
                Console.WriteLine("小写");
            else if (x >= 65 && x <= 90)
                Console.WriteLine("大写");
            else if (x >= 48 && x <= 57)
                Console.WriteLine("数字");
            else
                Console.WriteLine("其他");
        }
    }
}
