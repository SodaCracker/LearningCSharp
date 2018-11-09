using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVisit
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            
            foreach (char item in str)
            {
                if (item == '9')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
