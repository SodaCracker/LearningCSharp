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
            //让用户输入一个整数表示 info, 打印其对应属性。
            //比如输入 info 为 37, 打印 “成年”， “学生”， “有子女”。最多是到 255.

            byte adult = 1;         //00000001
            byte male = 2;          //00000010
            byte stu = 4;           //00000100
            byte married = 8;       //00001000
            byte chinese = 16;      //00010000
            byte child = 32;        //00100000
            byte gamedev = 64;      //01000000
            byte info = (byte)(chinese | male | gamedev);
            //Console.WriteLine(Convert.ToString(info, 2));

            info = byte.Parse(Console.ReadLine());
            if ((info & adult) > 0)
                Console.Write("adult ");
            if ((info & male) > 0)
                Console.Write("male ");
            if ((info & stu) > 0)
                Console.Write("student ");
            if ((info & married) > 0)
                Console.Write("married ");
            if ((info & chinese) > 0)
                Console.Write("Chinese ");
            if ((info & child) > 0)
                Console.Write("has child ");
            if ((info & gamedev) > 0)                //(n & (1 << 6)) > 0
                Console.WriteLine("do game developing");
        }
    }
}
