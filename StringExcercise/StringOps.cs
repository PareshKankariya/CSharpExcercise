using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class StringOps
    {
        public void AddSpaceEachChar()
        {
            string input = "This is a test";
            Console.WriteLine("String Length is {0}", input.Length);

            //Add space after each character
            foreach (char c in input)
            {
                if (c.ToString() != " ")
                {
                    Console.Write(c + " ");
                }

            }
        }

        public void ReverseString()
        {
            string input = "This is a Test";
            int l = input.Length;
            Console.WriteLine(l);

            while (l >= 0)
            {
                Console.Write(input[l - 1]);
                l--;
            }

        }

        public void NumberOfWords()
        {
            string input = "This is a Test";
            int words = 1;
            // int a = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    words++;
                }
            }

            //while (a < input.Length-1)
            //{
            //    if(input[a] == ' ')
            //    {

            //    }

            //}
            Console.WriteLine("Number Of Words {0}", words);

        }


        public void charFrequencyNew()
        {
            string inputString = "This his that";
            string input = inputString.ToLower();

            var charFrequencies = from c in input.ToCharArray()
                                  group c by c into groupfrequencies
                                  select groupfrequencies;

            //var charFreq = input.ToArray()
                            
            foreach (var c in charFrequencies)
         
                Console.WriteLine(String.Format("{0} : {1}", c.Key, c.Count()));
        }






        public void CharFrequency()
        {
            string inputString = "This his that";
            string input = inputString.ToLower();

            char[] c = input.ToLower().ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char b in c)
            {
                Console.Write(b);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < input.Length; i++)
            {

                int counter = 1;
                for (int j = i + 1; j < input.Length; j++)
                {

                    if (c[i] == c[j])
                    {
                        counter++;

                    }

                    try
                    {
                        if (c[i] != ' ' && c[i] != '\n')
                        {
                            dict.Add(c[i], counter);
                            //   Console.WriteLine("Letter {0} appeared {1} times", c[i], counter);


                        }

                    }
                    catch (Exception ex)
                    {

                        return;
                    }

                    finally
                    {
                        Dictionary<char, int> newDict = new Dictionary<char, int>();

                        //newDict = dict.GroupBy(d => d.Key).ToDictionary(grp => grp.First().Key, grp => grp.First().Value);

                        // newDict = dict.GroupBy(d => d.Key).ToDictionary(grp => grp.First().Key, grp => grp.First().Value);

                        var counts = dict.GroupBy(e => e.Key).OrderBy(e => e.Key).ToDictionary(grp => grp.Key, grp => grp.Count());

                        //var countNew = dict.Distinct(dict);


                        foreach (var pair in counts)
                        {
                            //Console.WriteLine("Letter {0} appeared {1} times", pair.Key, pair.Value);
                            Console.WriteLine(pair.Key + " " + pair.Value);
                        }

                    }

                }
               

            }



        }

    }

}







