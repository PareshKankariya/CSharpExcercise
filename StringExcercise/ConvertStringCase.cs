using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class ConvertStringCase
    {
        public void ConvertCase()
        {
            String input = "TeSt";
            char[] c = input.ToCharArray();
            Console.WriteLine("Original string : {0}", input);
            Console.Write("Converted String is : ");
            for (int i = 0; i < c.Length; i++)
            {
                //char ch = c[i];
                if (char.IsLower(c[i]))
                {
                    Console.Write(char.ToUpper(c[i]));
                }
                else
                {
                    Console.Write(char.ToLower(c[i]));
                }
            }
        }
    }
}
