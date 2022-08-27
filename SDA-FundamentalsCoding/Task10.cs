using System;
using System.Text;

public class Task10
{
    public static void Solution()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 100);

        while (true)
        {
            Console.WriteLine("Guess a number (0-100)");
            string input = Console.ReadLine();
            int guess = int.Parse(input);

            if (guess == randomNumber) break;
            
            if(guess < randomNumber)
                Console.WriteLine("Too low!");
            else
                Console.WriteLine("Too high!");
        }

        Console.WriteLine($"Congratulations, you win!");
    }
}
