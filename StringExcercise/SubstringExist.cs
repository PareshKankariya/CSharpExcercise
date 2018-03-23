using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class SubstringExist
    {
        public void fundSubstringExist()
        {
            String input = "This is a test";
            String subStr = "this";
            input = input.ToLower();
            subStr = subStr.ToLower();
            bool m = input.Contains(subStr);
            if (m)
                Console.Write("Substring '{0}' exist in the original string '{1}'", subStr, input);
            else
            {
                Console.WriteLine("Substring doesn't exist");
            }
        }
    }
}
