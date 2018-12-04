using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream(@"d:\sw.txt", FileMode.Create, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs, Encoding.Default);

            //while (true)
            //{
            //    string s = Console.ReadLine();
            //    if (s == "exit")
            //    {
            //sw.Close();
            //        break;
            //    }
            //    else
            //    {
            //        sw.WriteLine(s);
            //        //sw.Write(sw.NewLine);
            //        sw.Flush();
            //    }
            //}

            StreamReader sr = new StreamReader(@"d:\sw.txt");
            char[] buffer = new char[4];
            //sr.Read(buffer, 0, buffer.Length);
            //sr.Read(buffer, 0, buffer.Length);
            //sr.Read(buffer, 0, buffer.Length);
            //sr.Read(buffer, 0, buffer.Length);

            int n = 0;
            while ((n = sr.Read(buffer, 0, buffer.Length)) != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(buffer[i]);
                }
            }
        }
    }
}
