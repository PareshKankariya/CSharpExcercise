using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class FindAlphabetDigitSpecialCharacter
    {
        public void findCharacters()
        {
            Console.Write("Enter a string : ");
            String input = Console.ReadLine();
            int alphabets = 0;
            int digits = 0;
            int specialChar = 0;

            int stringLength = 0;
            stringLength = input.Length;
            int i = 0;
            while (i < stringLength) 
            {
                if ((input[i] >= 'A' && input[i] <= 'Z') || (input[i] >= 'a' && input[i] <= 'z'))
                {
                    alphabets++;
                }
                else if (input[i] >= '0' && input[i] <= '9')
                {
                    digits++;
                }
                else if (input[i] == ' ' ||input[i] == '\t' || input[i] == '\n')
                {
                    
                }
                else
                {
                    specialChar++;
                }

                i++;
            }
            Console.Write("\nTotal number of alphabets : {0}", alphabets);
            Console.Write("\nTotal number of digits : {0}", digits);
            Console.Write("\nTotal number of special characters : {0}", specialChar);
        }
    }
}
