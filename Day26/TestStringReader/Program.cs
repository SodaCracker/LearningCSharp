using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStringReader
{
    class Program
    {
        static void Main(string[] args)
        {
            StringReader sr = new StringReader("my string\r\nyour string\r\n");

            //string s;
            //while ((s = sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(s);
            //}

            countText(sr);
            sr.Close();
        }

        static void ReadLines(TextReader r)
        {
            string line = null;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            r.Close();
        }

        static void countText(TextReader r)
        {
            Dictionary<char, int> myDict = new Dictionary<char, int>();

            string line = null;
            while ((line = r.ReadLine()) != null)
            {
                foreach (char item in line)
                {
                    if (myDict.ContainsKey(item))
                    {
                        myDict[item]++;
                    }
                    else
                    {
                        myDict[item] = 1;
                    }
                }
            }

            //char[] buffer = new char[1024];
            //int n = 0;
            //while ((n = r.Read(buffer, 0, buffer.Length)) != 0)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (myDict.ContainsKey(buffer[i]))
            //        {
            //            myDict[buffer[i]]++;
            //        }
            //        else
            //        {
            //            myDict[buffer[i]] = 1;
            //        }
            //    }
            //}

            foreach (KeyValuePair<char, int> item in myDict)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            r.Close();
        }
    }
}
