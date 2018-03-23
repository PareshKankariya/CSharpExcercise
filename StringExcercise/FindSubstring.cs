using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class FindSubstring
    {
        public void FindSubstringExist()
        {
            String input, findString;
            Console.Write("Enter a string :  ");
            input = Console.ReadLine();
            Console.Write("Enter a search string : ");
            findString = Console.ReadLine();
            int index = input.IndexOf(findString);
            String[] inputArray = input.Split(' ');
            int counter = 0;
            foreach (String s in inputArray)
            {
                //counter = 0;
                if (s == findString)
                {
                    counter++;
                }
                
            }
            Console.Write("String '{0}' appeared {1} times in '{2}'", findString, counter, input);
            //if (index > 0)
            //{
            //    Console.Write("'{0}' found in main string '{1}' at index {2}", findString, input, index);
            //}
            //else
            //{
            //    Console.Write("'{0}' does not exist in given string '{1}'", findString, input);
            //}

        }
    }
}
