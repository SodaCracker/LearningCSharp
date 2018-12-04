using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"d:\sw.txt"))
            {
                //while (true)
                //{
                //    string s = sr.ReadLine();
                //    if (s == null)
                //    {
                //        break;
                //    }
                //    Console.WriteLine(s);
                //}

                //string s = null;
                //while ((s = sr.ReadLine()) != null)
                //{
                //    Console.WriteLine(s);
                //}

                string s = sr.ReadToEnd();
                Console.WriteLine(s);
            }
        }
    }
}
