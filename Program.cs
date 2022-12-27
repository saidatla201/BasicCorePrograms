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
            Console.WriteLine("Enter the Alphabet :");
            string alphabet = Console.ReadLine();

            string[] array1 = new string[]{ "a", "e","i","o","u","A","E","I","O","U"};

            int n = array1.Length;
            for (int i = 0; i < n; i++)
            {
                if (alphabet == array1[i])

                {
                    Console.WriteLine("The {0} is vowel", alphabet);
                }
                else
                {
                    Console.WriteLine("The {0} is constant", alphabet);
                }
            }
            
            Console.ReadLine();
    
        }
    }
}



