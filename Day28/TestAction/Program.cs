using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAction
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User("小明");
            u.myAction += (UserInfo userInfo) =>
            {
                Console.WriteLine("{0}说话的长度为{1}", userInfo.userName, userInfo.message.Length);
            };
        }
    }

    class UserInfo
    {
        public string userName { get; set; }
        public string message { get; set; }
    }

    class User
    {
        public string Name { get; }

        public User(string name)
        {
            Name = name;
        }

        public event Action<UserInfo> myAction;

        public void Talk(string s)
        {
            Console.WriteLine(s);
            UserInfo userInfo = new UserInfo();
            userInfo.userName = Name;
            userInfo.message = s;

            myAction(userInfo);
        }
    }
}
