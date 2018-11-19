using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Utility
    {
        private void TestPrivate()
        {
            Console.WriteLine("privite");
        }

        internal void TestInternal()
        {
            Console.WriteLine("internal");
        }

        protected void TestProtected()
        {
            Console.WriteLine("protected");
        }

        public void TestPublic()
        {
            Console.WriteLine("public");
        }
    }
}
