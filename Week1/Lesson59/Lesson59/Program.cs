using System;

public class Example
{
    // Function to test if an array can be made into an increasing sequence with at most one element change
    public static bool test_Increasing_Sequence(int[] int_seq)
    {
        int x = 0; // Counter to track the number of required changes

        // Loop through the array to check for non-increasing elements and count the changes needed
        for (int i = 0; i < int_seq.Length - 1; i++)
        {
            // Check if the current element is greater than or equal to the next element
            if (int_seq[i] >= int_seq[i + 1])
                x++; // Increment the counter as a change is needed

            // Check for the possibility of a larger gap (by comparing current and next-next elements)
            if (i + 2 < int_seq.Length && int_seq[i] >= int_seq[i + 2])
                x++; // Increment the counter as a change is needed
        }

        // Return true if the number of required changes is at most 2 (i.e., the array can be made increasing with at most one change)
        return x <= 2;
    }

    // Main method to test the test_Increasing_Sequence function
    public static void Main()
    {
        // Testing the test_Increasing_Sequence function with different input arrays
        Console.WriteLine(test_Increasing_Sequence(new int[] { 1, 3, 5, 6, 9 }));  // Output: True
        Console.WriteLine(test_Increasing_Sequence(new int[] { 0, 10 }));         // Output: True
        Console.WriteLine(test_Increasing_Sequence(new int[] { 1, 3, 1, 3 }));    // Output: False
    }
}
