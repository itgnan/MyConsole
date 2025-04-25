using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITGnanConsole.IQ
{
    public class RandomNumberFromList
    {
        public void GetRandomNumbersFromGiven(int[] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int j = rand.Next(0, i + 1); // Pick a random index

                // Swap elements
                (array[i], array[j]) = (array[j], array[i]);
            }
        }
    }
}
