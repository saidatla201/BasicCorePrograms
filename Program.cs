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
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine("The factors are {0} :",i);
                    number = number / i;
                }

            }
            if (number != 1)
            {
                Console.WriteLine( number);
            }
        
                Console.ReadLine();
        }
    }
}


