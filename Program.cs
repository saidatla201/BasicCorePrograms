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
            Console.WriteLine("Please enter the number:");
            int n= Convert.ToInt32(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("The number is Even");

            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
            Console.ReadLine();
        }
    }
}


