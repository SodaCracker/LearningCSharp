using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestThread
{
    public delegate void SomeLogic();

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, main thread ID = {0}", Thread.CurrentThread.ManagedThreadId);
            Thread t = new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("子：{0}", i);
                }
            }
                );
            t.Start();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("主：{0}", i);
            }
            //Thread.Sleep(10);
            //Console.WriteLine("xxx");
        }

        //static void RunInSubThread()
        //{
        //    Console.WriteLine("Hello, current thread ID = {0}", Thread.CurrentThread.ManagedThreadId);
        //}
    }
}
