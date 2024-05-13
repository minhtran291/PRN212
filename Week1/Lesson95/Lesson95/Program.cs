using System;
using System.Collections.Generic;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing different strings containing various parentheses combinations
            string text = "<>";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

            text = "<>()[]{}";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

            text = "(<>";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

            text = "[<>()[]{}]";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));
        }

        // Method to verify if a string contains valid parentheses
        public static bool test(string s)
        {
            // Creating a stack to store opening parentheses
            Stack<char> ch = new Stack<char>();

            // Iterating through each character in the input string
            foreach (var item in s.ToCharArray())
            {
                // Checking the type of parentheses and pushing the respective closing parentheses onto the stack
                if (item == '(')
                    ch.Push(')');
                else if (item == '<')
                    ch.Push('>');
                else if (item == '[')
                    ch.Push(']');
                else if (item == '{')
                    ch.Push('}');
                else if (ch.Count == 0 || ch.Pop() != item)
                    return false; // If the closing parentheses don't match the top of the stack or stack is empty, return false
            }

            // If the stack is empty after processing all characters, return true, otherwise return false
            return ch.Count == 0;
        }
    }
}
