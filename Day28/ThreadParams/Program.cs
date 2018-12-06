using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread sub = new Thread(SubThreadParams);
            sub.Start(9);

        }

        static void SubThreadParams(object o)
        {
            Console.WriteLine("这是子线程的方法，传入的数据为 {0} (必须是 object，且只能有一个)", o);
            Console.WriteLine((int)o + 1);
        }
    }
}
