using System;
using System.Text;

public class Task7
{
    public static void Solution()
    {
        Console.WriteLine("Type in text");
        string input = Console.ReadLine();
        char firstCharacter = input[0];
        int characterCount = 0;

        foreach (char letter in input)
        {
            if(letter == firstCharacter)
                characterCount++;
        }

        float characterOccurrencePercentage = (float) characterCount / input.Length;

        Console.WriteLine($"Percentage: {characterOccurrencePercentage}");
    }
}
