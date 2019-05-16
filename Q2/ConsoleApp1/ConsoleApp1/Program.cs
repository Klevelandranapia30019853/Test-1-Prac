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
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("-this program will give the sum total of 5 prices-");
            Console.WriteLine("--------------------------------------------------");
            Console.ReadLine();


            static int GetPow(int baseNum, int powNum)
            {
                int result = 1;

                for (int i = 0; i < powNum; i++)
                {
                    result = result * baseNum;
                }

                return result;
            }
        }    
    }
}