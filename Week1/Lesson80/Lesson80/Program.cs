using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an array of objects to hold different types of values
            object[] mixedArray = new object[5];
            mixedArray[0] = 25; // Integer value
            mixedArray[1] = "Anna"; // String value
            mixedArray[2] = false; // Boolean value
            mixedArray[3] = System.DateTime.Now; // Current date and time value
            mixedArray[4] = 112.22; // Double value

            // Displaying the original array elements and their types
            Console.WriteLine("Printing original array elements and their types:");
            for (int i = 0; i < mixedArray.Length; i++)
            {
                Console.WriteLine("Value-> " + mixedArray[i] + " :: Type-> " + mixedArray[i].GetType());
            }

            // Calling the test method to convert the array of objects to an array of strings
            string[] new_nums = test(mixedArray);

            // Displaying the converted array elements and their types
            Console.WriteLine("\nPrinting array elements and their types after conversion:");
            for (int i = 0; i < new_nums.Length; i++)
            {
                Console.WriteLine("Value-> " + new_nums[i] + " :: Type-> " + new_nums[i].GetType());
            }
        }

        // Method to convert an array of objects to an array of strings
        public static string[] test(object[] nums)
        {
            // Using Array.ConvertAll to convert each object to its string representation
            return Array.ConvertAll(nums, x => x.ToString());
        }
    }
}
