using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
   internal class EvenOddNumbers
    {
        public static void EvenOdd()
        {
           int num = 0;
                
            Console.WriteLine("Enter 0 for Odd Numbers Or 1 for Even Numbers ");
                num = Convert.ToInt32(Console.ReadLine());
           // int num = int.Parse(Console.ReadLine());
            //Random random = new Random();
            //int num=random.Next(0, 2);
            if (num == 0)

            {
                Console.WriteLine("Odd Numbers are");
                for (int i = 0; i <= 100; i++)
                {

                    if (i % 2 == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }

            }
            else 


            {
               
                Console.WriteLine("Even Numbers are");
                for (int i = 0; i <= 100; i++)
                {
                    
                    if (i % 2 == 1)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }

            }
        

	}
}

