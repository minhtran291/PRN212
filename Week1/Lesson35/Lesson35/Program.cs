using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise35
{
    static void Main(string[] args)
    {
        // Prompt the user to input the first number less than 100
        Console.Write("Input a first number(<100): ");

        // Read user input and convert it to an integer 'm'
        int m = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to input the second number greater than 200
        Console.Write("Input a second number(>200): ");

        // Read user input and convert it to an integer 'n'
        int n = Convert.ToInt32(Console.ReadLine());

        // Check if the first number is less than 100 AND the second number is greater than 200
        // Print the result of the logical AND operation between the conditions
        Console.WriteLine((m < 100 && n > 200));
    }
}
