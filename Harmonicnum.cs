using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Harmonicnum
    {
        public static void harmonicnumber()
        {
			// Assigning the variables
			double num = 0, result = 0, i;

			Random sc = new Random();

			//Taking data from users (Assuming Any number is a Harmonic_number)
			Console.Write("Enter the Number: ");
			int n = sc.Next();

			//Condition by using for loop
			for (i = 1; i <= n; i++)
			{
				num = num + (1 / i);
				result = num;
			}
			Console.WriteLine("The value of harmonic no. " + n + " is: " + result);

		}

	}
}

