using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    public class DrawDiamond
    {

        public static int LetterPos(char letter)
        {
            return (int)letter - 64;
        }

        public static int CalcPadding(char DLetter, char RowLetter)
        {
             return LetterPos(DLetter) - LetterPos(RowLetter);
        } 
        
        public static int calcSpacing(char RLetter)
        {
            if (RLetter == 'A')
            {
                return 0;
            }
            return LetterPos(RLetter) * 2 - 3;
        }

        public static string MakeSpaces(int number)
        {
            if (number == 0)
            {
                return "";
            }
            string result = "";
            for (int i=1; i <= number; i++)
            {
                result = result + ".";
            }
            return result;
        }

        public static string OneLine(char DLetter, char RowLetter)
        {
            // create a string varialbe
            string result = "";
            // first call calc padding

            // call make spaces using the padding and add to result

            // add on the letter 

            // call calc spacing for the inner spacing 

            //call make spaces again to turn into a string and add to result 

            // add on the letter again 

            //use make space string that we got back to add to the end spacing 

            //then return result
            return result;
        }

    }
}
