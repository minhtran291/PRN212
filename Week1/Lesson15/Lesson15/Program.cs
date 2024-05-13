using System;
using System.Collections.Generic;

public class Exercise15
{
    // This is the main method where the program execution starts
    static void Main(string[] args)
    {
        // Displaying the result after removing a character at the specified index
        Console.WriteLine(remove_char("w3resource", 1)); // Removes character at index 1
        Console.WriteLine(remove_char("w3resource", 9)); // Removes character at index 9 (if exists)
        Console.WriteLine(remove_char("w3resource", 0)); // Removes character at index 0
    }

    // Function to remove a character at the specified index
    public static string remove_char(string str, int n)
    {
        return str.Remove(n, 1); // Using Remove method to eliminate the character at index n
    }
}
