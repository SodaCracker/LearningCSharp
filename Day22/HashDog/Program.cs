using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashDog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(3, "Snoopy", 1);
            Dog dog2 = new Dog(3, "Snoopy", 1);

            Hashtable ht = new Hashtable();
            ht.Add(dog1, 1);
            ht.Add(dog2, 1);
        }
    }

    class Dog
    {
        int age;
        string name;
        int id;

        public Dog(int age, string name, int id)
        {
            this.age = age;
            this.name = name;
            this.id = id;
        }

        public override int GetHashCode()
        {
            int num1 = 17;
            int num2 = 23;
            num1 = num1 * age + num2;
            num1 = num1 * name.GetHashCode() + num2;
            num1 = num1 * id + num2;
            return num1;
        }

        public override bool Equals(object obj)
        {
            Dog d = (Dog)obj;
            return age == d.age && name == d.name && id == d.id;
        }
    }
}
