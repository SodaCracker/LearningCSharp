using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReadWriteMyLine
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"d:\sr.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(@"d:\outSr.txt");

            string s;
            while ((s = sr.ReadLine()) != null)
            {
                //foreach (char item in s)
                //{
                //    if (item >= '0' && item <= '9')
                //    {
                //        sw.WriteLine(s);
                //        break;
                //    }
                //}
                if (Regex.IsMatch(s,"[0-9]"))
                {
                    sw.WriteLine(s);
                    break;
                }
            }
            sw.Close();
            sr.Close();
        }
    }
}
