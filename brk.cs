using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class brk
    {
        public static void Main(String[]args)
        {
            int sum = 0;
            while(true)
            {
                Console.WriteLine("Enter a number:");
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                    break;
                sum = sum + n;
                
            }
            Console.WriteLine("Sum of positive numbers is:" + sum);
            Console.ReadKey();
        }
    }
}
