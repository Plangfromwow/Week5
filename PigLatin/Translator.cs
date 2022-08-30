using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    public class Translator
    {
        // This will return boolean if it's a vowel
        public static bool isVowel(char ch)
        {
           if (ch == 'a' || ch == 'i' || ch == 'u' || ch == 'e' || ch == 'o')
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool StartsWithVowel(string word)
        {
            bool result = isVowel(word[0]);
            return result;
        }

        public static int NumberOfCons(string word)
        {
            int index = 0;

            while (isVowel(word[index]) == false)
            {
                index++;
            }

            return index;
        }

        // now to do the thing 

        public static string PigLatinVowels(string word)
        {
            return word + "yay";
        }

        public static string PigLatinCons(string word)
        {
            int cons = NumberOfCons(word);
            string end = word.Substring(0, cons) + "ay";
            string start = word.Remove(0, cons);
            return start + end;
        }


        public static string PigLatinize(string word)
        {
            if (word == "")
            {
                return "Sorry, please enter a valid word.";
            }
            if (StartsWithVowel(word))
            {
                return PigLatinVowels(word);
            }
            else
            {
                return PigLatinCons(word);
            }
        }
    }
}
