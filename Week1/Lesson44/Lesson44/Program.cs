using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise44 {
    static void Main(string[] args) {
        // Prompt the user to input a string
        Console.Write("Input a string : ");

        // Read the input string and store it in the variable 'str'
        string str = Console.ReadLine();

        // Initialize an empty string variable 'result' to store the characters at even indices
        var result = string.Empty;

        // Iterate through the characters of the input string using a for loop
        for (var i = 0; i < str.Length; i++) {
            // Check if the index 'i' is even (i.e., divisible by 2 without remainder)
            // If the index is even, add the character at index 'i' to the 'result' string
            if (i % 2 == 0)
                result += str[i];
        }

        // Output the 'result' string containing characters at even indices from the input string
        Console.WriteLine(result);
    }
}
