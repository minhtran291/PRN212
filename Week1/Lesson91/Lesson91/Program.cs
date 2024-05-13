using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing an array of objects with various types of values
            object[] mixedArray = new object[6];
            mixedArray[0] = 25;
            mixedArray[1] = "Anna";
            mixedArray[2] = false;
            mixedArray[3] = System.DateTime.Now;
            mixedArray[4] = -112;
            mixedArray[5] = -34.67;

            // Displaying the original elements of the mixed array
            Console.WriteLine("Original array elements:");
            for (int i = 0; i < mixedArray.Length; i++)
            {
                Console.Write(mixedArray[i] + " ");
            }

            // Calling the 'test' method to extract integer values from the mixed array
            int[] new_nums = test(mixedArray);

            // Displaying the integer values extracted from the mixed array
            Console.WriteLine("\n\nAfter removing all the values except integer values from the said array of mixed values:");
            for (int i = 0; i < new_nums.Length; i++)
            {
                Console.Write(new_nums[i] + " ");
            }
        }

        // Method to extract integer values from an array of objects
        public static int[] test(object[] nums)
        {
            // Using LINQ's 'OfType' to filter and convert objects to integers and returning as an array
            return nums.OfType<int>().ToArray();
        }
    }
}
