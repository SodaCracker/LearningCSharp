using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDeclare3
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject go = new GameObject();
            go.Add(new Rigidbody());
            go.Add(new MeshRenderer());
            go.Add(new Collider());
            Console.WriteLine(go.GetComponent<MeshRenderer>());
            //Console.WriteLine(go.GetComponent<int>());
        }
    }

    class GameObject
    {
        Component[] components = new Component[32];
        int index;

        public void Add(Component c)
        {
            components[index++] = c;
        }

        public Component GetComponent<T>() where T : Component
        {
            for (int i = 0; i < index; i++)
            {
                if (components[i] is T)
                {
                    return components[i];
                }
            }
            return null;
        }
    }

    class Component
    {

    }

    class Rigidbody : Component
    {

    }

    class Collider : Component
    {

    }

    class MeshRenderer : Component
    {

    }

    interface test<T>
    {

    }
}
