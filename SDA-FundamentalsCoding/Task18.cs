using System;
using System.Text;
using System.Text.RegularExpressions;

public class Task18
{
    public static void Solution()
    {
        Console.WriteLine("Type in a number");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        Console.WriteLine($"{number}! = {Factorial(number)}");
    }

    private static int Factorial(int n)
    {
        if (n < 2)
            return n;
        return n * Factorial(n - 1);
    }
}
