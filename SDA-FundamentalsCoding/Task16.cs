using System;
using System.Text;

public class Task16

{
    public static void Solution()
    {
        Console.WriteLine("Type in number");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int guessMin = 0;
        int guessMax = array.Length-1;
        int guessIndex = (guessMin + guessMax) / 2;
        while (true)
        {
            guessIndex = (guessMin + guessMax) / 2;
            int guessNumber = array[guessIndex];
            if(guessNumber == number)
                break;
            if (guessNumber < number)
                guessMin = guessIndex + 1;
            else
                guessMax = guessIndex - 1;
        }

        Console.WriteLine($"Number {number} is under the index {guessIndex}");
    }
}
