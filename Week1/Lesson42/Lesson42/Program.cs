using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise42
{
    public static void Main()
    {
        // Prompt the user to input a string
        Console.Write("Input a string: ");

        // Read the input string and store it in the variable 'str'
        string str = Console.ReadLine();

        // Check if the length of the input string is less than 4 characters
        if (str.Length < 4)
            // If the length is less than 4, convert the whole string to uppercase and display it
            Console.WriteLine(str.ToUpper());
        else
            // If the length is 4 or greater, convert the first 4 characters to lowercase
            // and concatenate the rest of the string as is, then display the modified string
            Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length - 4));
    }
}
