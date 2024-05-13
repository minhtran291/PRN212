using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        // Main method where the program execution begins
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 7, 9 };
            int n = 6;

            // Calls the test function and prints the result
            Console.WriteLine(test(nums, n));

            n = 3;

            // Calls the test function again with a different value of n and prints the result
            Console.WriteLine(test(nums, n));
        }

        // Function to test if an array contains a specific element
        public static bool test(int[] arra, int n)
        {
            // Uses the Contains method of LINQ to check if the array contains the given number 'n'
            return arra.Contains(n);
        }
    }
}
