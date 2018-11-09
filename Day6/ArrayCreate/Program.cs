using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            array = new int[5];
            char[] array2 = new char[5];        //创建后，元素都为默认值。

            int[] array3 = { 1, 2, 3, 4, 5 };
            double[] array4 = { 1.2, 3.4, 5.6, 7.8 };

            bool[] array5 = new bool[] { true, false, false, true };
            byte[] array6;
            array6 = new byte[] { 97, 98, 99 };

            //练习，分别创建 float, long, string 的数组，长度自定。
            float[] arr1;
            arr1 = new float[5];

            long[] arr2 = { 1, 2, 3, 4, 5 };

            string[] arr3;
            arr3 = new string[] { "1", "2", "3" };
        }
    }
}
