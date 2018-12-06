using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用List<string>的Count方法统计左右对称的字符串有几个

            List<string> list = new List<string> { "abc", "cbc", "13231", "hl343lh", "caffe" };
            int num = list.Count((string s) =>
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    if (s[i] != s[s.Length - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
            });
            Console.WriteLine(num);
            Console.WriteLine();

            //使用List<string> 的GroupBy方法对其进行分组，字符串长度相同的一组

            List<string> list2 = new List<string>() { "12345", "a", "apple", "k", "something", "somewhere" };
            IEnumerable<IGrouping<int, string>> lists = list2.GroupBy((string s) =>
            {
                return s.Length;
            });

            foreach (IGrouping<int, string> listItem in lists)
            {
                Console.Write("{0} 个字符的有： ", listItem.Key);
                foreach (string item in listItem)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }

            //统计一个目录中所有txt文件中各个字符出现次数。要求用2个线程，每个统计一部分，最终将统计结果整合打印

            Dictionary<char, int> statistic = new Dictionary<char, int>();

            Thread thread1 = new Thread((object o) =>
            {
                Dictionary<char, int> forkStatistic = (Dictionary<char, int>)o;

                string[] files = Directory.GetFiles(@"d:\", "*.txt", SearchOption.AllDirectories);
                for (int i = 0; i < files.Length / 2; i++)
                {
                    FileStream fileUse = new FileStream(files[i], FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fileUse);
                    char[] buffer = new char[8192];
                    int count = 0;
                    while ((count = sr.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        for (int j = 0; j < count; j++)
                        {
                            if (forkStatistic.ContainsKey(buffer[j]))
                            {
                                forkStatistic[buffer[j]]++;
                            }
                            else
                            {
                                forkStatistic[buffer[j]] = 1;
                            }
                        }
                    }

                    fileUse.Close();
                    sr.Close();
                }
            });

            Thread thread2 = new Thread((object o) =>
            {
                Dictionary<char, int> forkStatistic = (Dictionary<char, int>)o;

                string[] files = Directory.GetFiles(@"d:\", "*.txt", SearchOption.AllDirectories);
                for (int i = files.Length / 2; i < files.Length; i++)
                {
                    FileStream fileUse = new FileStream(files[i], FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fileUse);
                    char[] buffer = new char[8192];
                    int count = 0;
                    while ((count = sr.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        for (int j = 0; j < count; j++)
                        {
                            if (forkStatistic.ContainsKey(buffer[j]))
                            {
                                forkStatistic[buffer[j]]++;
                            }
                            else
                            {
                                forkStatistic[buffer[j]] = 1;
                            }
                        }
                    }

                    fileUse.Close();
                    sr.Close();
                }
            });

            thread1.Start(statistic);
            thread2.Start(statistic);

            thread1.Join();
            thread2.Join();

            foreach (KeyValuePair<char, int> dictEntry in statistic)
            {
                Console.WriteLine(dictEntry.Key + "/: " + dictEntry.Value);
            }
            
        }
    }
}
