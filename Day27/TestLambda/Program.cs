using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //鸡腿实验
            //Cook("鸡腿",(string f) =>
            //{
            //    Console.WriteLine("炸{0}", f);
            //});

            Cook((string f) =>
            {
                Console.WriteLine("炸{0}", f);
            }, "鸡腿");

        }

        //static void Cook(string f, CookMethod cm)
        //{
        //    cm(f);
        //}

        static void Cook(CookMethod cm, string f)
        {
            cm(f);
        }
    }

    public delegate void CookMethod(string f);
}
