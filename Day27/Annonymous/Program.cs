using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cook(delegate(string food), "鸡腿"){

            //}
            Cook(delegate (string food)
            {
                Console.WriteLine("炸{0}", food);
            }, "鸡腿");
        }

        static void Cook(CookMethod cm, string food)
        {
            cm(food);
        }
    }

    public delegate void CookMethod(string food);
}
