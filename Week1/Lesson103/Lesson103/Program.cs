using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize and process different input strings
            string text = "AAAbfed231";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Sorted string: " + test(text));

            text = " ";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Sorted string: " + test(text));

            text = "Python";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Sorted string: " + test(text));

            text = "W3resource";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Sorted string: " + test(text));
        }

        // Method to sort and concatenate characters and digits in a string
        public static string test(string text)
        {
            // Check if the input string is null, empty, or consists only of whitespace characters
            bool flag = string.IsNullOrWhiteSpace(text);

            // If the string is blank, return "Blank string!"
            if (flag)
                return "Blank string!";

            // Extract digits and sort them in ascending order
            var text_nums = text.Where(char.IsDigit).OrderBy(el => el).ToList();

            // Extract letters, convert them to lowercase, sort them alphabetically, then by descending original character order
            var text_chars = text.Where(char.IsLetter)
                .Select(el => new { l_char = char.ToLower(el), _char = el })
                .OrderBy(el => el.l_char)
                .ThenByDescending(el => el._char)
                .ToList();

            // Concatenate the sorted characters and digits and return the resulting string
            return new string(text_chars.Select(el => el._char).Concat(text_nums).ToArray());
        }
    }
}
