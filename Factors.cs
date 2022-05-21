using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Factors
    {
               public static void factor()
               {
			 int n, i;
                    Console.WriteLine("Enter the Number:");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Factors of NUmber are:");
                       for (i = 1; i <= n; i++)
                       {
                          if (n % i == 0)
                           {
                             Console.WriteLine(i);
                            }
                        }
	          }
	       
      }
		      
}

