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

            // String containing only letters (Python)
            text = "Python";
            Console.WriteLine("Orginal string: " + text);
            Console.WriteLine("After removing all the vowels from the said string: " + test(text));

            // String containing letters and a space (C Sharp)
            text = "C Sharp";
            Console.WriteLine("\nOrginal string: " + text);
            Console.WriteLine("After removing all the vowels from the said string: " + test(text));

            // String containing only letters (JavaScript)
            text = "JavaScript";
            Console.WriteLine("\nOrginal string: " + text);
            Console.WriteLine("After removing all the vowels from the said string: " + test(text));
        }

        // Method to remove all vowels from a string using Regex
        public static string test(string text)
        {
            // Using Regex.Replace to remove vowels (lowercase and uppercase) from the input string
            return new Regex(@"[aeiouAEIOU]").Replace(text, "");
        }
    }
}
