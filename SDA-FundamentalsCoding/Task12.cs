using System;
using System.Text;

public class Task12
{
    public static void Solution()
    {
        Console.WriteLine("Type in a");
        string input = Console.ReadLine();
        int a = int.Parse(input);

        Console.WriteLine("Type in b");
        input = Console.ReadLine();
        int b = int.Parse(input);

        Console.WriteLine("Type in c");
        input = Console.ReadLine();
        int c = int.Parse(input);

        double delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Delta negative");
            return;
        }

        double x1 = (-b + delta) / (2 * a);
        double x2 = (-b - delta) / (2 * a);

        Console.WriteLine($"x1:{x1}, x2:{x2}");
    }
}
