using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string s0 = "dlafkhdf";
            string s1 = s0.Replace('d', 'k');
            Console.WriteLine(s1);
            string s2 = s0.Replace("dl", "KKK");
            Console.WriteLine(s2);

            //让用户不停输入字符串，把其中所有的“他妈”替换为**
            string[] keywords = { "tmd", "他妈", "你妈" };
            while (true)
            {
                string s = Console.ReadLine();
                foreach (string item in keywords)
                {
                    if (s.Contains(item))
                    {
                        s = s.Replace(item, "***");
                    }
                }
                Console.WriteLine(s);
            }
        }
    }
}
