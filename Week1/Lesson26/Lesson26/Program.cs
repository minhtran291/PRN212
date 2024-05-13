using System;

// This is the beginning of the Exercise26 class
public class Exercise26
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        Console.WriteLine("\nSum of the first 500 prime numbers: "); // Displaying a message

        int sum = 0; // Initializing a variable to hold the sum of prime numbers
        int ctr = 0; // Initializing a counter to count the prime numbers
        int n = 2; // Starting from the first prime number

        // Loop to find and sum the first 500 prime numbers
        while (ctr < 500)
        {
            if (isPrime(n)) // Checking if 'n' is a prime number by calling the 'isPrime' method
            {
                sum += n; // Adding the prime number 'n' to the sum
                ctr++; // Incrementing the counter of prime numbers found
            }
            n++; // Moving to the next number for evaluation
        }

        Console.WriteLine(sum); // Displaying the sum of the first 500 prime numbers
    }

    // Method to check if a number is prime
    public static bool isPrime(int n)
    {
        int x = (int)Math.Floor(Math.Sqrt(n)); // Calculating the square root of 'n'

        if (n == 1) return false; // 1 is not a prime number
        if (n == 2) return true; // 2 is a prime number

        // Loop to check if 'n' is divisible by any number from 2 to square root of 'n'
        for (int i = 2; i <= x; ++i)
        {
            if (n % i == 0) return false; // If 'n' is divisible by 'i', it's not a prime number
        }

        return true; // 'n' is prime if not divisible by any number except 1 and itself
    }
}
