using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestException
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception e = new DivideByZeroException();
            //Console.WriteLine(e.Message);

            string s = Console.ReadLine();
            try
            {
                Test1(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Test1(string s)
        {
            //throw new Exception();
            if (!int.TryParse(s, out int result))
            {
                throw new Exception("不能转");
            }

            if (!(result > 0))
            {
                throw new ArgumentException("不能是 0 也不能为负");
            }
            //else if (result < 0)
            //{
            //    throw new ArgumentException("不能为负");
            //}

            List<int> a = new List<int>();
            for (int i = 1; i <= result; i++)
            {
                if (result % i == 0)
                {
                    a.Add(i);
                }
            }

            foreach (int item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
