using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise48
{
    public static void Main()
    {
        // Define an array of integers 'nums' with pre-defined values
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
        
        Console.WriteLine("Array1: [" + String.Join(", ", nums) + "]" );
        // Check if the length of the 'nums' array is greater than or equal to 1
        // AND if the first element of the array is equal to the last element of the array
        // Print the result of the logical AND operation between these conditions
        Console.WriteLine((nums.Length >= 1) && (nums[0].Equals(nums[nums.Length - 1])));
    }
    
}
