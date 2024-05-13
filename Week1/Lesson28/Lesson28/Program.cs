using System;
using System.Collections.Generic;

// This is the beginning of the Exercise28 class
public class Exercise28
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        string line = "Display the pattern like pyramid using the alphabet.";
        Console.WriteLine("\nOriginal String: " + line); // Displaying the original string

        string result = ""; // Initializing an empty string to store the reversed words
        List<string> wordsList = new List<string>(); // Creating a list to store reversed strings

        string[] words = line.Split(new[] { " " }, StringSplitOptions.None); // Splitting the string into individual words

        // Loop to reverse the words and create a new string
        for (int i = words.Length - 1; i >= 0; i--)
        {
            result += words[i] + " "; // Building the reversed string by adding words in reverse order
        }

        wordsList.Add(result); // Adding the reversed string to the list

        // Loop to print the reversed string from the list
        foreach (String s in wordsList)
        {
            Console.WriteLine("\nReverse String: " + s); // Displaying the reversed string
        }
    }
}
