using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            char[] arr = { 'a', 'b', 'c', 'd', 'e', };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'e')
                {
                    Console.WriteLine(i);
                    break;      //只关心从左往右的第一个结果。
                }
            }
            */

            //Find
            int num = int.Parse(Console.ReadLine());

            int[] numbers = { 1, 2, 6, 8, 12, 17, 19, 20, 25, 30, 31, 34, 36,
                39, 45, 69, 70, 78, 83, 88, 89, 98 };
            int op = 0;     //下限的标
            int ed = numbers.Length - 1;        //上限的标
            while (op <= ed)
            {
                int mid = (op + ed) / 2;        //中间的标
                if (num == numbers[mid])
                {
                    Console.WriteLine("第 {0} 位为 {1}。", mid, num);
                    break;
                }
                else if (num < numbers[mid])
                {
                    ed = mid - 1;
                }
                else
                {
                    op = mid + 1;
                }
                if (op == ed)
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}
