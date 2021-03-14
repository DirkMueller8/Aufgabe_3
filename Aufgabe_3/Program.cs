using System;
using System.Collections.Generic;

namespace Aufgabe_3
{
    // Author: Dirk Mueller
    // Date: 14.03.2021
    //
    // Algorithm:
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* This program determines the amount of voewels & other characters in a string *");
            Console.WriteLine("********************************************************************************");

            string strInput;
            char runningCharacter;
            List<char> listOfVowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            bool containsWowel = false;
            int nrVowels = 0;

            while (true)
            {
                Console.WriteLine();
                Console.Write("Give a string (exit with 0): ");
                strInput = Console.ReadLine();

                // The case for exit:
                if (strInput == "0")
                    break;

                strInput = strInput.ToLower();
                Console.WriteLine(strInput);

                for (int i = 0; i < strInput.Length; i++)
                {
                    runningCharacter = strInput[i];
                    containsWowel = listOfVowels.Contains(runningCharacter);
                    switch (containsWowel)
                    {
                        case true:
                            nrVowels++;
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine("There were {0} vowels and {1} consonants", nrVowels, strInput.Length - nrVowels);
            }
        }
    }
}
