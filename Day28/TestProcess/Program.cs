using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();

            //foreach (Process p in processes)
            //{
            //    Console.WriteLine("Process id: {1}; Process name: {0}", p.ProcessName, p.Id);
            //}

            //Process msPaint = Process.GetProcessById(3908);
            //Console.WriteLine(msPaint.ProcessName);
            //msPaint.Kill();
            Process[] notepads = new Process[5];
            //for (int i = 0; i < notepads.Length; i++)
            //{
            //    notepads[i] = Process.Start("notepad");
            //}
            notepads = Process.GetProcessesByName("notepad");
            foreach (Process p in notepads)
            {
                p.Kill();
            }

            Console.WriteLine(Process.GetCurrentProcess().ProcessName);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }
    }
}
