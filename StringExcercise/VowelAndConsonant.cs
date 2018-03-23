using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class VowelAndConsonant
    {
        public void countVowelConsonant(string input)
        {
            int stringLength = input.Length;
            int vowel = 0;
            int consonant = 0;
            int i = 0;
            while (i < stringLength)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {
                    vowel++;
                }
                else if (input[i] == ' ' || input[i] == '\n' || input[i] == '\t')
                {

                }
                else
                {
                    consonant++;
                }

                i++;
            }

            Console.Write("Input string is : {0}", input);
            Console.Write("\nNumber of Vowels : {0}", vowel);
            Console.Write("\nNumber of Consonants : {0}", consonant);
            Console.ReadLine();
        }
    }
}
