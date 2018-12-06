using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SubThreadResult
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            data.Start = 50;
            data.End = 60;

            Thread t = new Thread((object o) =>
            {
                Data subData = (Data)o;
                int sum = 0;
                for (int i = subData.Start; i <= subData.End; i++)
                {
                    sum += i;
                }
                subData.Result = sum;

            });

            t.Start(data);
            //Console.WriteLine(data.Start);
            //Console.WriteLine(data.End);
            t.Join();
            Console.WriteLine(data.Result);
        }
    }

    class Data
    {
        public int Start { get; set; }
        public int End { get; set; }
        public int Result { get; set; }

    }
}
