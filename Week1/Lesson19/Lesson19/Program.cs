using System;
using System.Collections.Generic;

// This is the beginning of the Exercise19 class
public class Exercise19
{
    // This is the main method where the program execution starts
    static void Main(string[] args)
    {
        // Displaying the result of the SumTriple method with different integer arguments
        Console.WriteLine(SumTriple(2, 2));   // Test case 1: Equal integers
        Console.WriteLine(SumTriple(12, 10)); // Test case 2: Different integers
        Console.WriteLine(SumTriple(-5, 2));  // Test case 3: Different integers with negative value       
    }

    // Method to calculate the sum of two integers; if they are equal, the sum is tripled
    public static int SumTriple(int a, int b)
    {
        // Using a ternary conditional operator to check if integers 'a' and 'b' are equal
        return a == b ? (a + b) * 3 : a + b; // If 'a' equals 'b', return the triple sum of 'a' and 'b', otherwise return their sum
    }
}
