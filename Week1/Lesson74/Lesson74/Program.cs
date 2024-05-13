using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        // Main method where the program execution begins
        static void Main(string[] args)
        {
            // Display original strings and check if their lengths are even or odd
            Console.WriteLine("Original string: PHP");
            Console.WriteLine("Length of the string: " + test("PHP"));

            Console.WriteLine("Original string: javascript");
            Console.WriteLine("Length of the string: " + test("javascript"));

            Console.WriteLine("Original string: python");
            Console.WriteLine("Length of the string: " + test("python"));
        }

        // Function to determine if the length of a string is even or odd
        public static string test(string word)
        {
            int length = word.Length; // Get the length of the input string

            // Check if the length is even or odd using the modulus operator (%)
            if (length % 2 == 0) // If the remainder is 0, the length is even
            {
                return "Even length";
            }
            else // If the remainder is not 0, the length is odd
            {
                return "Odd length";
            }
        }
    }
}
