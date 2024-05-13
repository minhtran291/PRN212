using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array declaration and initialization with integer elements
            int[] nums = { 10, -11, 12, -13, 14, -18, 19, -20 };

            // Displaying the original elements of the array 'nums'
            Console.WriteLine("Original Array elements:");
            foreach (var item in nums)
            {
                Console.Write(item.ToString() + " ");
            }

            // Calling the 'test' method and displaying the count of positive and negative numbers in the array 'nums'
            Console.WriteLine(test(nums));

            // Another array declaration and initialization with integer elements
            int[] nums1 = { -4, -3, -2, 0, 3, 5, 6, 2, 6 };

            // Displaying the original elements of the array 'nums1'
            Console.WriteLine("\nOriginal Array elements:");
            foreach (var item in nums1)
            {
                Console.Write(item.ToString() + " ");
            }

            // Calling the 'test' method and displaying the count of positive and negative numbers in the array 'nums1'
            Console.WriteLine(test(nums1));

            // Empty array declaration (no elements)
            int[] nums2 = { };

            // Displaying the original elements of the array 'nums2' (empty array)
            Console.WriteLine("\nOriginal Array elements:");
            foreach (var item in nums2)
            {
                Console.Write(item.ToString() + " ");
            }

            // Calling the 'test' method for the empty array 'nums2' and displaying the count of positive and negative numbers
            Console.WriteLine(test(nums2));
        }

        // Method to count the number of positive and negative numbers in an integer array
        public static string test(int[] nums)
        {
            // Filtering positive and negative numbers using LINQ 'Where' clause
            var pos = nums.Where(n => n > 0);
            var neg = nums.Where(n => n < 0);

            // Returning the count of positive and negative numbers as a formatted string
            return "\nNumber of positive numbers: " + pos.Count() + "\nNumber of negative numbers: " + neg.Count();
        }
    }
}
