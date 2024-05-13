using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise41
{
    public static void Main()
    {
        // Prompt the user to input a string containing at least one 'w' character
        Console.Write("Input a string (contains at least one 'w' char) : ");

        // Read the input string and store it in the variable 'str'
        string str = Console.ReadLine();

        // Count the occurrences of the character 'w' in the input string and store the count in 'count'
        var count = str.Count(s => s == 'w');

        // Display a message indicating the test for the presence of 'w' character between 1 and 3 times
        Console.WriteLine("Test the string contains 'w' character between 1 and 3 times: ");

        // Check if the count of 'w' characters is between 1 and 3 (inclusive) and print the result
        Console.WriteLine(count >= 1 && count <= 3);
    }
}
