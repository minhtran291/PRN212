using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing different strings
            string text = "aaa";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check whether all the characters in the said string are same or not! " + test(text));

            text = "abcd";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check whether all the characters in the said string are same or not! " + test(text));

            text = "3333";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check whether all the characters in the said string are same or not! " + test(text));

            text = "2342342";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check whether all the characters in the said string are same or not! " + test(text));
        }

        // Method to check if all characters in a string are the same
        public static bool test(string text)
        {
            // Check if the length of the string is greater than 1
            if (text.Length > 1)
            {
                var b = text[0]; // Store the first character of the string

                // Loop through the characters starting from the second character
                for (int i = 1; i < text.Length; i++)
                {
                    var c = text[i]; // Store the current character

                    // If the current character is not equal to the first character, return false
                    if (c != b)
                    {
                        return false;
                    }
                }
            }
            return true; // Return true if all characters are the same or if the string has only one character
        }
    }
}
