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
            Console.WriteLine("Enter the dividend value :");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor vale:");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int quotient = numerator / denominator;
            int remainder = numerator % denominator;

            Console.WriteLine("The quotient is {0} and the remainder is {1}", quotient, remainder);
            Console.ReadLine();
        }
    }
}


