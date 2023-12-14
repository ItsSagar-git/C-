using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class cube
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter the number:");
            int n=int.Parse(Console.ReadLine());
            int i = 1;
        label:
        
            {
                
                while( i<=n)
                {
                    int cube = i * i * i;
                    Console.WriteLine("Cube of the" + " " + i + " " + "is" + " " + cube);
                    i++;
                    goto label;

                }
            }
               
            
            
        }
    }
}
