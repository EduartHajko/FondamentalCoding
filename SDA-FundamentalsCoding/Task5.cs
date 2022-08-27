using System;
using System.Text;

public class Task5
{
    public static void Solution()
    {
        Console.WriteLine("Type in number");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        int a = 0;
        int b = 1;
        int c = 0;
        
        for (int i = 2; i < number; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        Console.WriteLine(c);
    }
}
