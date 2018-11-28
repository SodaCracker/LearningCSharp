using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> lList = new LinkedList<int>(new int[] { 5, 8, 7, 2, 6, 9, 3, 5 });
            lList.AddFirst(86);

            //Console.WriteLine(lList.First.Value);
            //Console.WriteLine(lList.Last.Value);

            LinkedListNode<int> a = lList.Find(5);
            LinkedListNode<int> b = lList.FindLast(5);
            lList.AddBefore(a, 10);
            lList.AddAfter(b, 11);
            lList.Find(5);
            lList.Remove(2);        //第一个匹配项

            LinkedListNode<int> c = lList.Find(7);
            lList.AddAfter(c, 0);
            Console.WriteLine(c.Next.Value);

            foreach (int item in lList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
