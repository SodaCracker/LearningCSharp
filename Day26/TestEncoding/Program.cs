using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encoding.Default);

            Encoding encoding1 = Encoding.Default;
            byte[] bytes1 = Encoding.Default.GetBytes("我");
            foreach (byte item in bytes1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Encoding encoding2 = Encoding.GetEncoding("utf-8");
            byte[] bytes2 = encoding2.GetBytes("我");
            foreach (byte item in bytes2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Encoding encoding3 = Encoding.GetEncoding("unicode");
            byte[] bytes3 = encoding3.GetBytes("我");
            foreach (byte item in bytes3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            File.WriteAllBytes(@"d:\ch1.txt", bytes1);
            File.WriteAllBytes(@"d:\ch2.txt", bytes2);
            File.WriteAllBytes(@"d:\ch3.txt", bytes3);
        }
    }
}
