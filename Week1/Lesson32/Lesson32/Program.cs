using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise32
{
    static void Main(string[] args)
    {
        // Declare a string variable 'str' to store user input
        string str;

        // Declare an integer variable 'l' and initialize it to 0
        int l = 0;

        // Display a message asking the user to input a string
        Console.Write("Input a string : ");

        // Read user input and store it in the 'str' variable
        str = Console.ReadLine();

        // Check if the length of the input string is greater than 4
        if (str.Length > 4)
        {
            // If the length is less than 4, concatenate the input string thrice
            // If the length is greater than or equal to 4, concatenate the last 4 characters of the input string four times
            Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
        }
    }
}
