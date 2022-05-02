using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class flipcoin

	{
		static Random rnd = new Random();
		public static void flipcoinprogram()
		{
			Console.WriteLine("Welcome to the coin flip Game");

			Random sc = new Random();

			Console.WriteLine("Enter Your Number: ");
			
			int headCount = 0, tailCount = 0;
			int count = sc.Next();

			for (int i = 0; i < count; i++)
			{
				double random = rnd.NextDouble();

				if (random < 0.5)
					tailCount++;
				else
					headCount++;
			}
			Console.WriteLine("Pecentage of tails(" + tailCount + "): " + (tailCount * 100f / (headCount + tailCount)));
			Console.WriteLine("Percentage of Head(" + headCount + "): " + (headCount * 100f / (headCount + tailCount)));

		}

	}

    
}
