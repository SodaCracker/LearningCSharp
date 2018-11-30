using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"D:\mydir");
            Directory.CreateDirectory(@"d:\mydir2");
            Directory.Delete(@"d:\mydir2");
            Console.WriteLine(Directory.Exists(@"d:\mydir"));
            Console.WriteLine(Directory.Exists(@"d:\mydir2"));

            string[] files = Directory.GetFiles(@"d:\mydir", "*", SearchOption.AllDirectories);
            foreach (string item in files)
            {
                Console.WriteLine(item);
            }
        }
    }
}
