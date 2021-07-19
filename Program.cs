using System;
using System.Linq;

namespace Leetcode2021_July_CSharp
{
    internal class Program
    {
        // Complete the solution so that the function will break up camel casing,
        // using a space between words.

        // Example
        // "camelCasing"  =>  "camel Casing"
        // "identifier"   =>  "identifier"
        // ""             =>  ""

        public static string BreakCamelCase(string str)
        {
            // using counter to keep track of index 
            int counter = 0;

            // check to see if the string is empty or null
            if(string.IsNullOrEmpty(str))
            {
                return str;
            }
            // convert string to a char array 
            char[] charArray = str.ToCharArray();
            foreach (var item in charArray)
            {
                if (char.IsLower(item))
                {
                    counter++; // move on to the next index
                }
                if (char.IsUpper(item))
                {
                    str = str.Insert(counter , " " ); // when upper we want to insert a empty space at the last index before the upper case letter
                    counter = counter + 2; // add the extra space and upper case index place
                }
            }
            return str;
        }

        // using linq from solutions 
        public static string BreakCamelCaseLinq(string str)
        {
            return string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
        }

        private static void Main(string[] args)
        {
            BreakCamelCase("camelCasingTest");
           
        }
    }
}