using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<char> myLinkedList = new MyLinkedList<char>();
            myLinkedList.AddFirst('a');
            myLinkedList.AddFirst('b');
            myLinkedList.AddFirst('c');

            MyNode<char> a = myLinkedList.First;
            MyNode<char> current = a;

            while (a != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
    class MyLinkedList<T>
    {
        public MyNode<T> First { get; set; }
        public MyNode<T> Last { get; set; }

        public void AddFirst(T value)
        {
            if (First == null)
            {
                First = new MyNode<T>();
                First.Value = value;
            }
            else
            {
                MyNode<T> newNode = new MyNode<T>();
                newNode.Next = First;
                First = newNode;
                newNode.Value = value;
            }
        }

        public void AddLast(T value)
        {
            if (Last == null)
            {
                Last = new MyNode<T>();
            }
            else
            {
                MyNode<T> newNode = new MyNode<T>();
                newNode.Previous = Last;
                Last = newNode;
                newNode.Value = value;
            }
        }

        public void AddBefore(MyNode<T> mn, T value)
        {
            MyNode<T> newNode = new MyNode<T>();
            newNode.Previous = mn.Previous;
            newNode.Next = mn;
            mn.Previous = newNode;
        }

        public void AddAfter(MyNode<T> mn, T value)
        {
            MyNode<T> newNode = new MyNode<T>();
            newNode.Previous = mn;
            newNode.Next = mn.Next;
            mn.Next = newNode;
        }

        public MyNode<T> Find(T content)
        {
            MyNode<T> current = First;

            while (current != null)
            {
                if (current.Value.Equals(content))
                {
                    current = current.Next;
                }
            }
            return current;
        }

        public void Remove(T content)
        {
            MyNode<T> delNode = new MyNode<T>();
            delNode = Find(content);

            if (delNode != null)
            {
                delNode.Previous.Next = delNode.Next;
                delNode.Next.Previous = delNode.Previous;
            }
        }
    }

    class MyNode<T>
    {
        public MyNode<T> Previous { get; set; }
        public T Value { get; set; }
        public MyNode<T> Next { get; set; }
    }
}
