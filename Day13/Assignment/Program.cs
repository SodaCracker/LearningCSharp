using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串t,y,o,j;p,q,h;z,h,k,x,m,用Split分割，装进一个交错char数组
            //string origin = "t,y,o,j;p,q,h;z,h,k,x,m,";
            //string[] array = origin.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            //string[][] strArray = new string[array.Length][];
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    strArray[i] = array[i].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            //}

            //char[][] charArray = new char[array.Length][];
            //for (int i = 0; i < charArray.Length; i++)
            //{
            //    charArray[i] = new char[strArray[i].Length];
            //    for (int j = 0; j < charArray[i].Length; j++)
            //    {
            //        charArray[i][j] = Convert.ToChar(strArray[i][j]);
            //    }
            //}

            string origin = "t,y,o,j;p,q,h;z,h,k,x,m";
            string[] array = origin.Split(';');
            char[][] charArray = new char[array.Length][];
            for (int i = 0; i < charArray.Length; i++)
            {
                string[] temp = array[i].Split(',');
                charArray[i] = new char[temp.Length];
                for (int j = 0; j < temp.Length; j++)
                {
                    charArray[i][j] = Convert.ToChar(temp[j]);
                }
            }


            //让用户不停输入字符串，直到输入exit为止。如果输入的是表示整数的字符串，就转为整数，并累加；如果是纯字母组成的，就拼接。最后打印累加的最终值和拼接成的字符串
            int sum = 0;
            //int result = 0;
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "exit")
                {
                    break;
                }
                //if (int.TryParse(s, out result))
                if (Regex.IsMatch(s, "^[-]?[1-9][0-9]*$"))
                {
                    //sum += result;
                    sum += int.Parse(s);
                }
                else if (Regex.IsMatch(s, "^[a-zA-Z]+$"))
                {
                    sb.Append(s);
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(sb.ToString());
        }
    }
}
