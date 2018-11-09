using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 4, 6, 3, 1, 5 };
            //int temp = 0;
            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    for (int j = 0; j < numbers.Length - i - 1; j++)
            //    {
            //        if (numbers[j] > numbers[j + 1])
            //        {
            //            temp = numbers[j];
            //            numbers[j] = numbers[j + 1];
            //            numbers[j + 1] = temp;
            //        }
            //    }
            //}

            //字符降序
            char[] characters = { 'd', 'D', 't', 'H', 'd', 's', 'J', 'b', 'T', '^', 'b', 'A', 'x' };
            for (int i = 0; i < characters.Length - 1; i++)
            {
                for (int j = 0; j < characters.Length - 1 - i; j++)
                {
                    if (characters[j] < characters[j+1])
                    {
                        char temp = characters[j];
                        characters[j] = characters[j + 1];
                        characters[j + 1] = temp;
                    }
                }
            }
            foreach (char item in characters)
            {
                Console.WriteLine(item);
            }
        }
    }
}
