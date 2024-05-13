using System;

public class Example
{
    // Function to check if a string is a palindrome
    public static bool checkPalindrome(string inputString)
    {
        // Convert the input string into a character array
        char[] c = inputString.ToCharArray();

        // Reverse the character array
        Array.Reverse(c);

        // Check if the reversed string is equal to the original input string
        return new string(c).Equals(inputString);
    }

    // Main method to test the checkPalindrome function
    public static void Main()
    {
        // Testing the checkPalindrome function with different input strings
        Console.WriteLine(checkPalindrome("aaa"));    // Output: True
        Console.WriteLine(checkPalindrome("abc"));    // Output: False
        Console.WriteLine(checkPalindrome("madam"));  // Output: True
        Console.WriteLine(checkPalindrome("1234"));   // Output: False
    }
}
