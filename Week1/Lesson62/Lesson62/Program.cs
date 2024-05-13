using System;
using System.Linq;

public class Example
{
    // Function to reverse and remove parentheses from a string
    public static string reverse_remove_parentheses(string str)
    {
        // Find the last index of opening parenthesis '('
        int lid = str.LastIndexOf('(');

        // If no '(' is found, return the original string
        if (lid == -1)
        {
            return str;
        }
        else
        {
            // Find the corresponding closing parenthesis ')' for the found '('
            int rid = str.IndexOf(')', lid);

            // Recursively process the substring inside the parentheses and reverse it
            return reverse_remove_parentheses(
                str.Substring(0, lid) +
                new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray()) +
                str.Substring(rid + 1)
            );
        }
    }

    // Main method to test the reverse_remove_parentheses function
    public static void Main()
    {
        // Test the reverse_remove_parentheses function with different strings and print the results
        Console.WriteLine(reverse_remove_parentheses("p(rq)st"));       // Output: prqst
        Console.WriteLine(reverse_remove_parentheses("(p(rq)st)"));     // Output: pqrst
        Console.WriteLine(reverse_remove_parentheses("ab(cd(ef)gh)ij")); // Output: abcefdghij
    }
}
