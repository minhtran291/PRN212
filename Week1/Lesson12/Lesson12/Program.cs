using System;

// This is the beginning of the Exercise12 class
public class Exercise12
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        int num; // Variable to store the digit entered by the user

        // Prompting the user to enter a digit
        Console.WriteLine("Enter a digit: ");
        // Reading the digit entered by the user and converting it to an integer
        num = Convert.ToInt32(Console.ReadLine());

        // Part A: "num num num num" using Write
        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.WriteLine();

        // Part B: "numnumnumnum" using Write
        Console.Write(num);
        Console.Write(num);
        Console.Write(num);
        Console.WriteLine(num);
        Console.WriteLine();

        // Part C: "num num num num" using {0}
        Console.WriteLine("{0} {0} {0} {0}", num);

        // Part D: "numnumnumnum" using {0}
        Console.WriteLine("{0}{0}{0}{0}", num);
    }
}
