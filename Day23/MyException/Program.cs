using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Test(-10);
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Num + e.OccurTime.ToShortTimeString());
            }
        }

        static void Test(int number)
        {
            if (number<0)
            {
                throw new MyException("can not be negative", number);
            }
        }
    }

    class MyException : Exception
    {
        public DataTime OccurTime { get; set; }
        public int Num { get; set; }

        public MyException(string message, int n) : base(message)
        {
            Num = n;
            OccurTime = DataTime.Now;
        }
    }

    class DataTime
    {
        public static int Now { get; set; }
    }
}
