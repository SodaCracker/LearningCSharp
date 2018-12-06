using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput userInput = new UserInput();
            userInput.myHandler += (object o, string str) =>
            {
                Console.WriteLine("输入的字符串长度为 {0}", str.Length);
            };

            userInput.myHandler += (object o, string str) =>
            {
                int sum = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                    {
                        sum++;
                    }
                }
                Console.WriteLine("输入字数字有 {0} 个",sum);
            };

            User user = new User();
            user.myHandler += (object o, string str) =>
            {
                Console.WriteLine("用户说话长度为 {0}", str.Length);
            };

            userInput.Work();
        }
    }

    class UserInput
    {
        public event EventHandler<string> myHandler;

        public void Work()
        {
            while (true)
            {
                string str = Console.ReadLine();
                myHandler(this, str);
            }
        }
    }

    class User
    {
        public event EventHandler<string> myHandler;

        public void Talk(string str)
        {
            myHandler(this, str);
        }
    }
}
