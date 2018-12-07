using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream(@"d:\myfile.txt", FileMode.Append, FileAccess.Write);
            //fs.Write(new byte[] { 97, 98, 99 }, 0, 2);
            //fs.Close();

            //向文件中写入 a-z,换行，再写A-Z
            FileStream fs = new FileStream(@"D:\myfile.txt", FileMode.Create, FileAccess.Write);
            byte[] text = new byte[1024];
            char c = 'a';
            for (int i = 0; i < 26; i++)
            {
                text[i] = (byte)c;
                c++;
            }
            text[26] = (byte)('\r');
            text[27] = (byte)('\n');
            c = 'A';
            for (int i = 28; i < 28 + 26; i++)
            {
                text[i] = (byte)c;
                c++;
            }
            fs.Write(text, 0, 26 + 2 + 26);
            fs.Close();
        }
    }
}
