using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountPro ap = new AccountPro();
            ap.Save(100);
            ap.Withdraw(1000);
            Console.WriteLine(ap.Deposit);
        }
    }

    class Account
    {
        public float Deposit { get; protected set; } = 100.0f;

        public void Save(float sum)
        {
            Deposit += sum;
        }

        public virtual void Withdraw(float sum)
        {
            Deposit -= sum;
        }
    }

    class AccountPro : Account
    {
        public override void Withdraw(float sum)
        {
            if (Deposit >= sum)
            {
                base.Withdraw(sum);
            }
            else
            {
                Console.WriteLine("余额不足");
            }
        }
    }

    class Unit
    {
        protected int hitPoint;

        public virtual void Heal(int n)
        {
            hitPoint += n;
        }

        public virtual void Attack(int n)
        {
            hitPoint -= n;
        }
    }

    class UnitPro : Unit
    {
        public UnitPro(int hp)
        {
            hitPoint = hp;
        }

        public override void Heal(int n)
        {
            if (hitPoint + n <= 100)
            {
                base.Heal(n);
            }
            else
            {
                hitPoint = 100;
            }
        }

        public override void Attack(int n)
        {
            if (hitPoint - n <= 0)
            {
                base.Attack(n);
            }
            else
            {
                hitPoint = 0;
            }
        }
    }

    class Container
    {
        protected string[] array = new string[1024];
        protected int index;

        public virtual void Add(string s)
        {
            array[index++] = s;
        }

        public virtual void RemoveLast()
        {
            index--;
        }
    }

    class ContrainerPro : Container
    {
        public override void Add(string s)
        {
            if (index == array.Length)
            {
                string[] tempArr = new string[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    tempArr[i] = array[i];
                }
                array = tempArr;
            }
            base.Add(s);
        }

        public override void RemoveLast()
        {
            if (index > 0)
            {
                base.RemoveLast();
            }
        }
    }
}
