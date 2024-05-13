using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        // Main method where the program execution begins
        static void Main(string[] args)
        {
            string file_path;

            // Initialize file_path variable with a file path and call the test function
            file_path = "c:/csharp/ex/test.cpp";
            Console.WriteLine(test(file_path));  // Output: test.cpp

            // Change file_path and call the test function again
            file_path = "c:/movies/abc.mp4";
            Console.WriteLine(test(file_path));  // Output: abc.mp4

            // Change file_path to a different path and call the test function
            file_path = "test.txt";
            Console.WriteLine(test(file_path));  // Output: test.txt
        }

        // Function to extract the file name from a file path
        public static string test(string file_path)
        {
            // Split the file path using '/' as the separator and extract the last part (file name)
            return file_path.Split('/').Last();
        }
    }
}
