using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        // Main method where the program execution begins
        static void Main(string[] args)
        {
            // Array of integers for testing average value
            int[] nums = { 1, 2, 3, 5, 4, 2, 3, 4 };
            // Displays whether the average value of the array is a whole number or not
            Console.WriteLine("Check the average value of the said array is a whole number or not: " + test(nums));

            int[] nums1 = { 2, 4, 2, 6, 4, 8 };
            Console.WriteLine("Check the average value of the said array is a whole number or not: " + test(nums1));
        }

        // Function to check if the average value of an array is a whole number or not
        public static bool test(int[] arr_nums)
        {
            // Calculates the average value of the array using LINQ's Average() method
            // Checks if the remainder when divided by 1 is equal to zero to determine if it's a whole number
            return arr_nums.Average() % 1 == 0;
        }
    }
}
