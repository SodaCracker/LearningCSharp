using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton s1 = Singleton.GetInstance();
            //Singleton s2 = Singleton.GetInstance();
            //Console.WriteLine(s1 == s2);
            Singleton.Test();
            //Console.WriteLine(Singleton.VERSION);

            //LazySingleton ls1 = LazySingleton.GetInstance();
            //LazySingleton ls2 = LazySingleton.GetInstance();
            LazySingleton.Test();
        }
    }

    class Singleton
    {
        public const int VERSION = 1;
        private static Singleton s = new Singleton();

        private Singleton()
        {
            Console.WriteLine("create private singleton");
            Console.WriteLine();
        }

        public static Singleton GetInstance()
        {
            return s;
        }

        public static void Test()
        {
            Console.WriteLine("Test");
        }
    }

    class LazySingleton
    {
        private static LazySingleton s;

        private LazySingleton()
        {
            Console.WriteLine("create private lazy singleton");
            Console.WriteLine();
        }

        public static LazySingleton GetInstance()
        {
            if (s == null)
            {
                s = new LazySingleton();
            }
            return s;
        }

        public static void Test()
        {
            Console.WriteLine("Test");
        }
    }
}
