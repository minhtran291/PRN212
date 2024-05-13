using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array containing integers
            int[] nums = { 1, 2, 3 };

            // Displaying the sum of squares of elements in the array by calling the test method
            Console.WriteLine("Sum of squares of elements of the said array: " + test(nums));

            // Another array containing integers, including negative numbers
            int[] nums1 = { -2, 0, 3, 4 };

            // Displaying the sum of squares of elements in the second array by calling the test method
            Console.WriteLine("Sum of squares of elements of the said array: " + test(nums1));
        }

        // Method to calculate the sum of squares of elements in an array
        public static int test(int[] nums)
        {
            // Using LINQ's Sum method along with a lambda expression to calculate the sum of squares
            return nums.Sum(n => n * n);
        }
    }
}
