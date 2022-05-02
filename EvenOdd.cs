using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class EvenOdd
    {
        public static void evenandodd()
        {
			Random s = new Random();

			Console.WriteLine("Enter a number: ");
			int number = s.Next();

			if (number % 2 == 0)
			{
				Console.WriteLine(number + " is even");
			}
			else
			{
				Console.WriteLine(number + " is odd");
			}
		}

	}
}

