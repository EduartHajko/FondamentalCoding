using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

public class Homework4
{
    public static void Solution()
    {
        int[][] A =
        {
            new[] { 1, 2 },
            new[] { 3, 4 },
            new[] { 5, 6 }
        };

        int[][] B =
        {
            new[] { 10, 9, 8},
            new[] { 7, 6, 5}
        };

        int[][] C = MultiplyMatrices(A, B);

        foreach (int[] row in C)
        {
            foreach (int val in row)
            {
                Console.Write($"{val} ");
            }
            Console.Write("\n");
        }
    }

    private static int[][] MultiplyMatrices(int[][] A, int[][] B)
    {
        int rowsA = A.Length;
        int columnsA = A[0].Length;
        int columnsB = B[0].Length;

        int[][] result = new int[rowsA][];

        for (int rowA = 0; rowA < rowsA; rowA++)
        {
            result[rowA] = new int[columnsB];
            for (int columnB = 0; columnB < columnsB; columnB++)
            {
                for (int columnA = 0; columnA < columnsA; columnA++)
                {
                    result[rowA][columnB] += A[rowA][columnA] * B[columnA][columnB];
                }
            }
        }

        return result;
    }
}
