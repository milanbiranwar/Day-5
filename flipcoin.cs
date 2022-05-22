using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class flipcoin

	{
		 Random Rand = new Random();
            int heads = 0;
            
            int tails = 0;
            
            int result = 0;
       
            for (int i = 0; i < 10000; i++)
                
            {
                result = Rand.Next(0, 2);
                if (result == 1)
                    
                {
                    heads++;   
                }
                else
                {
                    tails++;
                }
   
            }
            Console.WriteLine("heads was flipped {0} times", heads);
            Console.WriteLine("tails was flipped {0} times", tails);
            return result;
		}

	}

    
}
