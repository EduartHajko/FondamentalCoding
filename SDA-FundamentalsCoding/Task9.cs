using System;
using System.Text;

public class Task9
{
    public static void Solution()
    {
        Console.WriteLine("Type in text");
        string input = Console.ReadLine();
        DateTime date = DateTime.Parse(input);

        int daysUntil = (int) Math.Ceiling(date.Subtract(DateTime.Now).TotalDays);

        Console.WriteLine($"Days until next SDA classes: {daysUntil}");
    }
}
