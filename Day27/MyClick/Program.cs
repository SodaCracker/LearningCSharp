using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClick
{
    public delegate void OnClick();

    class Program
    {
        static void Main(string[] args)
        {
            Button b = new Button();

            //b.MyClick += () =>
            //{
            //    Console.WriteLine("按下");
            //};

            //b.MyClick += () =>
            //{
            //    Console.WriteLine("Morning");
            //};

            b.AddListener(() => { Console.WriteLine("监听"); });
            b.AddListener(() => { Console.WriteLine("加个监听"); });

            while (true)
            {
                Console.ReadKey();
                b.Trigger();
            }
        }
    }

    class Button
    {
        private OnClick myClick;

        public void AddListener(OnClick newClick)
        {
            myClick += newClick;
        }

        public void DeleteListener(OnClick notNeeded)
        {
            myClick -= notNeeded;
        }

        public void Trigger()
        {
            myClick();
        }
    }
}
