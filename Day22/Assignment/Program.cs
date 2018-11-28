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
            //1. "name:Tom,age:20!name:Jerry,age:21"将此字符串拆分,将每个人的信息以键值对的形式放入一个个Dictionary对象，
            //再将一个个Dictionary对象放入List,最后遍历打印

            string[] str = "name:Tom,age:20!name:Jerry,age:21".Split('!');
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();

            for (int i = 0; i < str.Length; i++)
            {
                string[] tempStr = str[i].Split(',');
                Dictionary<string, object> myDict = new Dictionary<string, object>();

                for (int j = 0; j < tempStr.Length; j++)
                {
                    string[] tempStr2 = tempStr[j].Split(':');
                    myDict.Add(tempStr2[0], tempStr2[1]);
                }

                list.Add(myDict);
            }

            foreach (Dictionary<string, object> item in list)
            {
                foreach (KeyValuePair<string, object> subItem in item)
                {
                    Console.WriteLine(subItem.Key + "\t" + subItem.Value);
                }
            }

            //2. 创建一个Dictionary

            LinkedList<Dictionary<string, string>> myList = new LinkedList<Dictionary<string, string>>();

            while (true)
            {
                //循环获取用户输入字符串，
                string s = Console.ReadLine();
                switch (s)
                {

                    //如果是A表示添加，就再让用户输入姓名和地址，分别作为键和值存入Dictionary,并把这个Dictionary对象存入到链表中
                    case "A":
                        {
                            Dictionary<string, string> myDict = new Dictionary<string, string>();
                            Console.Write("输入姓名：");
                            string name = Console.ReadLine();
                            myDict.Add("name", name);

                            Console.Write("输入地址：");
                            string address = Console.ReadLine();
                            myDict.Add("address", address);

                            myList.AddLast(myDict);
                            break;
                        }

                    //如果是Q表示查询，就让用户输入姓名，用户输入后打印出相应的地址
                    case "Q":
                        {
                            Dictionary<string, string> myDict = new Dictionary<string, string>();
                            Console.Write("输入姓名：");
                            string name = Console.ReadLine();

                            LinkedListNode<Dictionary<string, string>> current = myList.First;

                            //while (current != null)
                            //{
                            //    if (current.Value["name"] == name)
                            //    {
                            //        Console.WriteLine(current.Value["address"]);
                            //        break;
                            //    }
                            //    current = current.Next;
                            //}

                            //if (current == null)
                            //{
                            //    Console.WriteLine("查无此人");
                            //}

                            foreach (Dictionary<string, string> item in myList)
                            {
                                if (item["name"] == name)
                                {
                                    Console.WriteLine(item["address"]);
                                }
                            }

                            break;
                        }

                    //如果是D表示删除，让用户输入姓名，用户输入后删除对应的键值对，并打印是否删除成功
                    case "D":
                        {
                            Console.Write("输入姓名：");
                            string name = Console.ReadLine();

                            LinkedListNode<Dictionary<string, string>> current = myList.First;

                            while (current != null)
                            {
                                if (current.Value["name"] == name)
                                {
                                    myList.Remove(current);
                                    Console.WriteLine("删除成功");
                                    break;
                                }
                                current = current.Next;
                            }

                            if (current == null)
                            {
                                Console.WriteLine("查无此人");
                            }
                            break;
                        }

                    //如果是L表示列出全部，直接打印出所有的键值对
                    case "L":
                        {
                            //foreach (Dictionary<string, string> item in myList)
                            //{
                            //    foreach (KeyValuePair<string, string> subItem in item)
                            //    {
                            //        Console.WriteLine(subItem.Key + "\t" + subItem.Value);
                            //    }
                            //}

                            foreach (Dictionary<string, string> item in myList)
                            {
                                Console.WriteLine("name={0}\taddress={1}", item["name"], item["address"]);
                            }

                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
