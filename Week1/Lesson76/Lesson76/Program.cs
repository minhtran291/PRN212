using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        // Main method where the program execution begins
        static void Main(string[] args)
        {
            // Display the ASCII values of different characters
            Console.WriteLine("Ascii value of 1 is: " + test('1'));
            Console.WriteLine("Ascii value of A is: " + test('A'));
            Console.WriteLine("Ascii value of a is: " + test('a'));
            Console.WriteLine("Ascii value of # is: " + test('#'));
        }

        // Function to obtain the ASCII value of a character
        public static int test(char ch)
        {
            return (int)ch; // Casting the character to an integer gives its ASCII value
        }
    }
}
