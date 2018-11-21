using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human h1 = new Human(11);
            //Human h2 = new Human(12);
            ////h1.hasSoul = false;                 //不行，不能改单个对象的静态字段
            //Human.hasSoul = true;                 //改类的可以

            //Cat c1 = new Cat();
            //Cat c2 = new Cat();
            //Console.WriteLine(Cat.count);

            //Account a1 = new Account();
            //Account a2 = new Account();
            //a1.Save(1000);
            //a1.Withdraw(500);
            //a2.Save(2000);
            //a2.Withdraw(200);
            //Console.WriteLine(Account.withdrawCount);
            //Console.WriteLine(Account.withdrawSum);

            Point p1 = new Point(0, 1);
            Point p2 = new Point(1, 0);
            p1.Move(0, 1);
            p2.Move(1, 0);
            Console.WriteLine(p1.CurrentDistance);
            Console.WriteLine(p2.CurrentDistance);
            Console.WriteLine(Point.totalDistance);

        }
    }

    class Human
    {
        public int age;
        public static bool hasSoul = true;

        public Human(int age)
        {
            this.age = age;
        }
    }

    class Cat
    {
        public static int count = 0;

        public Cat()
        {
            count++;
        }
    }

    class Account
    {
        public float Deposit { get; protected set; }
        public static int withdrawCount = 0;
        public static double withdrawSum = 0;

        public virtual void Save(float sum)
        {
            if (sum >= 0)
            {
                Deposit += sum;
                //withdrawCount++;
                //withdrawSum += sum;
            }
            else
            {
                Console.WriteLine("错误");
            }
        }

        public virtual void Withdraw(float sum)
        {
            if (Deposit - sum >= 0)
            {
                Deposit -= sum;
                withdrawCount++;
                withdrawSum -= sum;
            }
            else
            {
                Console.WriteLine("余额不足");
            }
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        protected double currentDistance = 0;
        public static double totalDistance = 0;

        public double CurrentDistance { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Move(double horizontal, double vertical)
        {
            X += horizontal;
            Y += vertical;
            CurrentDistance += Math.Sqrt(horizontal * horizontal + vertical * vertical);
            totalDistance += CurrentDistance;
        }
    }
}
