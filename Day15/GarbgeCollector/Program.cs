using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbgeCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Data d = new Data();
                string s = Console.ReadLine();
                d = null;
                if (s == "回收")
                {
                    GC.Collect();
                }
            }
        }
    }

    class Data
    {
        byte[] datas = new byte[1000];

        ~Data()
        {
            Console.WriteLine("销毁");
        }
    }
}
