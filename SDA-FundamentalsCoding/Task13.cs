using System;
using System.Text;

public class Task13
{
    public static void Solution()
    {
        Console.WriteLine("Type in a number");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        int smallerPrime = number - 1;
        int biggerPrime = number + 1;

        while (!IsPrime(smallerPrime))
        {
            smallerPrime--;
        }

        while (!IsPrime(biggerPrime))
        {
            biggerPrime++;
        }

        Console.WriteLine($"The closest smaller prime to {number} is {smallerPrime}, the closest bigger prime is {biggerPrime}");
    }

    private static bool IsPrime(int n)
    {
        if (n <= 2) return true;
        if (n % 2 == 0) return false;

        var floor = (int)Math.Floor(Math.Sqrt(n));

        for (int i = 3; i <= floor; i += 2)
            if (n % i == 0)
                return false;

        return true;
    }
}
