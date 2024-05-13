using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise46
{
    public static void Main()
    {
        // Prompt the user to input an integer
        Console.WriteLine("\nInput an integer:");

        // Read the input integer and store it in the variable 'x'
        int x = Convert.ToInt32(Console.ReadLine());

        // Define an array of integers 'nums' with pre-defined values
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

        // Check if the first element of the array 'nums' is equal to 'x'
        // OR if the last element of the array 'nums' is equal to 'x'
        // Print the result of the logical OR operation between these conditions
        Console.WriteLine((nums[0] == x) || (nums[nums.Length - 1] == x));
    }
}
