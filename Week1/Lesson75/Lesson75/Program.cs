using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        // Main method where the program execution begins
        static void Main(string[] args)
        {
            // Display the odd numbers at different positions
            Console.WriteLine("1st odd number: " + test(1));
            Console.WriteLine("2nd odd number: " + test(2));
            Console.WriteLine("4th odd number: " + test(4));
            Console.WriteLine("100th odd number: " + test(100));
        }

        // Function to calculate the nth odd number
        public static int test(int n)
        {
            return n * 2 - 1; // The nth odd number can be calculated using this formula
        }
    }
}
