using System;
using System.Collections.Generic;

// This is the beginning of the Exercise18 class
public class Exercise18
{
    // This is the main method where the program execution starts
    static void Main(string[] args)
    {
        // Prompting the user to input the first integer
        Console.WriteLine("\nInput first integer:");
        // Reading the first integer input provided by the user and converting it to an integer
        int x = Convert.ToInt32(Console.ReadLine());

        // Prompting the user to input the second integer
        Console.WriteLine("Input second integer:");
        // Reading the second integer input provided by the user and converting it to an integer
        int y = Convert.ToInt32(Console.ReadLine());

        // Displaying a message to check if one integer is negative and the other is positive
        Console.WriteLine("Check if one is negative and one is positive:");

        // Checking if one integer is negative and the other is positive, or vice versa, and displaying the result
        Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
    }
}
