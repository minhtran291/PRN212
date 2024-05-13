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

            // Displaying the next prime number or the current prime number of 'n'
            Console.WriteLine("Next prime number/Current prime number: " + test(n));

            // Changing the value of 'n' and repeating the process
            n = 321;
            Console.WriteLine("\nOriginal number: " + n);
            Console.WriteLine("Next prime number/Current prime number: " + test(n));

            // Changing the value of 'n' and repeating the process
            n = 43;
            Console.WriteLine("\nOriginal number: " + n);
            Console.WriteLine("Next prime number/Current prime number: " + test(n));

            // Changing the value of 'n' and repeating the process
            n = 4433;
            Console.WriteLine("\nOriginal number: " + n);
            Console.WriteLine("Next prime number/Current prime number: " + test(n));
        }

        // Method to find the next prime number or the current prime number of a given number 'n'
        public static int test(int n)
        {
            for (int i = 2; i < n; i++)
            {
                // Checking if 'n' is divisible by 'i', if true, increment 'n' and reset 'i' to 2
                if (n % i == 0)
                {
                    n++;
                    i = 2;
                }
            }
            return n; // Returning the next or current prime number
        }
    }
}
