using System;

// This is the beginning of the Exercise11 class
public class Exercise11
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        int age; // Variable to store the user's age

        // Prompting the user to enter their age
        Console.Write("Enter your age ");

        // Reading the age entered by the user and converting it to an integer
        age = Convert.ToInt32(Console.ReadLine());

        // Displaying a message indicating that the user looks younger than their entered age
        Console.Write("You look younger than {0} ", age);
    }
}
