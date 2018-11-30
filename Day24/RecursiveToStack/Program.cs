using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveToStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<DirectoryInfo> stack = new Stack<DirectoryInfo>();
            DirectoryInfo di = new DirectoryInfo(@"d:\recursive");

            DirectoryInfo[] subDirectories = ToSub(di);
            foreach (DirectoryInfo item in subDirectories)
            {
                stack.Push(item);
            }

            while (stack.Count > 0)
            {
                DirectoryInfo topDir = stack.Pop();
                DirectoryInfo[] array = ToSub(topDir);
                foreach (DirectoryInfo item in array)
                {
                    stack.Push(item);
                }
            }
        }

        static DirectoryInfo[] ToSub(DirectoryInfo di)
        {
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo item in files)
            {
                Console.WriteLine(item.FullName);
            }

            return di.GetDirectories();
        }
    }
}
