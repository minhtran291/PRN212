using System;
using System.Linq;

public class Example
{
    // Function to sort numbers in an array, keeping -5 values in their original positions
    public static int[] sort_numbers(int[] arra)
    {
        // Extract and sort non-negative numbers (excluding -5)
        int[] num = arra.Where(x => x != -5).OrderBy(x => x).ToArray();

        int ctr = 0; // Counter for non-negative numbers used in sorting

        // Map sorted non-negative numbers back to the array while preserving -5 values
        return arra.Select(x => x >= 0 ? num[ctr++] : -5).ToArray();
    }

    // Main method to test the sort_numbers function
    public static void Main()
    {
        // Test the sort_numbers function with an array and print the result
        int[] x = sort_numbers(new int[] { -5, 236, 120, 70, -5, -5, 698, 280 });

        // Print each element of the resulting array
        foreach (var item in x)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
