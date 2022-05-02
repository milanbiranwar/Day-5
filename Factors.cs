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
			Random sc = new Random();

			Console.Write("Enter Your Number : ");
			int n = sc.Next();


			// Printing the prime factors
			Console.Write("The Prime Factors of " + n + " are : ");

			int i = 2;
			while (n > 1)
			{
				if (n % i == 0)
				{
					Console.Write(i + " ");
					n = n / i;
				}
				else
				{
					i++;
				}
			}
			Console.WriteLine(" ");
		}

	}
}
}
