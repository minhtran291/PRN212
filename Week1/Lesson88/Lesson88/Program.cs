using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking the user to input the number of straight lines in the polygon
            Console.WriteLine("Input number of straight lines of the polygon:");

            // Reading the input number from the user and converting it to an integer
            int n = Convert.ToInt32(Console.ReadLine());

            // Displaying the sum of the interior angles of the polygon using the 'test' method
            Console.WriteLine("Sum of the interior angles (in degrees) of the said polygon: " + test(n));
        }

        // Method to calculate the sum of interior angles of a polygon
        public static int test(int num)
        {
            // Formula to calculate the sum of interior angles of a polygon
            return 180 * (num - 2);
        }
    }
}
