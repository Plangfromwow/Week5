using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberLab
{
    public class PrimeNumber
    {
        // takes int and find out if it's true or false
        public int number { get; set; }

        public PrimeNumber(int _number)
        {
            number = _number;
        }

        public int getPrimeNumber()
        {
            // gets the primes between 2 - 300
            int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 ,101, 127, 149, 179, 191, 223, 227, 251, 257, 269 };
            
                int positionPicked = number - 1;
                return primes[positionPicked];
                     
        }


    }
}
