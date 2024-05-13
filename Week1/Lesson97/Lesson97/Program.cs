using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing different strings
            string text = "123";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check if the said string is numeric or not! " + test(text));

            text = "123.33";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check if the said string is numeric or not! " + test(text));

            text = "33/33";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check if the said string is numeric or not! " + test(text));

            text = "234234d2";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check if the said string is numeric or not! " + test(text));
        }

        // Method to check if a string is numeric
        public static bool test(string text)
        {
            double Result; // Declare a variable to store the parsed result

            // Try parsing the input string as a double
            // If successful, the string is numeric, return true; otherwise, return false
            return double.TryParse(text, out Result);
        }
    }
}
