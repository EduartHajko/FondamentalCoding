using System;
using System.Text;

public class Task8
{
    public static void Solution()
    {

        int i = 0;
        int number = 2;
        int sum = 0;
        while (i < 500)
        {
            if (IsPrime(number))
            {
                if (!number.ToString().Contains('3'))
                {
                    sum += number;
                    i++;
                }
            }

            number++;
        }

        Console.WriteLine($"The sum of first 500 numbers not containing digit 3 is {sum}");
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
