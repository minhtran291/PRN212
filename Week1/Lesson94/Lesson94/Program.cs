using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing string arrays with different sets of strings
            string[] arr_strings1 = { "Padas", "Packed", "Pace", "Pacha" };
            Console.WriteLine("Original strings: " + $"{string.Join(", ", arr_strings1)}");
            Console.WriteLine("Longest common prefix from the said array of strings: " + test(arr_strings1));

            string[] arr_strings2 = { "Jacket", "Joint", "Junky", "Jet" };
            Console.WriteLine("\nOriginal strings: " + $"{string.Join(", ", arr_strings2)}");
            Console.WriteLine("Longest common prefix from the said array of strings: " + test(arr_strings2));

            string[] arr_strings3 = { "Bort", "Whang", "Yarder", "Zoonic" };
            Console.WriteLine("\nOriginal strings: " + $"{string.Join(", ", arr_strings3)}");
            Console.WriteLine("Longest common prefix from the said array of strings: " + test(arr_strings3));
        }

        // Method to find the longest common prefix among a string array
        public static string test(string[] arr_strings)
        {
            // Checking for edge cases: empty array or array containing an empty string
            if (arr_strings.Length == 0 || Array.IndexOf(arr_strings, "") != -1)
                return "";

            // Initializing 'result' to the first string in the array
            string result = arr_strings[0];
            int i = result.Length;

            // Looping through each word in the array to find the longest common prefix
            foreach (string word in arr_strings)
            {
                int j = 0;

                // Comparing characters at each position in the words
                foreach (char c in word)
                {
                    // Breaking if characters don't match or index 'j' exceeds the length of 'result'
                    if (j >= i || result[j] != c)
                        break;
                    j += 1;
                }

                // Updating 'i' with the minimum value between 'i' and 'j'
                i = Math.Min(i, j);
            }

            // Returning the longest common prefix based on 'i'
            return result.Substring(0, i);
        }
    }
}
