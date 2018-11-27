using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDeclare
{
    class Program
    {
        static void Main(string[] args)
        {
            Container<int> c = new Container<int>();
            c.Add(1);
            c.Add(2);
            c.Add(3);

            Console.WriteLine(c.Get(0));
        }
    }

    class Container
    {
        object[] array = new object[1024];
        int index;

        public void Add(object n)
        {
            array[index++] = n;
        }

        public object Get(int i)
        {
            return array[i];
        }
    }

    class Container<T>      //T 表示参数化类型，未知类型
    {
        T[] array = new T[1024];
        int index;

        public void Add(T n)
        {
            array[index++] = n;
        }

        public T Get(int i)
        {
            return array[i];
        }
    }
}
