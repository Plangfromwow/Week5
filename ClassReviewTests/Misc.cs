using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassReviewTests
{
    public class Misc
    {
        public static bool CheckRange(int x)
        {
            // return true if inbetween 10 - 20 inclusive
            // else returns false
            // Tests - Left of the range, right of the range, and in the range
            // 9,10,15,20,21

            if (x >= 10 && x <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // write a method  that checks if a number is negative,positive
        // returns: -1 if int negative, 0 if int is 0, Posi 1 if int is positive
        // What should we test? 
        
        public static int PosNeg(int x)
        {
          return Math.Sign(x);
        }
    }
}
