using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class LargerNumber
    {
        public static void laegernumber()
        {
			Random s = new Random;

			//Taking values from user::
			Console.WriteLine("Enter the first number: ");
			int num1 = s.Next();

			Console.WriteLine("Enter the second number: ");
			int num2 = s.Next();

			Console.WriteLine("Enter the third number: ");
			int num3 = s.Next();

			//if_else statements::
			if (num1 > num2)
			{
				Console.WriteLine(num1 + " is larger value");
			}
			else if (num2 > num3)
			{
				Console.WriteLine(num2 + " is larger value");
			}
			else
			{
				Console.WriteLine(num3 + " is larger value");
			}

		}
	}
}
