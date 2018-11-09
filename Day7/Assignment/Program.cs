using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. 让用户输入一个数，打印其正序二进制；可利用数组，正序放入，倒序取出。
            //int num = int.Parse(Console.ReadLine());
            //byte[] bin_nums = new byte[32];
            //int index = 0;
            //for (int i = 0; num > 0; num /= 2, i++)
            //{
            //    bin_nums[i] = (byte)(num % 2);
            //    index++;
            //}
            //for (int i = index - 1; index > 0; i--, index--)
            //{
            //    Console.Write(bin_nums[i]);
            //}


            //2. 给一个字符串数组进行冒泡排序，规则是：短的在前，长的在后; 字符串长度获取方式:str.Length
            //string[] str = { "ab", "xy", "zzz", "678", "9988", "23456", "jjjjjdd" };
            //for (int i = 0; i < str.Length; i++)
            //{
            //    for (int j = 0; j < str.Length - i - 1; j++)
            //    {
            //        if (str[j].Length > str[j + 1].Length)
            //        {
            //            string temp = str[j + 1];
            //            str[j + 1] = str[j];
            //            str[j] = temp;
            //        }
            //    }
            //}
            //foreach (string item in str)
            //{
            //    Console.Write(item + "\t");
            //}

            //3. 一个字符串数组，用户可以往其中任意位置添加、删除元素。
            string[] str = { "abc", "def", "123", "kkk" };
            int index = str.Length - 1;
            for (int i = 0; i <= index; i++)
            {
                Console.Write(str[i] + "\t");
            }
            Console.WriteLine();
            while (true)
            {
                Console.Write("请输入操作：add / delete / exit: ");
                string input = Console.ReadLine();
                if (input == "add")
                {
                    Console.Write("添加：");
                    string str_add = Console.ReadLine();
                    Console.Write("请输入下标：");
                    int index_add = int.Parse(Console.ReadLine());
                    if (index_add >= 0 && index_add <= index)
                    {
                        string[] newStrArr = new string[str.Length + 1];
                        for (int i = 0; i < newStrArr.Length; i++)
                        {
                            if (i < index_add)
                            {
                                newStrArr[i] = str[i];

                            }
                            else if (i > index_add)
                            {

                                newStrArr[i] = str[i - 1];
                            }
                            else
                            {
                                newStrArr[i] = str_add;
                            }
                        }
                        str = newStrArr;
                        index++;
                    }
                    else
                    {
                        Console.WriteLine("没有这个位置。");
                    }
                }
                else if (input == "delete")
                {
                    Console.Write("要删除的下标是：");
                    int index_delete = int.Parse(Console.ReadLine());
                    if (index_delete >= 0 && index_delete <= index)
                    {
                        index--;
                        for (int i = index_delete; i <= index; i++)
                        {
                            str[i] = str[i + 1];
                        }
                    }
                    else
                    {
                        Console.WriteLine("不存在此项");
                    }
                }
                string[] showArr = new string[index + 1];
                for (int i = 0; i <= index; i++)
                {
                    showArr[i] = str[i];
                    Console.Write(showArr[i] + "\t");
                }
                Console.WriteLine();
                str = showArr;
            }
        }
    }
}
