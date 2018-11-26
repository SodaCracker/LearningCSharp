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
            Ui ui = new Ui();
            ui.MyLogic = new Plus();
            //Minus minus = new Minus();
            //Multiple multiple = new Multiple();
            //Divide divide = new Divide();

            ui.Run();
            ui.Run();
            ui.Run();
            ui.Run();
        }
    }

    interface Logic
    {
        int Cal(int a, int b);
    }

    class Ui
    {
        private Logic myLogic;
        public Logic MyLogic { set { myLogic = value; } }

        public void Run()
        {
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "exit")
                {
                    break;
                }

                string[] s = text.Split(',', '，');
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);

                Console.WriteLine(myLogic.Cal(a, b));
            }
        }
    }

    class Plus : Logic
    {
        public int Cal(int a, int b)
        {
            return a + b;
        }
    }

    class Minus : Logic
    {
        public int Cal(int a, int b)
        {
            return a - b;
        }
    }

    class Multiple : Logic
    {
        public int Cal(int a, int b)
        {
            return a * b;
        }
    }

    class Divide : Logic
    {
        public int Cal(int a, int b)
        {
            return a / b;
        }
    }
}
