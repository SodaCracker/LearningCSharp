using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = 1;
            //for (int i = 2; i < 11; i++)
            //{
            //    result *= i;
            //}
            //Console.WriteLine(result);

            //string str = "";
            //for (char i = 'a'; i < 'z'; i++)
            //{
            //    str += i;
            //}
            //Console.WriteLine(str);

            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 10 + i / 10 % 10 == 10)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 10 == 9 || i / 10 % 10 == 9)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int count = 0;
            //for (int i = n; i > 0; i /= 10)
            //{
            //    if (i % 10 == 9)
            //        count++;
            //}
            //Console.WriteLine(count);

            //让用户输入10个数字，打印出总和，最大，最小，平均值。
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;
                if (a > max)
                    max = a;
                if (a < min)
                    min = a;
            }
            //Console.WriteLine("和： " + sum + "\t最大： " + max + "\t最小： " + min + "\t平均： " + sum / 10.0f);
            Console.WriteLine("总和：{0}，最大：{1}，最小：{2}，平均：{3}", sum, max, min, sum / 10.0f);

            
        }


    }
}
