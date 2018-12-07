using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileRead
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"D:\myfile.txt", FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[4];

            //常规
            //while (true)
            //{
            //    int n = file.Read(buffer, 0, 4);
            //    if (n == 0)
            //    {
            //        break;
            //    }
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.WriteLine(buffer[i]);
            //    }
            //}

            //简洁
            int n = 0;
            while ((n = file.Read(buffer, 0, buffer.Length)) != 0)        //先 read 到 buffer 中，实际读到的字节数给 n (n 不为 0 才循环)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine((char)buffer[i]);
                }
            }


            file.Close();
        }
    }
}
