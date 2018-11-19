using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentRef
{
    class Program
    {
        static void Main(string[] args)
        {
            //AccountPro ap = new AccountPro();
            //ap.ShowPasstip();
            //string s = Console.ReadLine();
            //string newPass = Console.ReadLine();
            //bool result = ap.AlterPasswordByPasstip(s, newPass);
            //Console.WriteLine(result ? "成功" : "失败");

            MyQueue mq = new MyQueue();
            mq.Enqueue("东");
            mq.Enqueue("南");
            mq.Enqueue("西");
            mq.Enqueue("北");

            mq.Dequeue();
            mq.Dequeue();
            mq.Dequeue();
            mq.Dequeue();

            mq.ShowAll();
        }
    }

    class Account
    {
        protected string password = "123456";

        public bool AlterPassword(string oldPass, string newPass)
        {
            if (oldPass == password)
            {
                password = newPass;
                return true;
            }
            return false;
        }
    }

    class AccountPro : Account
    {
        public string Passtip { get; protected set; } = "电话号码";
        public string PasstipAnswer { get; protected set; } = "1356666666";

        public AccountPro(string pwd, string pTip, string pAnswer)
        {
            password = pwd;
            Passtip = pTip;
            PasstipAnswer = pAnswer;
        }

        public AccountPro(string pwd) : this(pwd, "你的小学", "向日葵小学")
        {

        }

        public AccountPro() : this("123456", "你的小学", "向日葵小学")
        {

        }

        public void ShowPasstip()
        {
            Console.WriteLine(Passtip);
        }

        public bool AlterPasswordByPasstip(string myAnswer, string newPass)
        {
            if (myAnswer == PasstipAnswer)
            {
                password = newPass;
                return true;
            }
            return false;
        }
    }

    class MyContainer
    {
        protected string[] array = new string[1024];
        protected int index;
        protected int historyRemoveTimes;

        public void ShowAll()
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public string[] DoubleArray(string[] array)
        {
            string[] tempArr = new string[array.Length * 2];
            for (int i = 0; i < index; i++)
            {
                array[i] = tempArr[i];
            }
            return array = tempArr;
        }
    }

    class MyStack : MyContainer
    {
        public void Push(string s)
        {
            if (index == array.Length)
            {
                DoubleArray(array);
            }

            //for (int i = index; i > 0; i--)
            //{
            //    array[i] = array[i - 1];
            //}
            //array[0] = s;
            //index++;

            array[index++] = s;
        }

        public string Pop()
        {
            historyRemoveTimes--;
            return array[--index];
        }
    }

    class MyQueue : MyContainer
    {
        public void Enqueue(string s)
        {
            if (index == array.Length)
            {
                DoubleArray(array);
            }

            array[index++] = s;
        }

        public string Dequeue()
        {
            string temp = array[0];

            for (int i = 0; i < index - 1; i++)
            {
                array[i] = array[i + 1];
            }

            historyRemoveTimes--;
            index--;
            return temp;
        }
    }
}
