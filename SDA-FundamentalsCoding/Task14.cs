using System;
using System.Text;

public class Task14
{
    public static void Solution()
    {
        Console.WriteLine("Type in a value");
        string input = Console.ReadLine();

        string isInt = int.TryParse(input, out _) ? "Success" : "Error";
        string isFloat = float.TryParse(input, out _) ? "Success" : "Error";
        string isBool = bool.TryParse(input, out _) ? "Success" : "Error";
        string isByte  = byte.TryParse(input, out _) ? "Success" : "Error";
        string isChar = char.TryParse(input, out _) ? "Success" : "Error";

        Console.WriteLine($"Int:{isInt}");
        Console.WriteLine($"Float:{isFloat}");
        Console.WriteLine($"Bool:{isBool}");
        Console.WriteLine($"Byte:{isByte}");
        Console.WriteLine($"Char:{isChar}");
    }
}
