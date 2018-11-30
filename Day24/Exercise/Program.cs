using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Directory.CreateDirectory(@"d:\folder" + i);
                for (char j = 'a'; j <= 'z'; j++)
                {
                    string path = @"d:\folder" + i + "\\" + "text" + j;
                    string[] strArray = new string[99];
                    for (int k = 0; k < strArray.Length; k++)
                    {
                        strArray[k] = path;
                    }
                    File.WriteAllLines(path, strArray);
                    //File.Create(path);
                    //for (int k = 0; k < 99; k++)
                    //{
                    //    File.AppendAllLines(path, new string[] { (Path.GetFullPath(path)) });
                    //}
                }
            }
        }
    }
}
