using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class CharFrequency
    {
        public void CharFreq(String input)
        {
            // String input = "This is a test";
            Char[] inputChar = input.ToLower().ToCharArray();
            int counter = 0;
            int length = input.Length;
            for (int i = 0; i < length; i++)
            {
                counter = 0;
                for (int j = 0; j < length; j++)
                {
                    if (inputChar[i] == inputChar[j] && i > j)
                    {
                        break;
                    }
                    if (inputChar[i] == inputChar[j])
                    {
                        counter++;
                    }
                }

                if (counter > 0 && inputChar[i] != ' ')
                {
                    Console.WriteLine("Letter {0} appeared {1} times", inputChar[i], counter);
                }

            }
            Console.WriteLine("Press any key to close");
            Console.ReadLine();
        }

    }
}
