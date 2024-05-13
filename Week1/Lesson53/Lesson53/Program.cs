using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise53
{
    public static void Main()
    {
        // Initializing an array of integers
        int[] nums = { 2, 4, 7, 8, 6 };

        // Displaying the original array
        Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums));

        // Checking if the array contains an odd number and displaying the result
        Console.WriteLine("Check if an array contains an odd number? " + even_odd(nums));
    }

    // Function to check if the array contains an odd number
    public static bool even_odd(int[] nums)
    {
        // Iterating through each element of the array
        foreach (var n in nums)
        {
            // Checking if the element is odd
            if (n % 2 != 0)
                return true; // If an odd number is found, return true
        }
        return false; // If no odd number is found, return false
    }
}
