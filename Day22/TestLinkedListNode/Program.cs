using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinkedListNode
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<char> linkedList = new LinkedList<char>(new char[] { '5', '8', '7', '0', '6', '9', '3', '5', });
            LinkedListNode<char> firstNode = linkedList.First;
            LinkedListNode<char> lastNode = linkedList.Last;

            LinkedListNode<char> current = firstNode;
            current = lastNode;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                //current = current.Next;
                current = current.Previous;
            }

            //自己定义一个MyNode，定义一个MyLinkedList
        }
    }
}
