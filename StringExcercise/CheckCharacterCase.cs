using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class CheckCharacterCase
    {
        public void checkCase()
        {
            Console.Write("Enter a character : ");
            String input = Console.ReadLine();
            char c = Convert.ToChar(input);

            if (input.Length > 1)
            {
                Console.Write("Invalid input");
            }
            else if (char.IsUpper(c))
            {
                Console.Write("{0} is uppercase", c);
            }
            else if(char.IsLower(c))
            {
                Console.Write("{0} is a lowercase", c);
            }
            else
            {
                Console.Write("{0} is not a character", c);
            }
        }
    }
}
