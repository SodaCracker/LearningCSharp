using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //switch (n % 2)
            //{
            //    case 0: Console.WriteLine("偶数"); break;     //break 跳出 switch 语句。
            //    case 1: Console.WriteLine("奇数"); break;
            //}

            int x = int.Parse(Console.ReadLine());
            switch (x / 10)
            {
                case 9: Console.WriteLine("优秀"); break;
                case 8: Console.WriteLine("良好"); break;
                case 6: Console.WriteLine("及格"); break;
                default: Console.WriteLine("不及格"); break;

            }
        }
    }
}
