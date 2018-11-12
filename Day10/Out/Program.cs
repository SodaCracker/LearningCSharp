using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;              //如果 i 只用在 out 里，可以不赋值
            Test(out i);
            Console.WriteLine(i);

            int num;
            if (int.TryParse("123", out num))
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("格式不对");
            }
        }

        static void Test(out int i)
        {
            i = 10;
        }
    }
}
