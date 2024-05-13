using System;
using System.Collections.Generic;

// This is the beginning of the Exercise22 class
public class Exercise22
{
    // This is the main method where the program execution starts
    static void Main(string[] args)
    {
        Console.WriteLine("\nInput an integer:"); // Prompting the user to input an integer
        int x = Convert.ToInt32(Console.ReadLine()); // Reading the integer input provided by the user

        Console.WriteLine(result(x)); // Calling the 'result' method and printing the result
    }

    // Method to check if the given integer is within 20 units of 100 or 200
    public static bool result(int n)
    {
        // Checking if the absolute difference between 'n' and 100 is less than or equal to 20
        // OR the absolute difference between 'n' and 200 is less than or equal to 20
        if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
            return true; // Return true if the condition is satisfied
        return false; // Return false if the condition is not satisfied
    }
}
