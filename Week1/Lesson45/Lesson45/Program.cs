using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise45
{
    static void Main(string[] args)
    {
        // Prompt the user to input an integer
        Console.WriteLine("\nInput an integer:");

        // Read the input integer and store it in the variable 'x'
        int x = Convert.ToInt32(Console.ReadLine());

        // Define an array of integers 'nums' with pre-defined values
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

        // Display a message indicating the number being searched for in the array
        Console.WriteLine("Number of " + x + " present in the said array:");

        // Count the occurrences of the input integer 'x' in the 'nums' array and print the count
        Console.WriteLine(nums.Count(n => n == x));
    }
}
