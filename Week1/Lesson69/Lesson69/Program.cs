using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        // Main method where the program execution begins
        static void Main(string[] args)
        {
            // Calls the test function with different string arguments and prints the results
            Console.WriteLine(test("PHP")); // Output: True
            Console.WriteLine(test("python")); // Output: True
            Console.WriteLine(test("JavaScript")); // Output: False
        }

        // Function to check if a string contains both uppercase and lowercase characters
        public static bool test(string str1)
        {
            // Checking if the input string is equal to its uppercase version OR its lowercase version
            // If the string is either completely uppercase or completely lowercase, it returns true, otherwise false
            return str1 == str1.ToUpper() || str1 == str1.ToLower();
        }
    }
}
