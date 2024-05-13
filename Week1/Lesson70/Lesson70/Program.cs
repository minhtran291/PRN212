using System;

namespace exercises
{
    class Program
    {
        // Main method where the program execution begins
        static void Main(string[] args)
        {
            // Displays original strings and the result after removing first and last elements
            Console.WriteLine("Original string: PHP");
            Console.WriteLine("After removing first and last elements: " + test("PHP"));

            Console.WriteLine("Original string: Python");
            Console.WriteLine("After removing first and last elements: " + test("Python"));

            Console.WriteLine("Original string: JavaScript");
            Console.WriteLine("After removing first and last elements: " + test("JavaScript"));
        }

        // Function to remove the first and last characters of a string
        public static string test(string str1)
        {
            // Using conditional (ternary) operator to check if string length is greater than 2
            // If string length is greater than 2, it returns the substring excluding the first and last characters
            // If string length is less than or equal to 2, it returns the original string
            return str1.Length > 2 ? str1.Substring(1, str1.Length - 2) : str1;
        }
    }
}
