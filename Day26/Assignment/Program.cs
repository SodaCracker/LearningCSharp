using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //从一个文本文件一个个字符读取，每个读到的字母字符写到另一个文件
            FileStream sourceFile = new FileStream(@"d:\cs\source.txt", FileMode.Open, FileAccess.Read);
            FileStream targetFile = new FileStream(@"d:\cs\target.txt", FileMode.Create, FileAccess.Write);

            char[] buffer = new char[8];
            int n;
            using (StreamWriter sw = new StreamWriter(targetFile))
            {
                using (StreamReader sr = new StreamReader(sourceFile))
                {
                    //while ((n = sr.Read(buffer, 0, 1)) != 0)
                    //{
                    //    sw.Write(buffer);
                    //}
                    char c;

                    while ((n = sr.Read()) != -1)
                    {
                        c = (char)n;
                        if (char.IsLetter(c))
                        {
                            sw.Write(c);
                        }
                    }

                    while ((n = sr.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        foreach (int item in buffer)
                        {
                            c = (char)n;
                            if (char.IsLetter(c))
                            {
                                sw.Write(c);
                            }
                        }
                    }
                }
            }

            //选择题自动批改，从一个文件读取标准答案，再从另一个文件读取学生答案，并通过比对计算出成绩
            //标准答案:
            //1.A
            //2.B
            //3.C
            //4.D
            //5.C

            //小明答案:
            //1.A
            //2.C
            //3.C
            //4.C
            //5.C
            //得分3

            Dictionary<string, string> std = new Dictionary<string, string>();
            string s = null;
            int count = 0;

            using (FileStream stdAnswer = new FileStream(@"d:\cs\stdAnswer.txt", FileMode.Open, FileAccess.Read))
            {
                StreamReader stdAnswerStream = new StreamReader(stdAnswer);
                while ((s = stdAnswerStream.ReadLine()) != null)
                {
                    string[] temp = s.Split('.');
                    std[temp[0]] = temp[1];
                }
            }

            using (FileStream answerSheet = new FileStream(@"d:\cs\answerSheet.txt", FileMode.Open, FileAccess.Read))
            {
                StreamReader answerSheetStream = new StreamReader(answerSheet);
                while ((s = answerSheetStream.ReadLine()) != null)
                {
                    if (Regex.IsMatch(s, "[.]"))
                    {
                        string[] temp = s.Split('.');
                        if (std[temp[0].Trim()] == temp[1].Trim().ToUpper())
                        {
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine("得分{0}", count);
        }
    }
}
