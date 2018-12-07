using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TestBinaryFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "abc";
            Student ming = new Student("Ming", 23);
            BinaryFormatter bf = new BinaryFormatter();

            //以下为写
            using (FileStream fs = new FileStream(@"d:\obj", FileMode.Create, FileAccess.Write))
            {
                bf.Serialize(fs, ming);
            }

            //以下为读，反序列化
            using (FileStream fs = new FileStream(@"d:\obj", FileMode.Open, FileAccess.Read))
            {
                object obj = bf.Deserialize(fs);
                Console.WriteLine(obj);
            }
        }
    }

    [Serializable]
    class Student
    {
        bool isAdult;

        public int Age { get; set; }
        public string Name { set; get; }
        public bool IsAdult
        {
            set
            {
                if (Age >= 18)
                {
                    isAdult = true;
                }
                else
                {
                    isAdult = false;
                }
            }
            get
            {
                return isAdult;
            }
        }

        public Student(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", Name, Age, IsAdult ? "是" : "否");
        }
    }
}
