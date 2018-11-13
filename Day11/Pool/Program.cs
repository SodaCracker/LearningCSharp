using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            //驻留池
            string a = "字符串";
            string b = "字符串";
            string c = new string(new char[] { '字', '符', '串' });
            string d = new string(new char[] { '字', '符', '串' });
            //new 的话，每次都是新的对象，新的地址

            Console.WriteLine(a == b);
            Console.WriteLine((object)a == (object)b);      //比较的是 a 和 b 的地址
            Console.WriteLine((object)a == (object)c);
            Console.WriteLine((object)c == (object)d);

            string s1 = string.Intern(new string(new char[] { '壹', '贰', '叁', '肆', '伍' }));      //强制加入驻留池
            string s2 = "壹贰叁肆伍";
            Console.WriteLine((object)s1 == (object)s2);
        }
    }
}
