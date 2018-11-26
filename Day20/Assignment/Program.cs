using System;
using System.Collections;
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
            //创建一个ArrayList ，往里添加"c#"、"c++"、"CLR",再添加1到20的整数，
            //删除下标为3的元素，再在下标10的位置添加999这个整数，
            //最后将其中的所有元素从后到前打印出来。

            //ArrayList al = new ArrayList() { "c#", "c++", "CLR" };
            //for (int i = 1; i <= 20; i++)
            //{
            //    al.Add(i);
            //}
            //al.RemoveAt(3);
            //al.Insert(10, 999);

            //for (int i = al.Count - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(al[i]);
            //}

            //让用户输入一个整数，通过自除2的形式计算二进制，并利用ArrayList正序输出二进制的各个位

            //ArrayList al2 = new ArrayList();
            //int a = int.Parse(Console.ReadLine());
            //for (; a > 0; a /= 2)
            //{
            //    al2.Add(a % 2);
            //}

            //for (int i = al2.Count - 1; i >= 0; i--)
            //{
            //    Console.Write(al2[i]);
            //}
            //Console.WriteLine();

            //随机点名程序，用户每敲一次回车，就随机打印一个姓名

            //ArrayList al3 = new ArrayList() { "A", "B", "C", "D", "E" };
            //Random r = new Random();
            //while (true)
            //{
            //    Console.ReadLine();
            //    Console.WriteLine(al3[r.Next(0, al3.Count)]);
            //}

            //在一个ArrayList中添加10个Cube长方体类的实例，其长宽高都是1-100之间的随机整数，按照体积进行升序排列，并遍历打印
            //ArrayList al4 = new ArrayList();
            //Random r2 = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    al4.Add(new Cube(r2.Next(1, 101), r2.Next(1, 101), r2.Next(1, 101)));
            //}
            //al4.Sort(new CubeCompare());

            //foreach (Cube item in al4)
            //{
            //    Console.WriteLine(item);
            //}

            //PocketMoney pm = new PocketMoney();
            //Console.Write("输入金额：");
            //pm.TotalMoney = double.Parse(Console.ReadLine());
            //Console.Write("输入人数：");
            //pm.PeopleCount = int.Parse(Console.ReadLine());

            //pm.TryYourLuck();
            //pm.GetResult();

            MyApp.Run();

        }
    }

    class CubeCompare : IComparer
    {
        public int Compare(object a, object b)
        {
            Cube c1 = (Cube)a;
            Cube c2 = (Cube)b;
            //int volume1 = c1.Width * c1.Height * c1.Depth;
            //int volume2 = c2.Width * c2.Height * c2.Depth;

            if (c1.Volume() < c2.Volume())
            {
                return -1;
            }
            else if (c1.Volume() > c2.Volume())
            {
                return 1;
            }
            return 0;
        }
    }

    class Cube
    {
        int width;                    //private readonly float width;
        int height;
        int depth;

        public int Width { get { return width; } }
        public int Height { get { return height; } }
        public int Depth { get { return depth; } }

        public Cube(int width, int height, int depth)
        {
            this.width = width;
            this.height = height;
            this.depth = height;
        }

        public int Volume()
        {
            return width * height * depth;
        }

        public override string ToString()
        {
            return string.Format("width: {0}, height: {1}, depth: {2}, volume: {3}", width, height, depth, width * height * depth);
        }

    }

    class PocketMoney
    {
        //随机红包程序，让用户输入总额和人数，每个人的基准金额为剩余金额/剩余人数，但前n-1个人的金额要随机上下浮动50%，最后一个人获得剩下的所有金额

        double totalMoney;
        int peopleCount;
        ArrayList al = new ArrayList();
        Random r = new Random();

        public double TotalMoney { set { totalMoney = value; } }
        public int PeopleCount { set { peopleCount = value; } }

        public void TryYourLuck()
        {
            double money = totalMoney;
            for (int i = 0; i < peopleCount - 1; i++)
            {
                double baseMoney = money / (peopleCount - i);
                int min = (int)(Math.Round(baseMoney * 0.5f, 2) * 100);
                int max = (int)(Math.Round(baseMoney * 1.5f, 2) * 100);
                double certainMoney = r.Next(min, max) * 1.0 / 100;
                al.Add(certainMoney);
                money -= certainMoney;
            }
            al.Add(Math.Round(money, 2));
            //return al;
        }

        public void GetResult()
        {
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine("第{0}位：{1} 元", i + 1, al[i]);
            }
        }
    }

    //写一个程序，让用户录入、删除、查询字符串

    static class MyApp
    {
        private static MyLogic ml;

        static public void Run()
        {
            while (true)
            {
                //让用户不停输入，每次先让用户输入一个字符串表示操作类型
                Console.WriteLine("请输入操作类型：A/D/Q");
                string s = Console.ReadLine();
                if (s == "A")
                {
                    ml = new Add();
                }
                else if (s == "D")
                {
                    ml = new Delete();
                }
                else if (s == "Q")
                {
                    ml = new Query();
                }
                else
                {
                    continue;
                }
                ml.DoLogic();
            }
        }
    }

    abstract class MyLogic
    {
        protected static ArrayList al = new ArrayList();

        public static ArrayList Al
        {
            set
            {
                if (al == null)
                {
                    al = new ArrayList();
                }
            }
        }

        public virtual void DoLogic()
        {

        }
    }

    //如果用户输入A，表示添加，就让其再输入一个字符串并添加到ArrayList的最后；
    class Add : MyLogic
    {
        public override void DoLogic()
        {
            Console.Write("加入 ArrayList：");
            string s = Console.ReadLine();
            al.Add(s);
        }
    }

    //如果用户输入D，表示删除，就打印ArrayList的有效下标范围并让其再输入一个数字表示下标，
    //程序将ArrayList下标位置的元素删除(如果用户输入的不是数字或数字不是有效下标范围，就提示并再让用户输入下标，一直到其输入有效下标数字为止；
    //如果ArrayList长度为0，就打印长度为0，且不让用户输入数字)
    class Delete : MyLogic
    {
        public override void DoLogic()
        {
            if (al.Count == 0)
            {
                Console.WriteLine("长度为零");
            }
            else
            {
                int x;
                Console.WriteLine("现在有效下标范围:0 ~ {0}", al.Count - 1);
                do
                {
                    Console.Write("输入要删除的元素的下标：");
                    x = int.Parse(Console.ReadLine());
                } while (x < 0 || x >= al.Count);
                al.RemoveAt(x);
            }
        }
    }

    //返回值：str 转为的数字下标，如果 str 不是数字，返回 -1，如果 str 不在 0~n-1 范围，也返回 -1
    class Validator
    {
        public int GetNumForString(string str, int length, out string info)
        {
            int index = -1;
            bool success = int.TryParse(str, out index);
            if (success)
            {
                if (index < 0 || index >= length)
                {
                    info = string.Format("下标不在有效范围：0~{0}", length - 1);
                    success = false;
                    index = -1;
                }
                else
                {
                    info = string.Format("删除成功");
                }
            }
            else
            {
                info = string.Format("请输入整数");
                index = -1;
            }
            return index;
        }
    }

    //如果用户输入Q，表示查询，就显示出ArrayList中的所有字符串
    class Query : MyLogic
    {
        public override void DoLogic()
        {
            foreach (object item in al)
            {
                Console.WriteLine((string)item);
            }
        }
    }
}
