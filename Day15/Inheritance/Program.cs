using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.Run();
            Console.WriteLine(c.Age);
            c.CatchMice();
            Utility u = new Utility();
            u.TestPublic();
            //TestInternal 也不行
        }
    }

    class Animals
    {
        public int Age { get; set; }
        public string Color { set; get; }

        public void Run()
        {
            Console.WriteLine("Run");
        }
    }

    class Cat : Animals
    {
        public int MouseCount { get; private set; }

        public void CatchMice(int n = 1)
        {
            Console.WriteLine("Catch {0} Mice", n);
            MouseCount += n;
        }

        public bool IsGoodCat()
        {
            if (MouseCount >= 5)
            {
                return true;
            }
            return false;
        }
    }

    class Container
    {
        protected string[] array = new string[1024];        //本类和子类，internal 同一程序集
        protected int index;                                //protected internal 本类、子类、同一程序集（生成的程序）

        public void ShowAll()
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

    class SubContainer : Container
    {
        public void AddLast(string last)
        {
            if (index == array.Length)
            {
                string[] tempArr = new string[array.Length * 2];
                for (int i = 0; i < index; i++)
                {
                    tempArr[i] = array[i];
                }
                array = tempArr;
            }
            array[index++] = last;
        }

        public void RemoveLast()
        {
            array[index--] = null;
        }
    }
}
