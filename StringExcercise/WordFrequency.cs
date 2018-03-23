using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class WordFrequency
    {
        public void WordFreq(String input)
        {
            //String input = "This is a a a is test";
            String[] word = input.ToLower().Split(' ');
            int length = word.Length;
            int counter = 0;
            for (int k = 0; k < length; k++)
            {
                Console.WriteLine("Word # {0} : {1}", k + 1, word[k]);
            }

            for (int i = 0; i < length; i++)
            {
                counter = 0;
                for (int j = 0; j < length; j++)
                {
                    if (word[i] == word[j] && i > j)
                    {
                        break;
                    }
                    if (word[i] == word[j])
                    {
                        counter++;
                    }

                }
                if (counter > 0)
                {
                    Console.WriteLine("Word '{0}' appeared {1} times", word[i], counter);
                }
            }
            Console.ReadLine();

        }

        public void WordFrequenceUsingDictionary()
        {
            {
                string Word;
                Console.WriteLine("Enter the word!..");
                Word = Console.ReadLine();   // Read the Input string from User at Run Time  
                var Value = Word.Split(' ');  // Split the string using 'Space' and stored it an var variable  
                Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>();
                for (int i = 0; i < Value.Length; i++) //loop the splited string  
                {
                    if (RepeatedWordCount.ContainsKey(Value[i])) // Check if word already exist in dictionary update the count  
                    {
                        int value = RepeatedWordCount[Value[i]];
                        RepeatedWordCount[Value[i]] = value + 1;
                    }
                    else
                    {
                        RepeatedWordCount.Add(Value[i], 1);  // if a string is repeated and not added in dictionary , here we are adding   
                    }
                }
                Console.WriteLine();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Repeated words and counts");
                foreach (KeyValuePair<string, int> kvp in RepeatedWordCount)
                {
                    Console.WriteLine(kvp.Key + " Counts are " + kvp.Value);  // Print the Repeated word and its count  
                }
                Console.ReadKey();
            }
        }

        public void DictionaryExample()
        {
            Dictionary<string, int> cityDict = new Dictionary<string, int>();

            cityDict.Add("CA", 100);
            cityDict.Add("AZ", 200);

            foreach (KeyValuePair<string, int> pair in cityDict)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }

            Console.WriteLine(cityDict.Count());

        }

        public void WordFreqDictionary(string input)
        {
            String[] word = input.Split(' ');
            Dictionary<string, int> occuranceDict = new Dictionary<string, int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (occuranceDict.ContainsKey(word[i]))
                {
                    int value = occuranceDict[word[i]];
                    occuranceDict[word[i]] = value + 1;
                }
                else
                {
                    occuranceDict.Add(word[i], 1);
                }
            }

            foreach (KeyValuePair<string, int> pair in occuranceDict)
            {
                Console.WriteLine("{0} occured {1} times", pair.Key, pair.Value);
            }
            

        }

        }
    }

