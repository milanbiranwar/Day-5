using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class QuotandRemen
    {
        public static void quotiandremen()
        {
            Random s = new Random();

            //Taking values from user
            Console.WriteLine("Enter Your Dividend Number: ");
            int num1 = s.Next();

            Console.WriteLine("Enter Your Divisor Number: ");
            int num2 = s.Next();

            //To perform the operation
            Console.WriteLine("_________________________________________________________________________");

            Console.WriteLine("Quotient = " + num1 / num2);
            Console.WriteLine("Remainder= " + num1 % num2);

        }
    }
}
