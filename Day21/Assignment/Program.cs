using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<Cube> cubeList = new List<Cube>();
            for (int i = 0; i < 10; i++)
            {
                cubeList.Add(new Cube(r.Next(1,101), r.Next(1, 101), r.Next(1, 101)));
            }
            cubeList.Sort(new CubeCompare());
            foreach (Cube item in cubeList)
            {
                Console.WriteLine(item);
            }

            //PocketMoney pm = new PocketMoney();
            //pm.TotalMoney = double.Parse(Console.ReadLine());
            //pm.PeopleCount = int.Parse(Console.ReadLine());
            //pm.TryYourLuck();
            //pm.ShowHistory();

            //StringBox sb = new StringBox(new Validator());
            //while (true)
            //{
            //    string oper = Console.ReadLine();
            //    switch (oper)
            //    {
            //        case "A":
            //            string str = Console.ReadLine();
            //            sb.Add(str);
            //            break;
            //        case "D":
            //            bool result = false;
            //            while (!result)
            //            {
            //                string strIndex = Console.ReadLine();
            //                result = sb.Delete(strIndex);
            //            }
            //            break;
            //        case "Q":
            //            sb.Query();
            //            break;
            //    }
            //}

            //MyList<string> myList = new MyList<string>();
            //myList.Add("每天起床第一句");
            //myList.Add("first sentence getting up");
            //myList.Insert(0, "1");
            //myList.RemoveAt(2);
            //for (int i = 0; i < myList.Count(); i++)
            //{
            //    Console.WriteLine(myList[i]);
            //}
            //Console.WriteLine(myList.Count());
            //Console.WriteLine(myList[0]);
        }

        //在一个List中添加10个Cube长方体类的实例，其长宽高都是1-100之间的随机整数，按照体积进行升序排列，并遍历打印
        class Cube
        {
            int width;
            int height;
            int depth;

            public Cube(int w,int h,int d)
            {
                width = w;
                height =h;
                depth =d;
            }

            public int Volume()
            {
                return width * height * depth;
            }

            public override string ToString()
            {
                return string.Format("width: {0}\theight: {1}\tdepth: {2}\tvolume: {3}", width, height, depth, Volume());
            }
        }

        class CubeCompare : IComparer<Cube>
        {
            public int Compare(Cube a, Cube b)
            {
                if (a.Volume() < b.Volume())
                {
                    return -1;
                }
                else if (a.Volume() > b.Volume())
                {
                    return 1;
                }
                return 0;
            }
        }

        //随机红包程序，让用户输入总额和人数，每个人的基准金额为剩余金额/剩余人数，
        //但前 n-1 个人的金额要随机上下浮动50%，最后一个人获得剩下的所有金额，
        //用 List 完成
        class PocketMoney
        {
            double totalMoney;
            int peopleCount;

            List<double> moneyList = new List<double>();
            Random r = new Random();

            public double TotalMoney { set { totalMoney = value; } }
            public int PeopleCount { set { peopleCount = value; } }

            public void TryYourLuck()
            {
                double restMoney = totalMoney;

                for (int i = 0; i < peopleCount - 1; i++)
                {
                    double baseMoney = restMoney / (peopleCount - i);
                    int min = (int)(Math.Round(baseMoney * 0.5f, 2) * 100);
                    int max = (int)(Math.Round(baseMoney * 1.5f, 2) * 100);
                    double certainMoney = r.Next(min, max) * 1.0 / 100;
                    moneyList.Add(certainMoney);
                    restMoney -= certainMoney;
                }
                moneyList.Add(Math.Round(restMoney, 2));
            }

            public void ShowHistory()
            {
                foreach (double item in moneyList)
                {
                    Console.WriteLine(item);
                }
            }
        }

        //写一个程序，让用户录入、删除、查询字符串
        //让用户不停输入，每次先让用户输入一个字符串表示操作类型
        //如果用户输入A，表示添加，就让其再输入一个字符串并添加到List的最后；
        //如果用户输入D，表示删除，就打印List的有效下标范围并让其再输入一个数字表示下标，
        //程序将List下标位置的元素删除
        //(如果用户输入的不是数字或数字不是有效下标范围，就提示并再让用户输入下标，一直到其输入有效下标数字为止；
        //如果List长度为0，就打印长度为0，且不让用户输入数字)
        //如果用户输入Q，表示查询，就显示出List中的所有字符串
        class StringBox
        {
            Validator validator;
            List<string> list = new List<string>();

            public StringBox(Validator validator)
            {
                this.validator = validator;
            }

            public void Add(string s)
            {
                list.Add(s);
            }

            public bool Delete(string strIndex)
            {
                string info;
                int index = validator.GetNumFromString(strIndex, list.Count, out info);
                Console.WriteLine(info);

                if (index >= 0)
                {
                    list.RemoveAt(index);
                }
                return index >= 0;
            }

            public void Query()
            {
                foreach (string item in list)
                {
                    Console.WriteLine(item + "\t");
                }
            }
        }

        class Validator
        {
            //不是数字，或不在范围内返回 -1
            //info 是返回的信息
            public int GetNumFromString(string str, int length, out string info)
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
                    info = string.Format("非数字");
                }
                return index;
            }
        }

        //定义一个MyList<T>，和List<T> 一样
        //有:
        //构造器    //Add    //Count    //RemoveAt    //Insert    //索引器list[i]
        class MyList<T>
        {
            T[] array = new T[1024];
            int index;

            public MyList()
            {

            }

            public T this[int i]
            {
                get
                {
                    return array[i];
                }
                set
                {
                    array[i] = value;
                }
            }

            private void DoubleArray()
            {
                T[] tempArr = new T[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    tempArr[i] = array[i];
                }
                array = tempArr;
            }

            public void Add(T content)
            {
                if (index == array.Length)
                {
                    DoubleArray();
                }
                array[index++] = content;
            }

            public int Count()
            {
                return index;
            }

            public void RemoveAt(int index)
            {
                for (int i = index; i < this.index - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                this.index--;
            }

            public void Insert(int index, T content)
            {
                for (int i = this.index; i > index; i--)
                {
                    array[i] = array[i - 1];
                }
                array[index] = content;
                this.index++;
            }
        }
    }
}
