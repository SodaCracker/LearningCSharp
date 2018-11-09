using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[4];
            int index = 0;

            while (true)
            {
                string str = Console.ReadLine();
                //加元素
                if (str == "add")
                {
                    while (true)
                    {
                        string str_add = Console.ReadLine();
                        if (str_add == "exit")
                        {
                            break;
                        }
                        lines[index] = str_add;
                        index++;
                        if (index == lines.Length)
                        {
                            string[] newArr = new string[lines.Length * 2];
                            for (int i = 0; i < lines.Length; i++)
                            {
                                newArr[i] = lines[i];
                            }
                            lines = newArr;
                        }
                    }
                }
                else if (str == "delete")
                {
                    if (index > 0)
                    {
                        Console.WriteLine(lines[0]);
                        for (int i = 0; i < index - 1; i++)
                        {
                            lines[i] = lines[i + 1];
                        }
                        index--;
                    }
                }
                else if (str == "print")
                {
                    for (int i = 0; i < index; i++)
                    {
                        Console.WriteLine(lines[i]);
                    }
                }
                else if (str == "exit")
                {
                    break;
                }
            }
        }
    }
}
