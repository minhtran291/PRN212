using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // String representation of a number
            string n_str = "50";

            // Displaying the original value and type of the string
            Console.WriteLine("Original value and type: " + n_str + ",  " + n_str.GetType());

            // Converting string to an integer by calling the test_str_to_int method
            int result = test_str_to_int(n_str);

            // Displaying the returned integer value and its type after conversion
            Console.WriteLine("Convert string to integer:");
            Console.WriteLine("Return value and type: " + result + ",  " + result.GetType());

            // An integer value
            int n = 122;

            // Displaying the original value and type of the integer
            Console.WriteLine("\nOriginal value and type: " + n + ",  " + n.GetType());

            // Converting an integer to a string by calling the test_int_to_str method
            string result1 = test_int_to_str(n);

            // Displaying the returned string value and its type after conversion
            Console.WriteLine("Convert integer to string:");
            Console.WriteLine("Return value and type: " + result1 + ",  " + result1.GetType());
        }

        // Method to convert a string to an integer
        public static int test_str_to_int(string str)
        {
            return int.Parse(str);
        }

        // Method to convert an integer to a string
        public static string test_int_to_str(int n)
        {
            return n.ToString();
        }
    }
}
