using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[2][];
            array[0] = new int[] { 1, 2, 3 };
            array[1] = new int[] { 5, 6 };

            int[][] array2 = new int[3][];
            //Shallow Copy
            //Array.Copy(array, array2, 2);       //array 和 array2 确实是两个不同的数组

            //Deep Copy
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, array);
            ms.Seek(0, SeekOrigin.Begin);
            array2 = (int[][])bf.Deserialize(ms);
            array[0][0] = 99;
        }
    }
}
