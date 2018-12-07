using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileRead = new FileStream(@"D:\myfile.txt", FileMode.Open, FileAccess.Read);
            FileStream fileWrite = new FileStream(@"D:\myfile_copy.txt", FileMode.Create, FileAccess.Write);
            byte[] buffer = new byte[8192];

            int n = 0;              //n 为本次实际读到的字节数
            while ((n = fileRead.Read(buffer, 0, buffer.Length)) != 0)
            {
                //fileWrite.Write(buffer, 0, n);
                fileWrite.Write(buffer, 0, buffer.Length);
            }

            fileRead.Close();
            fileWrite.Close();
        }
    }
}
