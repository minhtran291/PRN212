using System;
using System.Collections.Generic;

public class Exercise30
{
    public static void Main()
    {
        // Declare a string variable 'hexval' and assign a hexadecimal value "4B0" to it
        string hexval = "4B0";

        // Display the original hexadecimal number
        Console.WriteLine("Hexadecimal number: " + hexval);

        // Convert the hexadecimal string 'hexval' to its decimal equivalent
        int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);

        // Display a message indicating conversion to different number systems
        Console.WriteLine("Convert to-");

        // Display the decimal value obtained from the hexadecimal conversion
        Console.WriteLine("Decimal number: " + decValue);
    }
}
