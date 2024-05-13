using System;

// This is the beginning of the Exercise6 class
public class Exercise6
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        // Declaration of variables to store three numbers
        int num1, num2, num3;

        // Prompting the user to input the first number to multiply
        Console.Write("Input the first number to multiply: ");
        // Reading the first number entered by the user and converting it to an integer
        num1 = Convert.ToInt32(Console.ReadLine());

        // Prompting the user to input the second number to multiply
        Console.Write("Input the second number to multiply: ");
        // Reading the second number entered by the user and converting it to an integer
        num2 = Convert.ToInt32(Console.ReadLine());

        // Prompting the user to input the third number to multiply
        Console.Write("Input the third number to multiply: ");
        // Reading the third number entered by the user and converting it to an integer
        num3 = Convert.ToInt32(Console.ReadLine());

        // Calculating the result of multiplying the three numbers
        int result = num1 * num2 * num3;

        // Displaying the multiplication formula and the result to the console
        Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                            num1, num2, num3, result);
    }
}
