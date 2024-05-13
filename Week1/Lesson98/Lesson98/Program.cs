using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        // Method to check if a number is prime
        public static bool IsPrime(uint n)
        {
            if (n <= 1)
            {
                return false;
            }

            int ctr = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    ctr++;
                }
                if (ctr > 2)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            uint z = 0; // Counter variable for prime numbers
            int nc; // Variable to hold the count of numbers

            // Array of prime numbers
            var p = new uint[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var nxt = new uint[128]; // Array for next potential prime numbers

            while (true)
            {
                nc = 0; // Reset the count of numbers

                // Loop through each number in the array of prime numbers
                foreach (var x in p)
                {
                    // Check if the number is prime and display it
                    if (IsPrime(x))
                        Console.Write("{0,8}{1}", x, ++z % 5 == 0 ? "\n" : " ");

                    // Generate next potential prime numbers
                    for (uint y = x * 10, l = x % 10 + y++; y < l; y++)
                        nxt[nc++] = y;
                }

                // Check if there are more than one potential prime numbers
                if (nc > 1)
                {
                    // Resize the prime number array and copy next potential primes
                    Array.Resize(ref p, nc);
                    Array.Copy(nxt, p, nc);
                }
                else
                {
                    // Break the loop if there are no more potential primes
                    break;
                }
            }

            // Output the number of descending primes found
            Console.WriteLine("\n{0} descending primes found", z);
        }
    }
}
