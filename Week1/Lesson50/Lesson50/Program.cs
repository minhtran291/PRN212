using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise50
{
    public static void Main()
    {
        // Define an array of integers 'nums' with pre-defined values
        int[] nums = { 1, 2, 8 };

        // Display the elements of 'nums' array using string.Join to concatenate them
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));

        var temp = nums[0]; // Store the first element of 'nums' in a temporary variable 'temp'

        // Iterate through the elements of the 'nums' array (except the last element) using a for loop
        for (var i = 0; i < nums.Length - 1; i++)
        {
            nums[i] = nums[i + 1]; // Shift each element one place to the left
        }

        nums[nums.Length - 1] = temp; // Assign the value of 'temp' to the last element of 'nums'

        // Display the elements of the modified 'nums' array after rotation
        Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));
    }
}
