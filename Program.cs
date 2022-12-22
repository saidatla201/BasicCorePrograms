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
            Console.WriteLine("Please enter the numbers:");
            int firstnumber= Convert.ToInt32(Console.ReadLine());
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            int temp = 0;

            //condition for swapping
            Console.WriteLine("Numbers before swapping firstnumber={0} secondnumber={1}",firstnumber,secondnumber );
            temp = firstnumber;
            firstnumber = secondnumber;
            secondnumber = temp ;
            Console.WriteLine("Numbers after swapping firstnumber={0} secondnumber={1}" ,firstnumber  , secondnumber );
            Console.ReadLine();
        }
    }
}


