using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBinaryWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"d:\fs", FileMode.Create, FileAccess.Write);

            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(100);
                bw.Write('a');
                bw.Write("abc");
                bw.Write(100.0f);
                bw.Write(true);
            }

            FileStream fs2 = new FileStream(@"d:\fs", FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs2, Encoding.Default);
            byte[] buffer = new byte[fs2.Length];
            int n = 0;
            while ((n = br.Read(buffer, 0, buffer.Length)) != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(buffer[i] + "\t");
                }
            }

            fs2.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadChar());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadSingle());
            Console.WriteLine(br.ReadBoolean());
        }
    }
}
