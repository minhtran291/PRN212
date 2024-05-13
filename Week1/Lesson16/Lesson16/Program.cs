using System;
using System.Collections.Generic;

// This is the beginning of the Exercise16 class
public class Exercise16
{
    // This is the main method where the program execution starts
    static void Main(string[] args)
    {
        // Displaying the result of rearranging the first and last characters of a string
        Console.WriteLine(first_last("w3resource")); // Rearranges the first and last characters of the string
        Console.WriteLine(first_last("Python")); // Rearranges the first and last characters of the string
        Console.WriteLine(first_last("x")); // Returns the same character for a single-character string
    }

    // Function to rearrange the first and last characters of a string
    public static string first_last(string ustr)
    {
        // Using the ternary operator to rearrange characters based on the length of the string
        return ustr.Length > 1
            ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1)
            : ustr; // Returns the same character for a single-character string
    }
}
