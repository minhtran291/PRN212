using System;

// This is the beginning of the Exercise25 class
public class Exercise25
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line."); // Displaying a message

        // Loop to print odd numbers from 1 to 99, one number per line
        for (int n = 1; n < (99 + 1); n++)
        {
            if (n % 2 != 0) // Checking if the number is odd by using the modulo operator
            {
                Console.WriteLine(n); // Printing the odd number
            }
        }
    }
}
