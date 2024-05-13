using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        // Main method where the program execution begins
        static void Main(string[] args)
        {
            // Display original strings and convert letters into alphabetical order
            Console.WriteLine("Original string: PHP");
            Console.WriteLine("Convert the letters of the said string into alphabetical order: " + test("PHP"));

            Console.WriteLine("Original string: javascript");
            Console.WriteLine("Convert the letters of the said string into alphabetical order: " + test("javascript"));

            Console.WriteLine("Original string: python");
            Console.WriteLine("Convert the letters of the said string into alphabetical order: " + test("python"));
        }

        // Function to convert the letters of a string into alphabetical order
        public static string test(string str1)
        {
            // Using LINQ's OrderBy method to sort characters in the string alphabetically
            // Converting the sorted characters back to a string using new string() and ToArray()
            return new string(str1.OrderBy(x => x).ToArray());
        }
    }
}
