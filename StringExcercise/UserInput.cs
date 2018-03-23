using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class UserInput
    {
        public String userInput()
        {
            String inputString;
            Console.Write("Enter a string : " );
            inputString = Console.ReadLine();
            return inputString;
        }
        
    }
}
