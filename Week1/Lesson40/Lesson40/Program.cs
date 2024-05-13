using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise40
{
    public static void Main()
    {
        // Prompt the user to input the first integer
        Console.WriteLine("\nInput first integer:");

        // Read the input and convert it to an integer 'x'
        int x = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to input the second integer
        Console.WriteLine("Input second integer:");

        // Read the input and convert it to an integer 'y'
        int y = Convert.ToInt32(Console.ReadLine());

        // Declare and assign a constant integer 'n' with the value 20
        int n = 20;

        // Calculate the absolute difference between 'x' and 'n', and store it in 'val1'
        var val1 = Math.Abs(x - n);

        // Calculate the absolute difference between 'y' and 'n', and store it in 'val2'
        var val2 = Math.Abs(y - n);

        // Output 0 if 'val1' is equal to 'val2', otherwise output the number closer to 'n' among 'x' and 'y'
        Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
    }
}
