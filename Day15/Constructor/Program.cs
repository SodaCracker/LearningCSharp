using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat newCat = new Cat();
            Cat hachi = new Cat("Hachi", 5);
            hachi.ShowInfo();
            hachi.NewHobby("Eating");
            hachi.NewHobby("Sleeping");
            hachi.NewHobby("Playing");

            Tortois t = new Tortois();
            GC.Collect();
        }
    }

    class Cat
    {
        //public Cat()
        //{
        //    Console.WriteLine("猫的构造方法被调用了");
        //}

        private string[] hobbies;
        private int index;

        public string Name { get; set; }
        public int Age { get; set; }

        public Cat()
        {

        }

        public Cat(string name, int age)        //如果自定义过构造器，原来的默认构造器就失效了。   //需要自己再写一个。
        {
            Name = name;
            Age = age;
            hobbies = new string[1];
        }

        public void NewHobby(string s)
        {
            if (index == hobbies.Length)
            {
                string[] tempArr = new string[hobbies.Length * 2];
                for (int i = 0; i < index; i++)
                {
                    tempArr[i] = hobbies[i];
                }
                hobbies = tempArr;
            }
            hobbies[index++] = s;
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0} is a(n) {1} year old kitten.", Name, Age);
        }
    }
    class Tortois
    {
        private float speed;
        private float weight;
        private string color;
        private string name;
        private bool isAdult;

        public Tortois(float s, float w, string c, string n, bool ia)
        {
            speed = s;
            weight = w;
            color = c;
            name = n;
            isAdult = ia;
        }

        public Tortois() : this(0.1f, 20.0f, "black", "Michalangelo", true)
        {

        }

        ~Tortois()
        {

        }
    }
}
