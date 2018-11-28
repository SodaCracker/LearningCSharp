using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHashtable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("name", "Tom");
            ht.Add("age", 20);

            int index = new Random().Next(0, ht.Count);
            IDictionaryEnumerator e = ht.GetEnumerator();
            //e.MoveNext();
            for (int i = 0; i <= index; i++)
            {
                e.MoveNext();
            }
            ht.Remove(e.Key);
        }
    }
}
