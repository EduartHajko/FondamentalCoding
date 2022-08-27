using System;
using System.Text;
using System.Text.RegularExpressions;

public class Task15
{
    public static void Solution()
    {
        Console.WriteLine("Type in a password");
        string input = Console.ReadLine();

        Regex numbers = new Regex("\\d");
        Regex capitalLetters = new Regex("[A-Z]");
        Regex lowercaseLetters = new Regex("[a-z]");
        Regex specials = new Regex("[$#@!%^&*]");

        bool isGoodPassword = true;

        if(numbers.Matches(input).Count < 4) isGoodPassword = false;
        if (capitalLetters.Matches(input).Count < 2) isGoodPassword = false;
        if (lowercaseLetters.Matches(input).Count < 6) isGoodPassword = false;
        if (specials.Matches(input).Count < 1) isGoodPassword = false;

        Console.WriteLine(isGoodPassword ? $"{input} is a good password" : $"{input} is NOT a good password");
    }
}
