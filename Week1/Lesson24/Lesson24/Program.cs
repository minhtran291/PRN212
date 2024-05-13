using System;

// This is the beginning of the Exercise24 class
public class Exercise24
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";

        // Splitting the string into words based on spaces and storing them in an array
        string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

        string word = ""; // Initializing an empty string to store the word with the maximum length
        int ctr = 0; // Initializing a counter variable to keep track of the maximum length

        // Looping through each word in the words array
        foreach (String s in words)
        {
            // Checking if the length of the current word is greater than the stored maximum length
            if (s.Length > ctr)
            {
                word = s; // If the current word's length is greater, update the 'word' variable
                ctr = s.Length; // Update the maximum length counter
            }
        }

        Console.WriteLine(word); // Displaying the word with the maximum length
    }
}
