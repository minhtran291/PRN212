using System;

namespace exercises
{
    class Program
    {
        // Main method where the program execution begins
        static void Main(string[] args)
        {
            // Calls the test function with different string arguments and prints the results
            Console.WriteLine(test("PHP")); // Output: 968
            Console.WriteLine(test("JAVASCRIPT")); // Output: J9781691
        }

        // Function to replace specific characters in a string with corresponding digits
        public static string test(string str1)
        {
            // Using multiple calls to Replace method to replace characters with specific digits
            return str1.Replace("P", "9").Replace("T", "0").Replace("S", "1").Replace("H", "6").Replace("A", "8");
        }
    }
}
