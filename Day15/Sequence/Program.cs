using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat c = new Cat();
            //Console.WriteLine(c.Age);
            Dog d = new Dog();
        }
    }

    class Animal
    {
        protected int age;
        public int Age { get; set; }

        public Animal()
        {
            age = 10;
        }

        public Animal(int a)
        {
            age = a;
        }
    }

    class Cat : Animal
    {
        private int miceCount;

        public Cat()                    //隐式调用父类的无参构造方法
        {
            miceCount = 5;
        }
    }

    class Dog : Animal
    {
        //public Dog() : base()
        //{

        //}

        public Dog() : base(1)     //base 的括号里是实参列表，没有实参就是调用无参
        {

        }
    }
}
