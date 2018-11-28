using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> myDictionary = new Dictionary<char, int>();
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (myDictionary.ContainsKey(s[i]))
                {
                    myDictionary[s[i]]++;
                }
                else
                {
                    //myDictionary.Add(s[i], 1);
                    myDictionary[s[i]] = 1;
                }
            }

            foreach (KeyValuePair<char, int> item in myDictionary)
            {
                Console.WriteLine("{0}\t{1}", item.Key, item.Value);
            }
        }
    }
}
