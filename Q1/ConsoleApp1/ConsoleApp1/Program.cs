using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("this program can give the result of base^exponent");
            Console.ReadLine();

            Console.WriteLine("enter the value of the base");
            Console.ReadLine();
         
            Console.WriteLine("enter the value of the exponent");
            Console.ReadLine();

            Console.WriteLine(GetPow(2, 5));
            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for(int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }



    }
}
