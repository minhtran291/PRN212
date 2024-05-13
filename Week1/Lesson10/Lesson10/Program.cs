using System;

// This is the beginning of the Exercise10 class
public class Exercise10
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        // Declaration of variables to store three numbers
        int number1, number2, number3;

        // Prompting the user to enter the first number
        Console.Write("Enter first number - ");
        // Reading the first number entered by the user and converting it to an integer
        number1 = Convert.ToInt32(Console.ReadLine());

        // Prompting the user to enter the second number
        Console.Write("Enter second number - ");
        // Reading the second number entered by the user and converting it to an integer
        number2 = Convert.ToInt32(Console.ReadLine());

        // Prompting the user to enter the third number
        Console.Write("Enter third number - ");
        // Reading the third number entered by the user and converting it to an integer
        number3 = Convert.ToInt32(Console.ReadLine());

        // Calculating and displaying the results using formatted output
        Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)•z is {3} and x•y + y•z is {4}\n\n",
            number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));
    }
}
