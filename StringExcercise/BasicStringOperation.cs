using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class BasicStringOperation
    {
        public void basicStringOps(String inputS)
        {

            //Add space between each character in the string 
            //Get String Length
            Console.WriteLine("Input string is : {0}", inputS);
            
            int strLength = 0;
          
            Console.Write("Space between each character : ");
            foreach (char i in inputS)
            {
                strLength = strLength + 1;
                Console.Write(i + " ");
            }
            Console.WriteLine("\nString length is : {0}", strLength);
            //Print string in the reverse order
            Console.Write("\nReverse String is : ");
            int l = strLength - 1;

            while (l >= 0)
            {
                Console.Write(inputS[l] + " ");
                l--;
            }

            //Count # of words in a string
            Console.Write("\nTotal # of words in a given string : ");
            int a = 0;
            int words = 1;
            while (a < inputS.Length - 1)
            {
                if (inputS[a] == ' ' || inputS[a] == '\n' || inputS[a] == '\t')
                {
                    words++;
                }

                a++;
            }
            Console.Write(words);





        }
    }
}
