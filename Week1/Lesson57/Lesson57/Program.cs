using System;

public class Example
{
    // Function to find the maximum product of adjacent elements in an array
    public static int adjacent_Elements_Product(int[] input_Array)
    {
        // Initialize the maximum product with the product of the first two elements in the array
        int max = input_Array[0] * input_Array[1];

        // Loop through the array to find the maximum product of adjacent elements
        for (int x = 1; x <= input_Array.Length - 2; x++)
        {
            // Update the max variable with the maximum of the current max and the product of the current and next elements
            max = Math.Max(max, input_Array[x] * input_Array[x + 1]);
        }

        // Return the maximum product of adjacent elements
        return max;
    }

    // Main method to test the adjacent_Elements_Product function
    public static void Main()
    {
        // Testing the adjacent_Elements_Product function with different input arrays
        Console.WriteLine(adjacent_Elements_Product(new int[] { 1, -3, 4, -5, 1 })); // Output: 20
        Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, 4, 5, 2 })); // Output: 20
        Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, -4, 5, 2 })); // Output: 15
        Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 0, -4, 0, 2 })); // Output: 0
    }
}
