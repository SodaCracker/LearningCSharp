using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("dkfjaldsjfosdf".IndexOf('d'));
            //Console.WriteLine("dkfjaldsjfosdf".LastIndexOf('d'));
            //string s = "dkfjaldsjfosdf";
            //Console.WriteLine(s.IndexOf('d', s.IndexOf('d') + 1));

            //让用户输入一个字符串，打印字符 9 在其中第二次出现的位置，如果有的话。
            string str = Console.ReadLine();
            Console.WriteLine(str.IndexOf('9', str.IndexOf('9') + 1));

            //让用户输入一个字符串，打印字符 9 在其中出现的所有位置。
            string str2 = Console.ReadLine();
            int index = 0;
            for (int i = 0; i < str2.Length; i = index + 1)
            {
                index = str2.IndexOf('9', i);
                if (index == -1)
                {
                    break;
                }
                Console.WriteLine(index);
            }
        }
    }
}
