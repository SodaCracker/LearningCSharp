using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<string> myQueue = new Queue<string>();
            //myQueue.Enqueue("Pop");
            //myQueue.Enqueue("6");
            //myQueue.Enqueue("Squash");
            //myQueue.Enqueue("Uh Uh");
            //myQueue.Enqueue("Cicero");
            //myQueue.Enqueue("Lipschitz!");

            //while (myQueue.Count > 0)
            //{
            //    Console.WriteLine(myQueue.Dequeue());
            //}

            MyQueue<int> mq = new MyQueue<int>();
            mq.Enqueue(1);
            mq.Enqueue(2);
            mq.Enqueue(3);
            mq.Enqueue(4);
            mq.Enqueue(5);

            Console.WriteLine(mq.Dequeue());
            Console.WriteLine(mq.Dequeue());
            Console.WriteLine(mq.Dequeue());
            Console.WriteLine(mq.Dequeue());
            Console.WriteLine(mq.Dequeue());

            //for (int i = 0; i < mq.Count; i++)
            //{
            //    Console.WriteLine(mq.Dequeue());
            //}
        }

    }

    //用两个栈实现一个队列
    class MyQueue<T>
    {
        Stack<T> stack1 = new Stack<T>();
        Stack<T> stack2 = new Stack<T>();

        public int Count { get { return stack1.Count; } }

        public void Enqueue(T content)
        {
            stack1.Push(content);
        }

        public T Dequeue()
        {
            int moveTime = stack1.Count - 1;
            for (int i = 0; i < moveTime; i++)
            {
                stack2.Push(stack1.Pop());
            }
            T result = stack1.Pop();
            moveTime = stack2.Count;
            for (int i = 0; i < moveTime; i++)
            {
                stack1.Push(stack2.Pop());
            }
            return result;
        }
    }
}
