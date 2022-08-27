using System;
using System.Text;

public class Task6
{
    public static void Solution()
    {
        Console.WriteLine("Type in number");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        int maxDigit = 0;

        while (number > 0)
        {
            int digit = number % 10;
            number /= 10;

            if (digit > maxDigit)
                maxDigit = digit;
        }

        Console.WriteLine(maxDigit);
    }
}
