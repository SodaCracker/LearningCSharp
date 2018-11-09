using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "abc", "def", "kkk", };
            int index = 3;      //当前 array 的有效对象数，对应到下标，其实是下一个空位的下标。
            while (true)
            {
                Console.Write("请输入操作： ");
                string type = Console.ReadLine();
                if (type == "插入")
                {
                    Console.Write("请输入字符： ");
                    string target = Console.ReadLine();
                    Console.Write("请输入位置： ");
                    int pos = int.Parse(Console.ReadLine());

                    for (int i = index - 1; i >= pos; i--)
                    {
                        array[i + 1] = array[i];
                    }
                    array[pos] = target;
                    index++;
                }
                else if (type == "删除")
                {
                    Console.Write("请输入要删除的位置： ");
                    int pos = int.Parse(Console.ReadLine());
                    for (int i = pos; i <= index - 2; i++)        //遍历到有效左边两个。
                    {
                        array[i] = array[i + 1];
                    }
                    index--;
                }
                for (int i = 0; i < index; i++)
                {
                    Console.Write(array[i] + "\t");
                }
            }
        }
    }
}
