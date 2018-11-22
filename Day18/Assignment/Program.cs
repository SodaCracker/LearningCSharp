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
            //创建Host对象，通过Buy购置几个宠物，再调用WalkWithPet方法。
            Host host = new Host();

            host.Buy(new Cat());
            host.Buy(new Dog());
            host.Buy(new Bird());

            for (int i = 0; i < host.PetCount; i++)
            {
                host.WalkWithPet(host.GetPet(i));
            }
        }
    }

    //定义Pet类，有Walk方法；
    //定义子类Dog，重写Walk，打印汪汪；
    //定义子类Cat，重写Walk，打印喵喵。
    //定义Host类，有字段pets为Pet[] 类型，固定初始化为1024长度，
    //有Buy(Pet p)方法可购置宠物，往数组中添加，
    //有WalkWithPet方法，逻辑为调用pets中每个有效元素宠物的Walk(如果某个宠物是鸟，就调用其Fly)。

    class Pet
    {
        public virtual void Walk()
        {

        }
    }

    class Dog : Pet
    {
        public override void Walk()
        {
            Console.WriteLine("汪汪");
        }
    }

    class Cat : Pet
    {
        public override void Walk()
        {
            Console.WriteLine("喵喵");
        }
    }

    class Bird : Pet
    {
        public void Fly()
        {
            Console.WriteLine("啾啾飞行");
        }
    }

    class Host
    {
        private Pet[] pets = new Pet[5];

        public int PetCount { get; private set; }

        public Pet GetPet(int i)
        {
            return pets[i];
        }

        public void Buy(Pet pet)
        {
            if (PetCount == pets.Length)
            {
                Pet[] tempArr = new Pet[pets.Length * 2];
                for (int i = 0; i < PetCount; i++)
                {
                    tempArr[i] = pets[i];
                }
                pets = tempArr;
            }
            pets[PetCount++] = pet;
        }

        public void WalkWithPet(Pet pet)
        {
            if (pet is Bird)
            {
                ((Bird)pet).Fly();
            }
            else
            {
                pet.Walk();
            }
        }
    }
}
