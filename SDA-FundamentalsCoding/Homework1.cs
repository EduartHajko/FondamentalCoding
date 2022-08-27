using System;
using System.Text;

public class Homework1
{
    public static void Solution()
    {
        Console.WriteLine("Type in text");
        string input = Console.ReadLine();
        string output = "";

        foreach (char character in input)
        {
            if (character >= 'A' && character <= 'Z')
                output += (char)(character + 32);
            else if (character >= 'a' && character <= 'z')
                output += (char)(character - 32);
            else
                output += character;
        }

        Console.WriteLine(output);
    }
}
