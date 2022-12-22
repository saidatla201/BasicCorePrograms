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
            
            int head = 0, tail = 0;
            Console.WriteLine("Enter how many times should coin flip:");
            int n= Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i <= n; i++)
            {
                double coin = random.NextDouble();
                if (coin < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }
                if (head > tail)
                {
                    Console.WriteLine("Heads wins");
                }
                else
                {
                    Console.WriteLine("Tails wins");
                }
                int headpercent= head * 100 / n;
                int tailpercent = tail * 100 / n;
                Console.WriteLine("Percent for flip the Heads is {0}% ,Percent for flip the tails is {1}%", headpercent, tailpercent);
                Console.ReadLine();
            
        }
    }
}
