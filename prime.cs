using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class prime
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0 || num % 3 == 0)
            {
                Console.WriteLine("The entered number is not prime.");
            }
            else
                Console.WriteLine("The entered number is prime.");
            Console.ReadKey();
        }
    }
}
