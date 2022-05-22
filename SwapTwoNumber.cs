using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SwapTwoNumber
    {
        public static void SwapNum()
        {
            int a = 10;
            int b = 20; 
          
            int temp;
            temp = a; 
            a = b;
            b = temp;


            Console.WriteLine("After Swaping Value of a is"   + a);
            Console.WriteLine("After Swaping Value of b is" + b);
        }
    }
}
