using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecursiveFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\");
            //di.Create();
            //Stack<DirectoryInfo> dirStack = new Stack<DirectoryInfo>();

            List<string> list = new List<string>();
            MyRecursive(di, list);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void MyRecursive(DirectoryInfo di, List<string> dirString)
        {
            if (di.GetDirectories().Length != 0)
            {
                FileInfo[] addedFile = di.GetFiles();
                foreach (FileInfo item in addedFile)
                {
                    dirString.Add(item.FullName);
                }
                DirectoryInfo[] addedDir = di.GetDirectories();
                foreach (DirectoryInfo item in addedDir)
                {
                    
                    MyRecursive(item, dirString);
                    //dirString.Add(item.FullName);
                }
            }
            else
            {
                FileInfo[] addedFile = di.GetFiles();
                foreach (FileInfo item in addedFile)
                {
                    dirString.Add(item.FullName);
                }
            }
        }
    }
}
