using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class InsertNewString
    {
        public void InsertString()
        {
            String inputString, insertString, findString;

            Console.Write("Enter a string : ");
            inputString = Console.ReadLine();
            Console.Write("Enter substring to find : ");
            findString = Console.ReadLine();
            Console.Write("Enter string to add : ");
            insertString = Console.ReadLine();

            String[] inputArray = inputString.Split(' ');
            int index = inputString.IndexOf(findString);

            insertString = " " + insertString + " ";
            inputString = inputString.Insert(index, insertString);
            Console.Write("Modified string is : {0}", inputString);

        }

    }
}
