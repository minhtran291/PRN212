using System;

public class Example
{
    // Function to count the number of elements required to make an array consecutive
    public static int consecutive_array(int[] input_Array)
    {
        // Sorting the input array in ascending order
        Array.Sort(input_Array);

        // Counter variable to track the number of elements needed to make the array consecutive
        int ctr = 0;

        // Loop through the sorted array to calculate the number of elements needed to fill the gaps
        for (int i = 0; i < input_Array.Length - 1; i++)
        {
            // Increment the counter by the difference between adjacent elements minus 1
            // This calculates the number of missing elements between consecutive elements
            ctr += input_Array[i + 1] - input_Array[i] - 1;
        }

        // Return the count of elements needed to make the array consecutive
        return ctr;
    }

    // Main method to test the consecutive_array function
    public static void Main()
    {
        // Testing the consecutive_array function with different input arrays
        Console.WriteLine(consecutive_array(new int[] { 1, 3, 5, 6, 9 })); // Output: 2
        Console.WriteLine(consecutive_array(new int[] { 0, 10 })); // Output: 8
    }
}
