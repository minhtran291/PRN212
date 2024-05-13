using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompting the user to input an integer value
            Console.WriteLine("Input an integer value:");

            // Reading the input from the user and converting it to an integer
            int n = Convert.ToInt32(Console.ReadLine());

            // Checking if the given value is greater than or equal to its swap value
            Console.WriteLine("Check whether the said value is greater than its swap value: " + test(n));
        }

        // Method to check if a value is greater than its swap value
        public static bool test(int n)
        {
            // Calculating the swap value and comparing it with the original value
            return (int)(n / 10) >= n % 10;
        }
    }
}
