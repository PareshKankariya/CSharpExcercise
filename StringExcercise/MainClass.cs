using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            UserInput userInputObj = new UserInput();
            CharFrequency charFreqObj = new CharFrequency();
            WordFrequency wordFreqObj = new WordFrequency();
            SortString sortStringObj = new SortString();
            GenerateSubstring generateSubstringObj = new GenerateSubstring();
            SubstringExist subStringExistObj = new SubstringExist();
            FindSubstring findSubstringObj = new FindSubstring();
            CheckCharacterCase checkCharacterCaseObj = new CheckCharacterCase();
            //checkCharacterCaseObj.checkCase();
            findSubstringObj.FindSubstringExist();
            //subStringExistObj.fundSubstringExist();
            //ConvertStringCase convertStringCaseObj = new ConvertStringCase();
            //convertStringCaseObj.ConvertCase();
         
            //generateSubstringObj.subStringEx();
            //sortStringObj.StringBubbleSort();
            //sortStringObj.SortStringExample();

            //wordFreqObj.WordFrequenceUsingDictionary();
           // wordFreqObj.DictionaryExample();
            //wordFreqObj.WordFreqDictionary(userInputObj.userInput());

            //charFreqObj.CharFreq(userInputObj.userInput());
            //wordFreqObj.WordFreq(userInputObj.userInput());
            
            //maxCharObj.WordFrequencyInGivenString(userInputObj.userInput());




            //VowelAndConsonant vcObj = new VowelAndConsonant();
            //vcObj.countVowelConsonant(userInputObj.userInput());


            //CopyString copyStringObj = new CopyString();
            //copyStringObj.StringCopy(userInputObj.userInput());
            //CompareInputStrings compareStringObj = new CompareInputStrings();
            //FindAlphabetDigitSpecialCharacter findCharObj = new FindAlphabetDigitSpecialCharacter();
            //findCharObj.findCharacters();

            // compareStringObj.compareString();
            //UserInput userInputObj = new UserInput();

            //BasicStringOperation basicStringOpearionObj = new BasicStringOperation();
            //String inputS = userInputObj.userInput();
            //basicStringOpearionObj.basicStringOps(inputS);
            Console.ReadLine();

        }
    }
}
