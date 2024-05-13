using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise47
{
    public static void Main()
    {
        // Define an array of integers 'nums' with pre-defined values
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

        // Display the elements of the 'nums' array using string.Join to concatenate them
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));

        var sum = 0; // Initialize a variable 'sum' to accumulate the sum of array elements

        // Iterate through the elements of the 'nums' array using a for loop
        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i]; // Add each element of the array to the 'sum' variable
        }

        // Display the sum of all elements in the array
        Console.WriteLine("Sum: " + sum);
    }
}
