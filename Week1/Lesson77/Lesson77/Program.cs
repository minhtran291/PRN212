using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displaying whether 'Exercise' is considered plural by calling the test method
            Console.WriteLine("Is 'Exercise' plural? " + test("Exercise"));

            // Displaying whether 'Exercises' is considered plural by calling the test method
            Console.WriteLine("Is 'Exercises' plural? " + test("Exercises"));

            // Displaying whether 'Books' is considered plural by calling the test method
            Console.WriteLine("Is 'Books' plural? " + test("Books"));

            // Displaying whether 'Book' is considered plural by calling the test method
            Console.WriteLine("Is 'Book' plural? " + test("Book"));
        }

        // Method to test if a word is plural based on its ending
        public static bool test(string word)
        {
            // Checking if the word ends with the letter 's'
            return word.EndsWith("s");
        }
    }
}
