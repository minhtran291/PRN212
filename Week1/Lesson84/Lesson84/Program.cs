using System;
using System.Linq;
using System.Collections.Generic;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring a string variable
            string text;

            // Testing the function test with different input strings

            // String containing only letters (Python)
            text = "Python";
            Console.WriteLine("Orginal string: " + text);

            // Calling the test method to get the indices of lowercase letters in the string
            int[] result = test(text);

            // Displaying the indices of lowercase letters in the string
            Console.WriteLine("\nIndices of all lower case letters of the said string:");
            foreach (var item in result)
            {
                Console.Write(item.ToString() + " ");
            }

            // Another string containing only letters (JavaScript)
            text = "JavaScript";
            Console.WriteLine("\nOrginal string: " + text);

            // Calling the test method to get the indices of lowercase letters in this string
            result = test(text);

            // Displaying the indices of lowercase letters in this string
            Console.WriteLine("\nIndices of all lower case letters of the said string:");
            foreach (var item in result)
            {
                Console.Write(item.ToString() + " ");
            }
        }

        // Method to find indices of lowercase letters in a string
        public static int[] test(string str)
        {
            // Using LINQ to select indices where the characters are lowercase in the string
            return str.Select((x, i) => i).Where(i => char.IsLower(str[i])).ToArray();
        }
    }
}
