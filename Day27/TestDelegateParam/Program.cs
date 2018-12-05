using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegateParam
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook c = Fry;
            Food f = new Food();
            f.Name = "鸡腿";

            MakeFood(c, f);
        }

        static void MakeFood(Cook c, Food f)
        {
            c(f);
        }

        static void Fry(Food f)
        {
            Console.WriteLine("炸{0}", f.Name);
        }

        static void Boil(Food f)
        {
            Console.WriteLine("煮{0}", f.Name);
        }
    }

    public delegate void Cook(Food f);

    public class Food
    {
        public string Name { set; get; }
    }
}
