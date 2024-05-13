using System;

namespace exercises
{
    class Program
    {
        // Constant to define a very small value for comparison
        public const double EPSILON = 1.0e-15;

        static void Main(string[] args)
        {
            // Initialize variables
            ulong fact = 1;          // Initialize factorial value to 1
            double e = 2.0;         // Initialize the value of 'e' to 2.0
            double e0;              // Initialize a temporary variable to hold previous 'e' value
            uint n = 2;             // Initialize a counter 'n' starting from 2

            // Loop to calculate 'e' using a series approximation until the difference between successive 'e' values is less than EPSILON
            do
            {
                e0 = e;             // Store the current value of 'e' in 'e0'
                fact *= n++;        // Calculate the factorial incrementally and update 'n'
                e += 1.0 / fact;    // Update 'e' using the factorial value
            } while (Math.Abs(e - e0) >= EPSILON); // Continue the loop until the difference between current 'e' and previous 'e' is greater than or equal to EPSILON

            // Output the calculated value of 'e' with high precision
            Console.WriteLine("e = {0:F15}", e);
        }
    }
}
