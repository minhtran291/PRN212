using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing an array of doubles
            double[] nums = { 1, 3, 4, 5, 6, 7 };

            // Displaying the original array elements
            Console.WriteLine("\nOrginal Array elements: ");
            foreach (var item in nums)
            {
                Console.Write(item.ToString() + " ");
            }

            // Displaying the cumulative sum of array elements after calling the test method
            Console.WriteLine("\nCumulative sum of the said array elements:");
            double[] result = test(nums);
            foreach (var item in result)
            {
                Console.Write(item.ToString() + " ");
            }

            // Another array of doubles with different values
            double[] nums1 = { 1.2, -3, 4.1, 6, -5.47 };

            // Displaying the original array elements
            Console.WriteLine("\nOrginal Array elements: ");
            foreach (var item in nums1)
            {
                Console.Write(item.ToString() + " ");
            }

            // Displaying the cumulative sum of array elements after calling the test method
            Console.WriteLine("\nCumulative sum of the said array elements:");
            double[] result1 = test(nums1);
            foreach (var item in result1)
            {
                Console.Write(item.ToString() + " ");
            }
        }

        // Method to calculate cumulative sum of an array of doubles
        public static double[] test(double[] nums)
        {
            // Loop to compute cumulative sum by adding current element to the previous element
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i - 1];
            }

            return nums; // Returning the array with cumulative sum values
        }
    }
}
