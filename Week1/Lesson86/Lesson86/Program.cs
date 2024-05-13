using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring a variable to hold text
            string text;

            // Assigning a value to the 'text' variable
            text = "Python 3.0";

            // Displaying the original string in the console
            Console.WriteLine("Original string:: " + text);

            // Calling the 'test' method and displaying the result
            Console.WriteLine(test(text));

            // Assigning a new value to the 'text' variable
            text = "dsfkaso230samdm2423sa";

            // Displaying the new original string in the console
            Console.WriteLine("\nOriginal string:: " + text);

            // Calling the 'test' method again and displaying the result
            Console.WriteLine(test(text));
        }

        // Method to count the number of letters and digits in a string
        public static string test(string text)
        {
            // Counting the number of letters in the given 'text' using LINQ
            int ctr_letters = text.Count(char.IsLetter);

            // Counting the number of digits in the given 'text' using LINQ
            int ctr_digits = text.Count(char.IsDigit);

            // Returning the count of letters and digits as a string
            return "Number of letters: " + ctr_letters + "  Number of digits: " + ctr_digits;
        }
    }
}
