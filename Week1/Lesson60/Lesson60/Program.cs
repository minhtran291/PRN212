using System;

public class Example
{
    // Function to calculate the sum of matrix elements meeting certain conditions
    public static int sum_matrix_elements(int[][] my_matrix)
    {
        int x = 0; // Initialize a variable to store the sum of selected matrix elements

        // Loop through each column of the matrix
        for (int i = 0; i < my_matrix[0].Length; i++)
        {
            // Iterate through each row in the current column until a non-positive element is encountered
            for (int j = 0; j < my_matrix.Length && my_matrix[j][i] > 0; j++)
            {
                // Add the positive matrix element to the sum
                x += my_matrix[j][i];
            }
        }

        // Return the sum of matrix elements meeting the condition (positive elements)
        return x;
    }

    // Main method to test the sum_matrix_elements function
    public static void Main()
    {
        // Testing the sum_matrix_elements function with different input matrices
        Console.WriteLine(sum_matrix_elements(
            new int[][] {
                new int[]{0, 2, 3, 2},
                new int[]{0, 6, 0, 1},
                new int[]{4, 0, 3, 0}
            })); // Output: 17

        Console.WriteLine(sum_matrix_elements(
            new int[][] {
                new int[]{1, 2, 1, 0 },
                new int[]{0, 5, 0, 0},
                new int[]{1, 1, 3, 10 }
            })); // Output: 24

        Console.WriteLine(sum_matrix_elements(
            new int[][] {
                new int[]{1, 1},
                new int[]{2, 2},
                new int[]{3, 3},
                new int[]{4, 4}
            })); // Output: 10
    }
}
