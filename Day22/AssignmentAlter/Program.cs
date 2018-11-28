using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAlter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Human> dict = new Dictionary<string, Human>();

            while (true)
            {
                Console.WriteLine("输入操作类型：");
                string type = Console.ReadLine();

                switch (type)
                {
                    case "A":
                        {
                            Console.Write("输入姓名：");
                            string name = Console.ReadLine();
                            Console.Write("输入地址：");
                            string address = Console.ReadLine();

                            dict.Add(name, new Human(name, address));
                            break;
                        }
                    case "Q":
                        {
                            Console.WriteLine("输入姓名：");
                            string name = Console.ReadLine();
                            Console.WriteLine(dict[name]);
                            break;
                        }
                    case "D":
                        {
                            Console.WriteLine("输入姓名：");
                            string name = Console.ReadLine();
                            dict.Remove(name);
                            break;
                        }
                    case "L":
                        {
                            foreach (KeyValuePair<string, Human> item in dict)
                            {
                                Console.WriteLine(item.Value);
                            }
                            break;
                        }
                }
            }
        }
    }

    class Human
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Human(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return string.Format("Name={0}\tAddress={1}", Name, Address);
        }
    }
}
