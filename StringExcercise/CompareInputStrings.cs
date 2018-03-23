using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class CompareInputStrings
    {
        public void compareString()
        {
            String firstString = " ";
            String secondString = " ";

            Console.Write("Enter a first string : ");
            firstString = Console.ReadLine();

            Console.Write("Enter a second string : ");
            secondString = Console.ReadLine();

            if (firstString.Length == secondString.Length)
            {
                int l = 0;

                while (l < firstString.Length)
                {
                    if (firstString[l] == secondString[l])
                    {
                        l++;
                    }
                }
                if (l == firstString.Length)
                {
                    Console.WriteLine("Strings match");
                }
                else
                {
                    Console.WriteLine("Strings don't match");
                }

            }
            else
            {
                Console.WriteLine("Strings don't match");
            }
        }
    }
}
