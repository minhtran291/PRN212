using System;
using System.Text.RegularExpressions;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring a string variable
            string text;

            // Testing the function test with different input strings
            // String containing letters, numbers, and special characters
            text = "Py@th12on";
            Console.WriteLine("Orginal string: " + text);
            Console.WriteLine("Remove all characters from the said string which are non-letters: " + test(text));

            // String containing letters, numbers, and spaces
            text = "Python 3.0";
            Console.WriteLine("\nOrginal string: " + text);
            Console.WriteLine("Remove all characters from the said string which are non-letters: " + test(text));

            // String containing letters, numbers, and special characters
            text = "2^sdfds*^*^jlljdslfnoswje34u230sdfds984";
            Console.WriteLine("\nOrginal string: " + text);
            Console.WriteLine("Remove all characters from the said string which are non-letters: " + test(text));
        }

        // Method to remove non-letter characters from a string using Regex
        public static string test(string text)
        {
            // Using Regex.Replace to remove characters that are not letters (a-zA-Z)
            return Regex.Replace(text, @"[^a-zA-Z]", "");
        }
    }
}
