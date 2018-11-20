using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseThis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student(10);
            //Console.WriteLine(s.Age);

            Player a = new Player();
            Player b = new Player();

            a.Attack(b);
        }
    }

    class Student
    {
        public int Age { get; protected set; } = 10;

        public Student(int age)
        {
            Age = age;      //形参和字段同名，就近指代形参
        }
    }

    class MyBuilder
    {
        private char[] charArr = new char[1024];
        private int index;

        public MyBuilder Append(char c)
        {
            charArr[index++] = c;
            return this;        //返回本对象，this 是个指针
        }

        public override string ToString()
        {
            return new string(charArr, 0, index);           //******** 一次性创建字符串
        }
    }

    class Player
    {
        private int hitPoint = 100;
        private int power;

        public void Attack(Player player)
        {
            if (player != this)
            {
                player.BeAttacked(power);
            }
            else
            {
                Console.WriteLine("请不要");
            }
        }

        public void BeAttacked(int hp)
        {
            hitPoint -= hp;
        }
    }
}
