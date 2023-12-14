using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class armstrong
    {
        public static void Main(string[]args)
        {
            int rem, sum = 0,temp;
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
             temp = n;
            while(n!=0)
                {
                rem = n % 10;
                sum= sum+ (rem*rem*rm);
                n = n / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
                Console.WriteLine("Not Armstrong Number");
        }
    }
}
