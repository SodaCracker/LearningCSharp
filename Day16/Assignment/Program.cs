using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal m = new Mammal();
            Whale w = new Whale();
            Bat b = new Bat();
            m.Move(); m.Eat();
            w.Move(); w.Eat();
            b.Move(); b.Eat();

            RecordedAccount a = new RecordedAccount();
            a.Save(100);
            a.Withdraw(10);
            Console.WriteLine(a.Deposit);
            a.ShowRecord();

            PolyLine pl = new PolyLine();
            Point x = new Point(0, 0);
            Point y = new Point(1, 0);
            Point z = new Point(2, 0);
            //pl.Add(x);
            //pl.Add(y);
            //pl.Add(z);
            pl.Add(x).Add(y).Add(z);
            Console.WriteLine(pl.GetLength());
        }
    }

    //定义一个哺乳动物类Mamal，有一个Move()方法，方法内容是打印"跑"，
    //另有一个Eat()方法，内容是"吃";定义一个鲸类Whale继承哺乳动物，覆盖Move()方法，打印"游"，
    //覆盖Eat()方法，调用父类的Eat()方法并打印"排水";
    //定义一个蝙蝠类Bat继承哺乳动物，覆盖Move()方法，打印"飞"。
    //之后分别实例化Mamal、Whale、Bat，并调用各自的Move()和Bat()。

    class Mammal
    {
        public virtual void Move()
        {
            Console.WriteLine("跑");
        }

        public virtual void Eat()
        {
            Console.WriteLine("吃");
        }
    }

    class Whale : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("游");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("排水");
        }
    }

    class Bat : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("飞");
        }
    }

    //定义Account类，有存钱和取钱功能，并能避免余额为负；
    //定义一个RecordedAccount类，能记录每次存钱和取钱的金额，可用一个数组记录。

    class Account
    {
        public float Deposit { get; protected set; }

        public virtual void Save(float sum)
        {
            if (sum >= 0)
            {
                Deposit += sum;
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
            }
            else
            {
                Console.WriteLine("余额不足");
            }
        }
    }

    class RecordedAccount : Account
    {
        protected float[] record = new float[1024];
        protected int index;

        public override void Save(float sum)
        {
            base.Save(sum);
            DoubleRecord();
            if (sum >= 0)
            {
                record[index++] = sum;
            }
        }

        public override void Withdraw(float sum)
        {
            base.Withdraw(sum);
            DoubleRecord();
            if (Deposit - sum >= 0)
            {
                record[index++] = -sum;
            }
        }

        public void DoubleRecord()
        {
            if (index == record.Length)
            {
                float[] tempArr = new float[record.Length * 2];
                for (int i = 0; i < index; i++)
                {
                    tempArr[i] = record[i];
                }
                record = tempArr;
            }
        }

        public void ShowRecord()
        {
            for (int i = 0; i < index; i++)
            {
                Console.Write(record[i] + "\t");
            }
            Console.WriteLine();
        }
    }

    //定义多段线类PolyLine，其中有一个字段表示多个点，类型为Point数组，
    //有字段index表示有效长度，有方法Add添加点，有方法GetLength获得多段线总长度

    class PolyLine
    {
        Point[] points = new Point[8];
        protected int index;

        public PolyLine Add(Point point)
        {
            if (index == points.Length)
            {
                Point[] tempArr = new Point[points.Length * 2];
                for (int i = 0; i < index; i++)
                {
                    tempArr[i] = points[i];
                }
                points = tempArr;
            }
            points[index++] = point;
            return this;
        }

        public double Distantce(Point a, Point b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        public double GetLength()
        {
            if (index < 2)
            {
                return 0;
            }
            double length = 0;
            for (int i = 0; i < index - 1; i++)
            {
                length += Distantce(points[i], points[i + 1]);
            }
            return length;
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
