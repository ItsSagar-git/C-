using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class fibo
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of terms in the Fibonacci series: ");
            int count = int.Parse(Console.ReadLine());
            int firstTerm = 0, secondTerm = 1, nextTerm;

            Console.WriteLine($"Fibonacci Series (first {count} terms):");

            for (int i = 0; i < count; i++)
            {
                if (i <= 1)
                {
                    nextTerm = i;
                }
                else
                {
                    nextTerm = firstTerm + secondTerm;
                    firstTerm = secondTerm;
                    secondTerm = nextTerm;
                }

                Console.Write($"{nextTerm} ");

            }
        }
    }
}


        
        