using System;
using System.Collections.Generic;

// This is the beginning of the Exercise20 class
public class Exercise20
{
    // This is the main method where the program execution starts
    static void Main(string[] args)
    {
        // Displaying the result of the 'result' method with different integer arguments
        Console.WriteLine(result(13, 40)); // Test case 1: 'a' < 'b', returns 'b - a'
        Console.WriteLine(result(50, 21)); // Test case 2: 'a' > 'b', returns '(a - b) * 2'
        Console.WriteLine(result(0, 23));  // Test case 3: 'a' < 'b', returns 'b - a'
    }

    // Method to calculate and return a result based on two integer inputs
    public static int result(int a, int b)
    {
        if (a > b)
        {
            // If 'a' is greater than 'b', return the difference of 'a' and 'b' multiplied by 2
            return (a - b) * 2;
        }
        // If 'a' is not greater than 'b', return the difference of 'b' and 'a'
        return b - a;
    }
}
