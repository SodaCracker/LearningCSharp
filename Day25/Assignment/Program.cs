using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //利用MemoryStream和BinaryFormatter，将一个对象序列化后存入字节数组，再从字节数组反序列化成一个对象，以此实现深度克隆
            Cat tom = new Cat("Tom", 2);
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, tom);
                ms.Seek(0, SeekOrigin.Begin);
                object x = bf.Deserialize(ms);
                //Console.WriteLine(x);
            }

            //用一个程序将一个任意文件拆成2份(拆的时候第一个文件的长度可以是缓冲数组的倍数)
            //用另一个程序将2份合并回1份
            Split(@"d:\output\text.txt", @"d:\output",3);
            try
            {
                Combine(@"d:\output", @"d:\output\output.txt");
            }
            catch (SameNameException e)
            {
                Console.WriteLine(e);
            }
        }

        static void Split(string sourcePath, string outPathParent, int parts)
        {
            using (FileStream sourceFileStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[8192];
                int partCount = parts;
                long segmentLength = SegmentLength(sourceFileStream.Length, partCount, buffer.Length);

                FileStream[] fileStreams = new FileStream[parts];
                string outPath;

                for (int i = 0; i < parts - 1; i++)
                {
                    outPath = string.Format(@"{0}\Seg{1}.txt", outPathParent, i + 1);
                    fileStreams[i] = new FileStream(outPath, FileMode.Create, FileAccess.Write);
                    while (fileStreams[i].Length < segmentLength)
                    {
                        sourceFileStream.Read(buffer, 0, buffer.Length);
                        fileStreams[i].Write(buffer, 0, buffer.Length);
                    }
                    fileStreams[i].Close();

                }
                outPath = string.Format(@"{0}\Seg{1}.txt", outPathParent, parts);
                fileStreams[parts - 1] = new FileStream(outPath, FileMode.Create, FileAccess.Write);

                int count;
                while ((count = sourceFileStream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    fileStreams[parts - 1].Write(buffer, 0, count);
                }
                fileStreams[parts - 1].Close();
            }
        }

        static long SegmentLength(long totalLenght, int partCount, int bufferLength)
        {
            //存储规律长度和最后一片的长度
            long segmentLength;
            long reminder = totalLenght % bufferLength;
            int totalParts = (int)(totalLenght - reminder) / bufferLength;
            segmentLength = (totalParts / partCount) * bufferLength;

            return segmentLength;
        }

        static void Combine(string sourcePath, string outPath)
        {
            string[] fileNames = Directory.GetFiles(sourcePath);
            if (fileNames.Contains(outPath))
            {
                throw new SameNameException("is already existed", outPath);
            }

            int fileCount = fileNames.Length;
            int count;
            using (FileStream combinedStream = new FileStream(outPath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[8192];
                for (int i = 0; i < fileCount; i++)
                {
                    FileStream fileStream = new FileStream(fileNames[i], FileMode.Open, FileAccess.Read);
                    while ((count = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        combinedStream.Write(buffer, 0, count);
                    }
                    fileStream.Close();
                }
            }
        }
    }

    [Serializable]
    class Cat
    {
        string name;
        int age;

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return string.Format("My name is {0}, I'm {1} now.", name, age);
        }
    }

    class SameNameException : Exception
    {
        string pathName;

        public SameNameException(string message, string pathName) : base(message)
        {
            this.pathName = pathName;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", pathName, Message);
        }
    }
}
