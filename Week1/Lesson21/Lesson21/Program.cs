using System;
using System.Collections.Generic;

// This is the beginning of the Exercise21 class
public class Exercise21
{
    // This is the main method where the program execution starts
    static void Main(string[] args)
    {
        int x, y; // Declaring variables x and y to store integers
        int result; // Declaring a variable result (not used in the provided code snippet)

        Console.WriteLine("\nInput an integer:"); // Prompting the user to input an integer
        x = Convert.ToInt32(Console.ReadLine()); // Reading the first integer input provided by the user

        Console.WriteLine("Input another integer:"); // Prompting the user to input another integer
        y = Convert.ToInt32(Console.ReadLine()); // Reading the second integer input provided by the user

        // Checking if x equals 20 OR y equals 20 OR the sum of x and y equals 20
        Console.WriteLine(x == 20 || y == 20 || (x + y == 20)); // Outputting the result of the condition evaluation
    }
}
