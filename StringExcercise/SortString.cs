using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class SortString
    {
        public void SortStringExample()
        {
            String input = "is a";
            //char[] c = input.ToCharArray();
            String[] c = input.Split(' ');
            var sortedString =
                from w in c
                orderby w
                select w;
            Console.WriteLine(input);
            Console.Write("The sorted list is :\n");

            foreach (var a in sortedString)
                //if (a != ' ')
                {
                    Console.Write("{0} ", a);
                }
        }

        public void StringBubbleSort()
        {
            String input = "is a test";
            String[] inputArray = input.ToLower().Split();
            String temp = "";
            
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    if (inputArray[j].CompareTo(inputArray[j + 1]) > 0)
                    {
                        temp = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Original String : {0}", input);
            Console.Write("Sorted string : ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i] +" ");
            }

        }

    }
}
