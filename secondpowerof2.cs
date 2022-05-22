using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class secondpowerof2
    {
        public static void secondpower()
        {
           
            int m = 2;
            int n = 31;
            int val = 1;

            for (int i = 0; i < n; i++)
            {
                val = val*m;
                Console.WriteLine(val);
            }
        }
    }
}
