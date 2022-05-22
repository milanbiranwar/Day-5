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
            Console.WriteLine("Enter Your Dividend Number: ");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Divisor Number: ");
           int num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quotient = " + num1 / num2);
            Console.WriteLine("Remainder= " + num1 % num2);
        }
    }
}
