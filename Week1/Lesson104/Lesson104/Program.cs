using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize and assign values to variables x, y, and z
            int x = 1, y = 2, z = 3;

            // Display the original values of x, y, and z
            Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);

            // Output the number of equalities between the given numbers
            Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));

            // Assign new values to x, y, and z
            x = 1; y = 3; z = 3;

            // Display the new values of x, y, and z
            Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);

            // Output the number of equalities between the given numbers
            Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));

            // Assign new values to x, y, and z
            x = 3; y = 3; z = 3;

            // Display the new values of x, y, and z
            Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);

            // Output the number of equalities between the given numbers
            Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));
        }

        // Method to determine the number of equalities among three integers
        public static int test(int x, int y, int z)
        {
            // Return 3 if all three numbers are equal
            // Return 0 if all three numbers are different
            // Return 2 for any other case (two numbers are equal, but the third is different)
            return (x == y && y == z) ? 3 : (x != y && y != z && x != z) ? 0 : 2;
        }
    }
}
