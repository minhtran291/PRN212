using System;

namespace exercises
{
    class Program
    {
        // Main method where the program execution begins
        static void Main(string[] args)
        {
            // Calls the test function with different string arguments and characters, and prints the results
            Console.WriteLine(test("PHP Exercises", 'E', 'e')); // Output: 2
            Console.WriteLine(test("Latest News, Breaking News LIVE", 'A', 'a')); // Output: 3
        }

        // Function to count occurrences of characters in a string (case-insensitive)
        public static int test(string str1, char uc, char lc)
        {
            // Using Split method to count occurrences of characters (case-insensitive)
            // Splitting the string using provided uppercase and lowercase characters as separators,
            // then getting the count of splits minus 1 (as the count of splits equals occurrences)
            return str1.Split(uc, lc).Length - 1;
        }
    }
}
