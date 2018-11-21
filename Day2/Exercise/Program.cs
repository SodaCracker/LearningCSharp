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
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(a * a + b);

            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(str1 + str2 + num1 + num2);

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(a % b);

            //string strc = Console.ReadLine();
            //int c = int.Parse(strc);
            //Console.WriteLine(c % 10 + c / 10 % 10);
            //Console.WriteLine(strc.Substring(strc.Length - 1, 1) + strc.Substring(strc.Length - 2, 1));

            //string bin = "";
            //while (c > 0)
            //{
            //    bin = c % 2 + bin;
            //    c = c / 2;
            //}
            //Console.WriteLine(bin);

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(++a * --b);

            //int num = int.Parse(Console.ReadLine());
            //num += 5;
            //num *= 3;
            //num -= 2;
            //num /= 3;
            //Console.WriteLine(num);

            //int a = 1;
            //int b = 2;
            //int c = a;
            //a = b;
            //b = c;
            //a = a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine(Convert.ToString(a) + Convert.ToString(b));

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(a > b);
            //Console.WriteLine(a < b);
            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);

            //string str = Console.ReadLine();
            //Console.WriteLine(str[0] == str[1]);

            int a = int.Parse(Console.ReadLine());
            if (a % 6 == 0 && a % 8 == 0)
            {
                Console.WriteLine("这个数能被6、8整除。");
            }

            string str = Console.ReadLine();
            if (str[1] == str[0] + 1)
            {
                Console.WriteLine("第二个字符比第一个字符大 1.");
            }
        }
    }
}
