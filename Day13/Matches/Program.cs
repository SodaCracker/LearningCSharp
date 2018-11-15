using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Matches
{
    class Program
    {
        static void Main(string[] args)
        {
            //MatchCollection mc = Regex.Matches("abc123ds3erg4rth5", "[0-9]+");
            MatchCollection mc = Regex.Matches("a=34, b=43, c=462, d=452", "b=[0-9]+");
            foreach (object item in mc)
            {
                Console.WriteLine(item);
            }

            //xiayi@the9.com，提取xiayi
            //Match m = Regex.Match("xiayi@the9.com", "[a-zA-z0-9]+@");
            Match m = Regex.Match("xiayi@the9.com", "[^@]+");
            //Console.WriteLine(m.Value.Substring(0, m.Value.Length - 1));
            Console.WriteLine(m.Value);

            //姓名：小明，年龄：149，性别：男，提取年龄
            Match m2 = Regex.Match("姓名：小明，年龄：149，性别：男，提取年龄", "年龄：([0-9]+)");
            Console.WriteLine(m2.Value);

            //找出连续数字
            MatchCollection mc2 = Regex.Matches("a1b6633c98", "[0-9]+");
            foreach (object item in mc2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
