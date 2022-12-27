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
            Console.WriteLine("Power Of 2 calculator.");

            double powerOf2 = 0;
            Console.WriteLine("Enter power value : ");
            int value = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= value; i++)
            {
                powerOf2 = Math.Pow(2, i);
                Console.WriteLine("2 ^ {0} : {1}", i, powerOf2);
            }
                Console.ReadLine();
        }
    }
}


