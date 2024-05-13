using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise43
{
    static void Main(string[] args)
    {
        // Prompt the user to input a string
        Console.Write("Input a string : ");

        // Read the input string and store it in the variable 'str'
        string str = Console.ReadLine();

        // Call the 'test' method with the input string and output the result
        Console.WriteLine(test(str));
    }

    // Define a method named 'test' that takes a string parameter 'str' and returns a boolean value
    public static bool test(string str)
    {
        var ctr = 0; // Initialize a counter variable 'ctr' to count occurrences of 'w'

        // Iterate through the characters of the string using a for loop
        for (var i = 0; i < str.Length - 1; i++)
        {
            // Check if the current character is 'w'; if so, increment the counter 'ctr'
            if (str[i].Equals('w'))
                ctr++;

            // Check if the substring of length 2 starting at index 'i' contains "ww" 
            // and if the counter 'ctr' is greater than 2
            if (str.Substring(i, 2).Equals("ww") && ctr > 2)
                return true; // If the condition is met, return 'true'
        }

        return false; // Return 'false' if the condition is not met throughout the string
    }
}
