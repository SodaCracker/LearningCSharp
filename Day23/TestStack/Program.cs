using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Pop");
            myStack.Push("6");
            myStack.Push("Squash");
            myStack.Push("Uh Uh");
            myStack.Push("Cicero");
            myStack.Push("Lipschitz!");

            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }
        }
    }
}
