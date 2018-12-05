using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEvent
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

            //b.AddListener(() => { Console.WriteLine("监听"); });
            OnClick newClick = () => { Console.WriteLine("加个监听"); };
            //b.AddListener(newClick);
            //b.DeleteListener(newClick);
            b.eventClick += newClick;

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
        public event OnClick eventClick;

        //public void AddListener(OnClick newClick)
        //{
        //    myClick += newClick;
        //}

        //public void DeleteListener(OnClick notNeeded)
        //{
        //    myClick -= notNeeded;
        //}

        public void Trigger()
        {
            //myClick();
            eventClick();
        }
    }
}
