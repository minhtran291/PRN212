using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise34
{
    static void Main(string[] args)
    {
        // Declare a string variable 'str' to store user input
        string str;

        // Display a message asking the user to input a string
        Console.Write("Input a string : ");

        // Read user input and store it in the 'str' variable
        str = Console.ReadLine();

        // Check conditions and output result based on string content
        // Check if the length of the string is less than 6 and it's equal to "Hello"
        // OR check if the string starts with "Hello" and the character at index 5 is a space (' ')
        Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
    }
}
