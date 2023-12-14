using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class perfect
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int temp, sum = 0, rem;
            temp = num;
            for (int i = 1; i < num; i++)
            {
                rem = num % i;
                if (rem == 0)
                {
                    sum = sum + i;

                }

            }
            if (sum == temp)
            {
                Console.WriteLine("Perfect Number");
            }
            else
                Console.WriteLine("Not Perfect Number");

            Console.ReadKey();
        }
    }
}


