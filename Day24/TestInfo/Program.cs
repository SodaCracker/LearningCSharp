using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = Path.Combine(@"d:\","myfolder");
            DirectoryInfo di = new DirectoryInfo(dirPath);
            Console.WriteLine(di.Exists);
            di.Create();
            Console.WriteLine(di.Exists);
            Console.WriteLine(di.Parent);
            Console.WriteLine(di.Root);

            string filePath = Path.Combine(dirPath, "myfile");
            FileInfo fi = new FileInfo(filePath);
            fi.Create();
        }
    }
}
