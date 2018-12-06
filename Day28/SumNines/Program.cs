using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumNines
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] array = s.ToCharArray();

            Data data = new Data();
            data.Array = array;

            Thread t1 = new Thread((object o) =>
            {
                char[] subArray = (char[])o;
                for (int i = 0; i < subArray.Length / 2; i++)
                {
                    if (subArray[i] == 9)
                    {
                        data.Result1++;
                    }
                }
            });

            Thread t2 = new Thread((object o) =>
            {
                char[] subArray = (char[])o;
                for (int i = subArray.Length / 2; i < subArray.Length; i++)
                {
                    if (subArray[i] == 9)
                    {
                        data.Result2++;
                    }
                }
            });

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine(data.Result1);
            Console.WriteLine(data.Result2);
        }
    }

    class Data
    {
        public char[] Array { get; set; }
        public int Result1;
        public int Result2;
    }
}
