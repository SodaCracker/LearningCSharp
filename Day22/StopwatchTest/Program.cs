using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrayList = new List<int>(new int[1024] );
            LinkedList<int> linkedList = new LinkedList<int>(new int[1024]);
            Stopwatch sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < 50000; i++)
            {
                //arrayList.Insert(0, 5);
                linkedList.AddFirst(5);
            }
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
