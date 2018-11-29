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
            //1.
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            int times = stack.Count;
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            //2.
            Console.Write("您的年龄：");
            int age = int.Parse(Console.ReadLine());
            try
            {
                if (CyberNetAccess(age))
                {
                    Console.WriteLine("可以进入");
                }
            }
            catch (UnderAgeException e)
            {
                Console.WriteLine(e.Message);
            }

            //3.
            Account a = new Account("Cy", "192.168.1.1");
            Account b = new Account("cy", "192.168.1.2");

            Console.Write("输入 id：");
            string id = Console.ReadLine();
            Console.Write("输入密码：");
            string password = Console.ReadLine();
            try
            {
                a.Login(id, password);
            }
            catch (WrongPasswordException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static bool CyberNetAccess(int age)
        {
            if (age < 18)
            {
                throw new UnderAgeException(18, "未成年人禁止入内");
            }
            return true;
        }

    }

    //用两个队列实现一个栈
    class MyStack<T>
    {
        Queue<T> q1 = new Queue<T>();
        Queue<T> q2 = new Queue<T>();

        public int Count { get { return q1.Count; } }

        public void Push(T content)
        {
            q1.Enqueue(content);
        }

        public T Pop()
        {
            Move(q1, q2, q1.Count - 1);
            T target = q1.Dequeue();
            Move(q2, q1, q2.Count);
            return target;
        }

        public void Move(Queue<T> from, Queue<T> to, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                to.Enqueue(from.Dequeue());
            }
        }
    }

    //自定义年龄过低异常
    class UnderAgeException : Exception
    {
        int age;

        public UnderAgeException(int age, string message) : base(message)
        {
            this.age = age;
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", age, Message);
        }
    }

    class Account
    {
        static Dictionary<string, string> accounts = new Dictionary<string, string>();

        public Account(string id, string password)
        {
            accounts.Add(id, password);
        }

        public bool Login(string id, string password)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("查无此人");
                return false;
            }
            else
            {
                if (password != accounts[id])
                {
                    throw new WrongPasswordException("密码有错");
                }
            }
            Console.WriteLine("登录成功");
            return true;
        }
    }

    //自定异常，用户登录，输入密码错误时 抛出登陆异常
    class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message) : base(message)
        {

        }

        public override string ToString()
        {
            return string.Format(Message);
        }
    }
}
