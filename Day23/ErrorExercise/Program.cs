using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //空引用
            try
            {
                string[] strArr = null;
                Console.WriteLine(strArr.Length);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            
            //越界
            try
            {
                List<string> list = new List<string>();
                Console.WriteLine(int.Parse(list[0]));
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            //无效转换
            try
            {
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }

    class Animal
    {

    }

    class Cat : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
}
