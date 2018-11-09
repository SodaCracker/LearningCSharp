using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            //sw.Start();
            //Console.ReadLine();
            //Console.WriteLine(sw.ElapsedMilliseconds/1000f);

            //统计一个用户在程序开始后 2 秒内点击回车的次数。
            sw.Start();
            int count = 0;
            for (; ; )
            {
                Console.ReadLine();
                if (sw.ElapsedMilliseconds / 1000f >= 2)
                {
                    break;
                }
                count++;
            }
            Console.WriteLine("点了{0}次回车", count);
        }
    }
}
