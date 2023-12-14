using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class positive
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
                Console.WriteLine("The number is zero.");
            Console.ReadKey();
        }
    }
}
