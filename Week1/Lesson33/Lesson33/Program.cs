using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise33
{
    static void Main(string[] args)
    {
        // Display a message asking the user to input the first integer
        Console.WriteLine("\nInput first integer:");

        // Read the input from the user and convert it to an integer 'x'
        int x = Convert.ToInt32(Console.ReadLine());

        // Check if the entered number 'x' is greater than 0
        if (x > 0)
        {
            // If 'x' is positive, check if it is divisible by 3 or 7 using the modulo operator
            // Print the result of the logical OR operation between the conditions (divisible by 3 or 7)
            Console.WriteLine(x % 3 == 0 || x % 7 == 0);
        }
    }
}
