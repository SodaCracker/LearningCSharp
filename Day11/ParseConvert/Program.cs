using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(float.Parse("123.342"));

            //Parse 转换失败会抛出异常
            //Convert 转换失败会抛出异常
            //参数为 null, Parse 异常，Convert 返回 0

            bool flag = bool.Parse(Console.ReadLine());
            float num = float.Parse(Console.ReadLine());
            if (flag)
            {
                Console.WriteLine(num * 2);
            }
            else
            {
                Console.WriteLine(num);
            }

            int intNum = int.Parse(Console.ReadLine());
            char[] arrayNum = new char[intNum];
            for (int i = 0; i < arrayNum.Length; i++)
            {
                arrayNum[i] = char.Parse(Console.ReadLine());
            }
            foreach (char item in arrayNum)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
