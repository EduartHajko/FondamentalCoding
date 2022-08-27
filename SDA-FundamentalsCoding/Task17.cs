using System;
using System.Text;
using System.Text.RegularExpressions;

public class Task17
{
    public static void Solution()
    {
        Console.WriteLine("Type in text");
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');

        StringBuilder sb = new StringBuilder();

        foreach (string word in inputs)
        {
            sb.Append($"{word} ");
            sb.Append($"{word} ");
        }

        Console.WriteLine(sb.ToString());
    }
}
