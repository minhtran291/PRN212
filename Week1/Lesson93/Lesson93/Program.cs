using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing integer 'n' with various values
            int n = 120;
            Console.WriteLine("Original number: " + n);

            // Displaying the square root of 'n'
            Console.WriteLine("Square root of the said number: " + test(n));

            // Changing the value of 'n' and repeating the process
            n = 225;
            Console.WriteLine("\nOriginal number: " + n);
            Console.WriteLine("Square root of the said number: " + test(n));

            // Changing the value of 'n' and repeating the process
            n = 335;
            Console.WriteLine("\nOriginal number: " + n);
            Console.WriteLine("Square root of the said number: " + test(n));
        }

        // Method to calculate the square root of a given number 'n'
        public static int test(double n)
        {
            int sq = 1;

            // Loop to find the square root using an iterative approach
            while (sq < n / sq)
            {
                sq++;
            }

            // Checking if the square is greater than 'n/square'. If so, returns the square - 1
            if (sq > n / sq)
                return sq - 1;
            return sq; // Returning the square root of 'n'
        }
    }
}
