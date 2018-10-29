using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //Console.WriteLine(s + s + s);
            //Console.WriteLine();
            //Console.Write(s);
            //Console.WriteLine();

            //string str = Console.ReadLine();
            //int n = int.Parse(str);
            //Console.WriteLine(n + 1);

            char c = 'j';
            Console.WriteLine(c);
            Console.WriteLine((int)c);
            Console.WriteLine((char)106);

            //string str2 = Console.ReadLine();
            //char c2 = str2[0];
            //Console.WriteLine(c2);
        }
    }
}

/*
数据类型
一、值类型
    数值类型
        整数
            int     4 字节    -2147483648 ～ 2147483648
            long    8 字节    -9223372036854775808 ～ 9223372036854775808
            byte    1 字节    0～255                                         （sbyte  -128~127）
            short   2 字节    -32768 ～ 32767
        符点数
            float   4 字节    -3.4*10(-38)～3.4*10(38)                       不精确
            double  8 字节    -1.7*10(-308)～1.7*10(308)                     不精确
            decimal 16 字节                                                  精确
        字符类型
            char    ASCII 码
        布尔类型
            true/false
        结构体 ~
        枚举 ~

二、引用类型 ~
*/
