using System;
using System.Collections.Generic;

public class Exercise31
{
    public static void Main()
    {
        // Declare and initialize the first array with integer values
        int[] first_array = { 1, 3, -5, 4 };

        // Declare and initialize the second array with integer values
        int[] second_array = { 1, 4, -5, -2 };

        // Display the elements of the first array
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", first_array));

        // Display the elements of the second array
        Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));

        // Display a message indicating multiplication of corresponding elements of both arrays
        Console.WriteLine("\nMultiply corresponding elements of two arrays: ");

        // Loop through the arrays to multiply corresponding elements and display the results
        for (int i = 0; i < first_array.Length; i++)
        {
            // Multiply the elements at index 'i' of both arrays and display the result
            Console.Write(first_array[i] * second_array[i] + " ");
        }

        // Move to the next line for a clean output format
        Console.WriteLine("\n");
    }
}
