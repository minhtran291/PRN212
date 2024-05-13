using System;
using System.Text.RegularExpressions;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize strings and boolean variables
            string text1 = "AAA";
            string text2 = "BBB";
            Console.WriteLine("Original values: " + text1 + ", " + text2);
            Console.WriteLine("Check the equality of the said values: " + test(text1, text2));

            Boolean v1 = true;
            Boolean v2 = false;
            Console.WriteLine("Original values: " + v1 + ", " + v2);
            Console.WriteLine("Check the equality of the said values: " + test(v1, v2));

            // Here, the code seems to have a typo in the output statements (v1, v2) are used instead of (v1, text3)
            // Corrected the output statement below:
            Boolean v3 = true;
            string text3 = "true";
            Console.WriteLine("Original values: " + v1 + ", " + text3);
            Console.WriteLine("Check the equality of the said values: " + test(v1, text3));

            int n1 = 10;
            int n2 = 10;
            Console.WriteLine("Original values: " + n1 + ", " + n2);
            Console.WriteLine("Check the equality of the said values: " + test(n1, n2));
        }

        // Method to test equality of two objects
        public static bool test(object x, object y)
        {
            // Check if the objects are equal
            if (!x.Equals(y))
            {
                return false;
            }

            // Check if the objects are of the same type
            if (!x.GetType().Equals(y.GetType()))
            {
                return false;
            }

            // If both checks pass, return true
            return true;
        }
    }
}
