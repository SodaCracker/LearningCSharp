using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("abc"));
            try
            {
                Console.WriteLine("aba");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //字符串不允许对称
        static string Reverse(string str)
        {
            if (IsSymmetric(str))
            {
                throw new SymmetricException("传入的字符串不能是对称的", str);
            }
            return new string(str.ToCharArray().Reverse().ToArray());
        }

        static bool IsSymmetric(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }

    class SymmetricException : Exception
    {
        string symm;

        public SymmetricException(string message, string symm) : base(message)
        {
            this.symm = symm;
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", Message, symm);
        }
    }
}
