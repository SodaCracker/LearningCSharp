using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPath
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Path.Combine(@"C:\", "Program flies", "tencent files", "qq", "recvfiles"));
            //Console.WriteLine(Path.GetFileName(@"C:\Users\Admin\Desktop\Unity\1126\作业.txt"));
            //Console.WriteLine(Path.GetExtension(@"C:\Users\Admin\Desktop\Unity\1126\作业.txt"));
            //Console.WriteLine(Path.GetDirectoryName(@"C:\Users\Admin\Desktop\Unity\1126\作业.txt"));
            //Console.WriteLine(Path.GetFileNameWithoutExtension(@"C:\Users\Admin\Desktop\Unity\1126\作业.txt"));
            //Console.WriteLine(Path.GetPathRoot(@"C:\Users\Admin\Desktop\Unity\1126\作业.txt"));
            //Console.WriteLine(Path.ChangeExtension(@"C:\Users\Admin\Desktop\Unity\1126\作业.txt",".rtf"));
            //C:\Users\Admin\Desktop\Unity\1126\作业.txt

            string path = Console.ReadLine();
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetPathRoot(path));
        }
    }
}
