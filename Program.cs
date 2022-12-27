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
            Console.WriteLine("Enter 1st number :");
            int first= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  2nd number :");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int third = Convert.ToInt32(Console.ReadLine());
            if(first>second)
            {
                if(first >third )
                {
                    Console.WriteLine("The first number is largest among three");
                }
                
            }
            else if (second>third)
            {
                Console.WriteLine("The second number is largest among three");
            }
            else 
            {
                Console.WriteLine("The third number is largest among three");
            }
            Console.ReadLine();
        }
    }
}


