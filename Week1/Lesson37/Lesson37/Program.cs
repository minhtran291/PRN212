using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise37
{
    static void Main(string[] args)
    {
        // Define a string variable 'str' and assign it the value "PHP Tutorial"
        string str = "PHP Tutorial";

        // Check if the substring from index 1 of length 2 in 'str' equals "HP"
        // If true, remove the substring "HP" starting from index 1; otherwise, keep the original string 'str'
        Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
    }
}
