using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandle
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            try
            {
                int a = int.Parse(s1);
                int b = int.Parse(s2);

                Console.WriteLine(a / b);
            }
            catch (FormatException format)
            {
                //Console.WriteLine("必须是整数");
                Console.WriteLine(format.Message);
            }
            catch (DivideByZeroException zero)
            {
                //Console.WriteLine("尝试除以 0");
                Console.WriteLine(zero.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("任何异常");
            }
            finally
            {
                //Console.WriteLine("保证执行，甚至在 returen 后面都会执行");
            }

            //Console.WriteLine("XXX");
            //Console.WriteLine("XXX");
            //Console.WriteLine("XXX");
        }
    }
}
