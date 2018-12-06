using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, int> f = (int a, int b) => a + b;
            //Console.WriteLine(f(1, 2));

            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            //list.ForEach((num) =>
            //{
            //    Console.WriteLine(++num);
            //});

            bool AllOdd = list.All((int num) =>
            {
                return num % 2 == 0;
            });

            IEnumerable<int> newList = list.Select((int num) =>
             {
                 return num + 1;
             });

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
