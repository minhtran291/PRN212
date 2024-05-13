using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initializing an integer 'n'
            int n = 12;

            // Displaying the original number 'n'
            Console.WriteLine("Original number: " + n);

            // Displaying the count of ones and zeros in the binary representation of 'n'
            Console.WriteLine("Number of ones and zeros in the binary representation of the said number:");
            Console.WriteLine(test(n));

            // Assigning a new value to 'n'
            n = 1234;

            // Displaying the new original number 'n'
            Console.WriteLine("\nOriginal number: " + n);

            // Displaying the count of ones and zeros in the binary representation of the new 'n'
            Console.WriteLine("Number of ones and zeros in the binary representation of the said number:");
            Console.WriteLine(test(n));
        }

        // Method to count the number of ones and zeros in the binary representation of a number
        public static string test(int n)
        {
            // Counting the number of ones in the binary representation of 'n'
            int ones = Convert.ToString(n, 2).Count(c => c == '1');

            // Counting the number of zeros in the binary representation of 'n'
            int zeros = Convert.ToString(n, 2).Count(c => c == '0');

            // Returning the count of ones and zeros as a formatted string
            return "Number of ones: " + ones + "\nNumber of zeros: " + zeros;
        }
    }
}
