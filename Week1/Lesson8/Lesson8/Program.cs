using System;

// This is the beginning of the Exercise8 class
public class Exercise8
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        int x; // Variable to store the user input number
        int result; // Variable to store the result of multiplication

        Console.WriteLine("Enter a number:"); // Prompting the user to enter a number
        x = Convert.ToInt32(Console.ReadLine()); // Reading the number entered by the user and converting it to an integer

        // Loop through numbers from 1 to 10 to generate multiplication table for the entered number
        result = x * 1;
        Console.WriteLine("The table is : {0} x {1} = {2}", x, 1, result);
        result = x * 2;
        Console.WriteLine("             : {0} x {1} = {2}", x, 2, result);
        result = x * 3;
        Console.WriteLine("             : {0} x {1} = {2}", x, 3, result);
        result = x * 4;
        Console.WriteLine("             : {0} x {1} = {2}", x, 4, result);
        result = x * 5;
        Console.WriteLine("             : {0} x {1} = {2}", x, 5, result);
        result = x * 6;
        Console.WriteLine("             : {0} x {1} = {2}", x, 6, result);
        result = x * 7;
        Console.WriteLine("             : {0} x {1} = {2}", x, 7, result);
        result = x * 8;
        Console.WriteLine("             : {0} x {1} = {2}", x, 8, result);
        result = x * 9;
        Console.WriteLine("             : {0} x {1} = {2}", x, 9, result);
        result = x * 10;
        Console.WriteLine("             : {0} x {1} = {2}", x, 10, result);
    }
}
