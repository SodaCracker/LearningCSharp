using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReading
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding encoding1 = Encoding.Default;
            string str1 = encoding1.GetString(new byte[] { 206, 210 });
            Console.WriteLine(str1);

            Encoding encoding2 = Encoding.GetEncoding("utf-8");
            string str2 = encoding2.GetString(new byte[] { 230, 136, 145 });
            str2 = encoding1.GetString(new byte[] { 230, 136, 145, 121 });
            Console.WriteLine(str2);

        }
    }
}
