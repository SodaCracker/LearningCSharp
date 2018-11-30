using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //统计一个目录中子目录的个数，文件总数，以及每种后缀的文件个数
            DirectoryInfo di = new DirectoryInfo(@"D:\myfolder");
            Console.WriteLine(di.GetDirectories("*", SearchOption.AllDirectories).Length);
            FileInfo[] files = di.GetFiles("*", SearchOption.AllDirectories);
            Console.WriteLine(files.Length);

            Dictionary<string, int> statics = new Dictionary<string, int>();
            foreach (FileInfo file in files)
            {
                if (statics.ContainsKey(file.Extension))
                {
                    statics[file.Extension]++;
                }
                else
                {
                    statics.Add(file.Extension, 1);
                }
            }

            foreach (KeyValuePair<string, int> dictEntry in statics)
            {
                Console.WriteLine("{0}: {1}", dictEntry.Key, dictEntry.Value);
            }

            //根据一个字符串到一个目录中寻找内容包含这个字符串的文件，打印出所有符合条件的文件的路径
            string target = Console.ReadLine();

            DirectoryInfo di2 = new DirectoryInfo(@"D:\myfolder");
            FileInfo[] files2 = di2.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo file in files2)
            {
                //string text = File.ReadAllText(file.FullName);
                //if (text.Contains(target))
                //{
                //    Console.WriteLine(file.FullName);
                //}
                string[] lines = File.ReadAllLines(file.FullName);
                foreach (string line in lines)
                {
                    //Console.WriteLine(line);
                    if (line.Contains(target))
                    {
                        Console.WriteLine(file.FullName);
                        break;
                    }
                }
            }
        }
    }
}
