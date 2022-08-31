using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    public class Calculator
    {
        public int number { get; set; }

        public Calculator(int number)
        {
            this.number = number;
        }

        public int FindFactorial()
        {
            // to find a factorial, multiply by the one below --
            // start with the number
            // count down one less than the number and multiply each time 
            int result = number;

            for(int next = number -1; next >= 1; next--)
            {
                result = result * next;
            }

            return result;
        }

        public List<int> findFactors()
        {
            List<int> result = new List<int>();
            for (int num = 1; num <= number/2; num++)
            {
                if (number % num == 0)
                {
                    result.Add(num);
                }
            }
            result.Add(number);
            return result;

        }

    }
}
