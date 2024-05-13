using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initializing boolean variables
            bool cat = false;
            bool dog = true;

            // Displaying the original value of the 'cat' variable
            Console.WriteLine("Original value: " + cat);

            // Displaying the reversed value of 'cat' using the 'test' method
            Console.WriteLine("Reverse value: " + test(cat));

            // Displaying the original value of the 'dog' variable
            Console.WriteLine("Original value: " + dog);

            // Displaying the reversed value of 'dog' using the 'test' method
            Console.WriteLine("Reverse value: " + test(dog));
        }

        // Method to reverse a boolean value
        public static bool test(bool boolean)
        {
            // Reversing the boolean value using the logical NOT operator (!)
            return !boolean;
        }
    }
}
