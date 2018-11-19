using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {

    }

    //1、定义一个类不但能修改密码，也能通过构造器初始化密码及密码提示问题，也能通过输入提示问题重置密码，重用以下代码
    class Account
    {
        protected string password;
        protected string question;
        protected string answer;

        public Account(string pw, string q, string a)
        {
            password = pw;
            question = q;
            answer = a;
        }

        public Account(string pw) : this(pw, "", "")
        {

        }

        public Account() : this("123456", "", "")
        {

        }

        public void Reset(string q)
        {
            if (q == question && question.Length > 0)
            {
                Console.WriteLine(q);
            }
            else
            {
                Console.WriteLine("没这个问题");
                return;
            }
            string a = Console.ReadLine();
            if (a == answer && answer.Length > 0)
            {
                Console.Write("输入新密码：");
                string pw1 = Console.ReadLine();
                Console.Write("再次输入新密码：");
                string pw2 = Console.ReadLine();
                if (pw1 == pw2)
                {
                    password = pw1;
                }
                else
                {
                    Console.WriteLine("两次输入不一致");
                    return;
                }
            }
        }

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

    //2、定义MyStack类，有Push(string s)方法压入字符串，有string Pop()方法弹出其中最后存入字符串，先入后出
    //定义MyQueue类，有Enqueue(string s)方法在尾部存入字符串，有string Dequeue()方法在头部取出字符串，先入先出
    class MyStack
    {
        protected string[] array = new string[8192];
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

        public void Push(string s)
        {
            if (index == array.Length)
            {
                DoubleArray(array);
            }

            for (int i = index; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = s;
            index++;
        }

        public string Pop()
        {
            return array[--index];
        }

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

            index--;
            return temp;
        }
    }
}
