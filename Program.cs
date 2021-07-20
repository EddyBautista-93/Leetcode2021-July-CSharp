using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode2021_July_CSharp
{
    internal class Program
    {
        // Disemvowel Trolls

        // Trolls are attacking your comment section!

        // A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

        // Your task is to write a function that takes a string and return a new string with all vowels removed.

        // For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

        // Note: for this kata y isn't considered a vowel.

        public static string Disemvowel(string str)
        {
            // array to loop through the string 
            char[] charArray = str.ToCharArray();

            // create a empty array to insert the new string 
            List<char> newSentenceList = new List<char>();

            // create a hashset for vowels 
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < charArray.Length; i++)
            {
                if (!vowels.Contains(charArray[i]))
                {
                    newSentenceList.Add(charArray[i]);
                }
              
            }
            string returnString = string.Join("", newSentenceList);
            return returnString;
        }

        private static void Main(string[] args)
        {
            Disemvowel("This website is for losers LOL!");
            Console.WriteLine("Ths wbst s fr lsrs LL!"); // test case
        }
    }
}