using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise36
{
    static void Main(string[] args)
    {
        // Prompt the user to input the first number
        Console.Write("Input a first number: ");

        // Read user input and convert it to an integer 'm'
        int m = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to input the second number
        Console.Write("Input a second number: ");

        // Read user input and convert it to an integer 'n'
        int n = Convert.ToInt32(Console.ReadLine());

        // Check if either the first number 'm' or the second number 'n' is within the range -10 to 10 (inclusive)
        // Print the result of the logical OR operation between the conditions
        Console.WriteLine(((m >= -10 && m <= 10)) || ((n >= -10 && n <= 10)));
    }
}
