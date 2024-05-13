using System;

namespace exercises
{
    class Program
    {
        // Main method where the program execution begins
        static void Main(string[] args)
        {
            // Calls the test function with two string arguments and prints the result
            Console.WriteLine(test("12", "43"));
        }

        // Function to compare two string representations of numbers and return the smaller one
        public static string test(string strn1, string strn2)
        {
            // Parsing the string representations of numbers to integers using Int32.Parse
            // Comparing the parsed integers using a ternary operator and returning the smaller string
            return Int32.Parse(strn1) > Int32.Parse(strn2) ? strn2 : strn1;
        }
    }
}
