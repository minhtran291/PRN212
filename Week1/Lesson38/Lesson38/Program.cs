using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise38
{
    static void Main(string[] args)
    {
        // Define a string variable 'str1' and assign it the value "PHP Tutorial"
        string str1 = "PHP Tutorial";

        // Initialize an empty string variable 'result' to store the concatenated characters
        var result = "";

        // Check if the length of 'str1' is greater than or equal to 1 and if the first character is 'P'
        if (str1.Length >= 1 && str1[0] == 'P')
            // If true, append the first character 'P' to the 'result' string
            result += str1[0];

        // Check if the length of 'str1' is greater than or equal to 2 and if the second character is 'H'
        if (str1.Length >= 2 && str1[1] == 'H')
            // If true, append the second character 'H' to the 'result' string
            result += str1[1];

        // Print the final concatenated string stored in the 'result' variable
        Console.WriteLine(result);
    }
}
