using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream(@"D:\myfile2.txt",FileMode.Create,FileAccess.Write))
            {
                byte[] bytes = new byte[26];
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)(i + 97);
                }
                Console.WriteLine(int.Parse("abc"));
                fs.Write(bytes, 0, bytes.Length);
                fs.Write(new byte[] { 13, 10 }, 0, 2);
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)(i + 65);
                }
                fs.Write(bytes, 0, bytes.Length);
            }
            Console.ReadLine();
        }
    }
}
