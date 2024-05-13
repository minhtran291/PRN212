using System;

// This is the beginning of the Exercise14 class
public class Exercise14
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        // Declaration of variables
        Console.Write("Enter the amount of Celsius: "); // Prompting the user to enter Celsius temperature
        int celsius = Convert.ToInt32(Console.ReadLine()); // Reading Celsius input and converting it to an integer

        // Calculating and displaying the equivalent temperature in Kelvin
        Console.WriteLine("Kelvin = {0}", celsius + 273);

        // Calculating and displaying the equivalent temperature in Fahrenheit
        Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
    }
}
