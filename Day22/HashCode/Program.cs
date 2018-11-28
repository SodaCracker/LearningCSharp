using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = new object();
            object b = new object();
            object c = b;
            string str = "";
            string str2 = "";
            int x = 1;
            int y = 2;

            Cat tom = new Cat(2, "Tom");
            Cat jerry = new Cat(2, "Tom");

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(str.GetHashCode());
            Console.WriteLine(str2.GetHashCode());
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine(y.GetHashCode());

            //Console.WriteLine(tom.GetHashCode());
            //Console.WriteLine(jerry.GetHashCode());

            Hashtable ht = new Hashtable();
            ht.Add(a, 1);
            ht.Add(b, 1);
            //ht.Add(c, 1);
        }
    }

    class Cat
    {
        int age;
        string name;
        
        public Cat(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
