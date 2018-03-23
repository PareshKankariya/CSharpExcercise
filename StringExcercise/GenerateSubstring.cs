using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class GenerateSubstring
    {
        public void subStringEx()
        {
            String input = "This is a test";
            char[] c = input.ToCharArray();
            int start = 4;
            int  end = 7;
            int size = c.Length;

            if (end == 0)
                end = size;
            Console.Write("Original String :{0}", input);
            Console.Write("\nSubstring is : ");
            for (int i = start; i < end; i++)
            {
                Console.Write(c[i]);
            }

        }
    }
}
