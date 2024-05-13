using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise51
{
    public static void Main()
    {
        // Initialize an integer array
        int[] nums = { 1, 2, 5, 7, 8 };

        // Display the contents of the array
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));

        // Initialize a variable to store the highest value
        var h_val = nums[0];

        // Loop through the array to find the highest value
        for (var i = 0; i < nums.Length; i++)
        {
            // Check if the current element is greater than the first element
            if (nums[i] > nums[0])
                h_val = nums[i]; // Update the highest value if condition is met
        }

        // Display the highest value between the first and last values of the array
        Console.WriteLine("\nHighest value between first and last values of the said array: {0}", h_val);
    }
}
