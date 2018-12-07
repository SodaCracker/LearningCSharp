using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClone
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.age = 10;
            s.cat = new Cat();
        }
    }

    [Serializable]
    class Student
    {
        public int age;
        public string name;
        public Cat cat;
    }

    class Cat
    {

    }
}
