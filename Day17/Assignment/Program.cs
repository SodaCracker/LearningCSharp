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
            while (true)
            {
                string[] s = Console.ReadLine().Split('，', ',');
                float x = float.Parse(s[0].Trim());
                float y = float.Parse(s[1].Trim());

                Player p = Player.GetPlayer();
                p.Move(x, y);

                if (PosUtil.IsTooFar(p))
                {
                    PosUtil.MoveToZero(p);
                }
            }
        }
    }

    //定义一个Player，懒汉单例模式，字段x,y表示位置，Move(float x, float y)方法进行移动；在Main方法中写一个死循环，
    //每次让用户输入移动量如: 10,15，拆分解析出需要移动的横向和纵向距离，获取Player实例并进行移动

    class Player
    {
        private static Player p;
        public float X { get; private set; } = 0;
        public float Y { get; private set; } = 0;

        private Player()
        {

        }

        public static Player GetPlayer()
        {
            if (p == null)
            {
                p = new Player();
            }
            return p;
        }

        public void Move(float horizontal, float vertical)
        {
            X += horizontal;
            Y += vertical;
        }
    }

    //定义一个PosUtil位置工具类，有方法
    //bool IsZero(Player p)返回参数中的Player是否在原点0,0
    //bool IsTooFar(Player p)返回参数中的Player是否离原点距离100以上
    //void MoveToZero(Player p)将参数中的Player移动到原点
    //在第一个练习的循环中，每次如果Player离原点100以上，就将它移动到原点

    static class PosUtil
    {
        public static bool IsZero(Player p)
        {
            if (p.X == 0 && p.Y == 0)
            {
                return true;
            }
            return false;
            //return p.X == 0 && p.Y == 0;
        }

        public static bool IsTooFar(Player p)
        {
            double distance = Math.Sqrt(p.X * p.X + p.Y * p.Y);
            if (distance > 100)
            {
                return true;
            }
            return false;
            //return Math.Sqrt(p.X * p.X + p.Y * p.Y) > 100;
        }

        public static void MoveToZero(Player p)
        {
            p.Move(-p.X, -p.Y);
        }
    }
}
