using System;

// This is the beginning of the Exercise5 class
public class Exercise5
{
    // This is the main method where the program execution starts
    public static void Main(string[] args)
    {
        // Declaration of variables to store numbers and temporary value for swapping
        int number1, number2, temp;

        // Prompting the user to input the first number
        Console.Write("\nInput the First Number : ");
        // Reading the first number entered by the user and converting it to an integer
        number1 = int.Parse(Console.ReadLine());

        // Prompting the user to input the second number
        Console.Write("\nInput the Second Number : ");
        // Reading the second number entered by the user and converting it to an integer
        number2 = int.Parse(Console.ReadLine());

        // Swapping the values of number1 and number2 using a temporary variable
        temp = number1;
        number1 = number2;
        number2 = temp;

        // Displaying the result after swapping
        Console.Write("\nAfter Swapping : ");
        Console.Write("\nFirst Number : " + number1); // Displaying the first number after swapping
        Console.Write("\nSecond Number : " + number2); // Displaying the second number after swapping

        Console.Read(); // Keeping the console window open until a key is pressed
    }
}
