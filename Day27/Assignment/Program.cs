using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public delegate void Statistic(string s);

    class Program
    {
        static void Main(string[] args)
        {
            FileStat fs = new FileStat();

            fs.statistic += (string str) =>
            { Console.WriteLine("file size is {0}", str.Length); };
            fs.statistic += (string str) =>
            { Console.WriteLine(str.Contains("\r\n") ? "multi line" : "1 line"); };
            fs.statistic += str =>
            {
                int lowerCount = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= 'a' && str[i] <= 'z')
                    {
                        lowerCount++;
                    }
                }
                Console.WriteLine("小写字母有{0}个", lowerCount);
            };


            fs.Stat(@"D:\cs");
        }
    }

    //FileStat类的Stat方法，能统计一目录中的所有txt文件。具体统计逻辑，可通过类中的statistic委托字段动态添加，试完成FileStat定义

    class FileStat
    {
        public event Statistic statistic;

        public void Stat(string path)
        {
            //string[] filePath = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
            //foreach (string item in filePath)
            //{
            //    string text = File.ReadAllText(item);
            //    statistic(text);
            //}

            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles("*.txt", SearchOption.AllDirectories);
            foreach (FileInfo item in files)
            {
                Console.WriteLine("文件名：{0}", item.FullName);
                string content = File.ReadAllText(item.FullName);
                statistic(content);
            }
        }
    }
}
