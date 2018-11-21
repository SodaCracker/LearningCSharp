using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            new Cat();
            Console.WriteLine();
            new Cat();
        }
    }

    class Cat : Animal
    {
        int c = 2;
        static int d = 22;

        static Cat()
        {
            Console.WriteLine("Cat~");
        }

        public Cat()
        {
            Console.WriteLine("Cat");
        }
    }

    class Animal
    {
        int i = 1;
        static int b = 11;

        static Animal()
        {
            Console.WriteLine("Animal~");
        }

        public Animal()
        {
            Console.WriteLine("Animal");
        }
    }
}
