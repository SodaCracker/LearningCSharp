using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //Console.WriteLine(Regex.IsMatch(s, "^[a-zA-Z0-9]$"));

            //根据输入的实际情况打印大写、小写、数字、其他
            //if (Regex.IsMatch(s, "^[A-Z]$"))
            //{
            //    Console.WriteLine("大写");
            //}
            //else if (Regex.IsMatch(s, "^[a-z]$"))
            //{
            //    Console.WriteLine("小写");
            //}
            //else if (Regex.IsMatch(s, "^[0-9]$"))
            //{
            //    Console.WriteLine("数字");
            //}
            //else
            //{
            //    Console.WriteLine("其他");
            //}

            ////是否由 3 个数字组成
            //if (Regex.IsMatch(s, "^[0-9][0-9][0-9]$"))
            //{
            //    Console.WriteLine("是");
            //}
            //else
            //{
            //    Console.WriteLine("否");
            //}

            ////是否由 1 个字母和 2 个数字
            //if (Regex.IsMatch(s,"^[a-zA-Z][0-9][0-9]$"))
            //{
            //    Console.WriteLine("是");
            //}
            //else
            //{
            //    Console.WriteLine("否");
            //}

            //Console.WriteLine(Regex.Equals("[a-zA-Z0-9]","."));
            //Console.WriteLine(Regex.IsMatch("1.5","[0-9]\\.[0-9]"));

            //限定符
            //+ 表示该符号之前的字符有 1 到多个
            //*
            //？

            //[0-9]+
            //[0-9a-zA-Z]{6,12}
            //[A-Z][a-z]*
            //[1-9][0-9]*

            //Console.WriteLine(Regex.IsMatch("adfdfad9", "^[0-9a-zA-Z]{6,12}$"));
            Console.WriteLine(Regex.IsMatch("&*&^(", "^[^0-9a-zA-Z]*$"));

        }
    }
}
