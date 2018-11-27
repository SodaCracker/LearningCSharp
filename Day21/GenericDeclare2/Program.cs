using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDeclare2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Util.Swap(ref a, ref b);
            Console.WriteLine("{0}\t{1}", a, b);

            string c = "1";
            string d = "2";
            Util.Swap(ref c, ref d);
            Console.WriteLine("{0}\t{1}", c, d);

            string x = "x";
            string y = "y";
            string z = "z";
            Util.Swap2(ref x, ref y, ref z);
        }
    }

    static class Util/*<T>*/
    {
        static Util()
        {

        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void Swap2<T>(ref T a, ref T b, ref T c)
        {
            T temp = a;
            a = b;
            b = c;
            c = temp;
        }
    }
}
