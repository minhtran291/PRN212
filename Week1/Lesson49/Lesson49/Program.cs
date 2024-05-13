using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise49
{
    public static void Main()
    {
        // Define an array of integers 'nums1' with pre-defined values
        int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

        // Display the elements of 'nums1' array using string.Join to concatenate them
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums1));

        // Define another array of integers 'nums2' with pre-defined values
        int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };

        // Display the elements of 'nums2' array using string.Join to concatenate them
        Console.WriteLine("\nArray2: [{0}]", string.Join(", ", nums2));

        // Display a message indicating the check being performed on the first and last elements of both arrays
        Console.WriteLine("\nCheck if the first element or the last element of the two arrays (length 1 or more) are equal.");

        // Check if the first element of 'nums1' is equal to the first element of 'nums2'
        // OR if the last element of 'nums1' is equal to the last element of 'nums2'
        // Print the result of the logical OR operation between these conditions
        Console.WriteLine((nums1[0].Equals(nums2[0])) || (nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1])));
    }
}
