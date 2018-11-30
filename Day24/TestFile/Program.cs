using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //@"d:\mydir\myfile.txt"
            //File.Create(@"d:\mydir\myfile.txt");
            //File.Delete(@"d:\mydir\myfile.txt");
            //Console.WriteLine(File.Exists(@"d:\mydir2\myfile.txt"));
            //File.Move( @"D:\mydir\folder1\myfile.txt", @"d:\mydir\myfile.txt");
            //File.WriteAllText(@"d:\mydir\myfile.txt", "第一行文件");
            //File.WriteAllText(@"d:\mydir\myfile.txt", "the first line\r\n");
            //File.AppendAllLines(@"d:\mydir\myfile.txt",new string[] { "the second line" });

            //File.Move(@"d:\mydir\myfile.txt", @"D:\myfile.txt");
            //File.AppendAllLines(@"d:\myfile.txt", new string[] { "再写一行", "再再写一行", "再再再写一行" });

            //让用户不停输入字符串，如果字符串里是整数，就追加写到文件 int.txt 中，否则写到文件 other.txt 中。

            //while (true)
            //{
            //    string s = Console.ReadLine();
            //    if (s == "exit")
            //    {
            //        break;
            //    }
            //    if (int.TryParse(s, out int result))
            //    {
            //        File.AppendAllLines(@"d:\int.txt", new string[] { s });
            //    }
            //    else
            //    {
            //        File.AppendAllLines(@"d:\other.txt", new string[] { s });
            //    }
            //}

            //while (true)
            //{
            //    string s = Console.ReadLine();
            //    if (s == "exit")
            //    {
            //        break;
            //    }
            //    try
            //    {
            //        int.Parse(s);
            //        File.AppendAllText(@"d:\int.txt", s + "\r\n");
            //    }
            //    catch (FormatException e)
            //    {
            //        Console.WriteLine(e.Message);
            //        File.AppendAllText(@"d:\other.txt", s + "\r\n");
            //    }
            //}

            Console.WriteLine(File.ReadAllText(@"d:\myfile.txt"));

            string[] lines = File.ReadAllLines(@"d:\myfile.txt");
            foreach (string item in lines)
            {
                Console.WriteLine(item);
            }

            byte[] bytes = File.ReadAllBytes(@"d:\int.txt");
            foreach (byte item in bytes)
            {
                Console.WriteLine((char)item);
            }
        }
    }
}
