using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy10Times
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();
            byte[] buffer = new byte[8192];
            int n = 0;
            using (FileStream fileRead = new FileStream(@"D:\myfile.txt", FileMode.Open, FileAccess.Read))
            {
                //ms.Seek(0, SeekOrigin.Begin);
                while ((n = fileRead.Read(buffer, 0, buffer.Length)) != 0)
                {
                    ms.Write(buffer, 0, n);
                }
            }
            FileStream[] fileWrites = new FileStream[10];
            for (int i = 1; i <= 10; i++)
            {
                ms.Seek(0, SeekOrigin.Begin);
                using (fileWrites[i - 1] = new FileStream(Path.Combine("D:\\mywrite" + i + ".txt"), FileMode.Create, FileAccess.Write))
                {
                    for (int j = 0; j < fileWrites.Length; j++)
                    {
                        while ((n = ms.Read(buffer, 0, buffer.Length)) != 0)
                        {
                            fileWrites[j].Write(buffer, 0, n);
                        }
                    }
                }
            }
        }
    }
}

