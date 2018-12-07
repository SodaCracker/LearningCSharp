using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMemoryStream
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(new byte[] { 97, 97, 99, 100, 101 }, 0, 5);
            //byte[] bytes = ms.GetBuffer();
            //Console.WriteLine(ms.Capacity);     //容量，最多可以容纳多少，自动扩容
            //Console.WriteLine(ms.Length);       //有效数据
            byte[] buffer = new byte[4];
            int n = 0;
            ms.Seek(0, SeekOrigin.Begin);
            //n = ms.Read(buffer, 0, n);
            while ((n = ms.Read(buffer, 0, buffer.Length)) != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(buffer[i]);
                }
            }
        }
    }
}
