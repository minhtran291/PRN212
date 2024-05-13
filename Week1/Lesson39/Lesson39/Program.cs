using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise39
{
    static void Main(string[] args)
    {
        // Prompt the user to input the first integer
        Console.WriteLine("\nInput first integer:");

        // Read the input and convert it to an integer 'x'
        int x = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to input the second integer
        Console.WriteLine("Input second integer:");

        // Read the input and convert it to an integer 'y'
        int y = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to input the third integer
        Console.WriteLine("Input third integer:");

        // Read the input and convert it to an integer 'z'
        int z = Convert.ToInt32(Console.ReadLine());

        // Find and display the largest of the three integers using Math.Max method
        Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));

        // Find and display the smallest of the three integers using Math.Min method
        Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));
    }
}
