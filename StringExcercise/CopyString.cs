using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class CopyString
    {
        public void StringCopy(String input)
        {
            int l = input.Length;
            String[] output = new string[l];
            int i = 0;
            
            while (i < l)
            {
                String temp = input[i].ToString();
                output[i] = temp;
                i++;
            }
            Console.Write("Input string is : {0}", input);
            Console.Write("\nCopied string is : {0}", String.Join("", output));
            Console.Write("\nNumber of characterscopied : {0}", i);
            Console.ReadLine();
        }
    }
}
