using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicprograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year>999 && year <=9999)
            {
                if(year%4==0)
                {
                    Console.WriteLine("This is leap year");
                }
                else
                {
                    Console.WriteLine("This is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("There is an error in the year num");
            }
            Console.ReadLine();
        }
    }
}


