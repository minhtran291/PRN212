using System;

// This is the beginning of the Exercise27 class
public class Exercise27
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        Console.Write("Input a number(integer): "); // Prompting user for input

        int n = Convert.ToInt32(Console.ReadLine()); // Reading user input as an integer

        int sum = 0; // Initializing a variable to store the sum of digits

        // Loop to calculate the sum of digits
        while (n != 0)
        {
            sum += n % 10; // Adding the last digit of 'n' to the 'sum' variable
            n /= 10; // Removing the last digit from 'n'
        }

        // Displaying the sum of the digits of the input number
        Console.WriteLine("Sum of the digits of the said integer: " + sum);
    }
}
