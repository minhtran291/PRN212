using System;

namespace exercises
{
    class Program
    {
        // Main method where the program execution begins
        static void Main(string[] args)
        {
            // Displays original strings and tests for consecutive similar letters
            Console.WriteLine("Original string: PHP");
            Console.WriteLine("Test for consecutive similar letters! " + test("PHP"));

            Console.WriteLine("Original string: PHHP");
            Console.WriteLine("Test for consecutive similar letters! " + test("PHHP"));

            Console.WriteLine("Original string: PHPP");
            Console.WriteLine("Test for consecutive similar letters! " + test("PHPP"));

            Console.WriteLine("Original string: PPHP");
            Console.WriteLine("Test for consecutive similar letters! " + test("PPHP"));
        }

        // Function to test if a string contains consecutive similar letters
        public static bool test(string text)
        {
            // Iterates through the characters of the string except the last character
            for (int i = 0; i < text.Length - 1; i++)
            {
                // Checks if the current character is the same as the next character
                // If consecutive similar letters are found, returns true
                if (text[i] == text[i + 1])
                {
                    return true;
                }
            }

            // Returns false if no consecutive similar letters are found in the string
            return false;
        }
    }
}
