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

            // Call the test function and store the returned array in new_nums
            int[] new_nums = test(nums);

            // Print each element of the new_nums array using Array.ForEach and Console.WriteLine
            Array.ForEach(new_nums, Console.WriteLine);
        }

        // Function to multiply each element of the input array by the array length
        public static int[] test(int[] nums)
        {
            // Get the length of the input array
            var arr_len = nums.Length;

            // Using LINQ's Select method to multiply each element by the array length
            // and converting it back to an array using ToArray()
            return nums.Select(el => el * arr_len).ToArray();
        }
    }
}
