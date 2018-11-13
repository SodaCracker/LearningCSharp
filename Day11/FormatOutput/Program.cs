using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //string month = Console.ReadLine();
            //string day = Console.ReadLine();
            //string weather = Console.ReadLine();
            //string str = String.Format("今天是{0}月{1}日，天气{2}。", month, day, weather);
            //Console.WriteLine(str);

            Random r = new Random();
            string str = new string(new char[] { 'a', 'b', 'c' }, 1, 2);
            //Console.WriteLine(str);

            string str1 = Console.ReadLine();
            char[] arr = str1.ToArray();

            //for (int i = 0; i < arr.Length / 2; i++)
            //{
            //    char temp = arr[i];
            //    arr[i] = arr[arr.Length - 1 -i];
            //    arr[arr.Length - 1 - i] = temp;
            //}
            //string str2 = new string(arr);
            //Console.WriteLine(str2);

            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = 0; j < arr.Length - 1 - i; j++)
            //    {
            //        if (arr[j] < arr[j + 1])
            //        {
            //            char temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine(new string(arr));

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 'a' && arr[i] <= 'z')
                {
                    arr[i] -= (char)('a' - 'A');
                }
                else if (arr[i] >= 'A' && arr[i] <= 'Z')
                {
                    arr[i] += (char)('a' - 'A');
                }
            }
            Console.WriteLine(new string(arr));
        }
    }
}
