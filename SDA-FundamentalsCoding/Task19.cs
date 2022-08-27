using System;
using System.Text;
using System.Text.RegularExpressions;

public class Task19
{
    public static void Solution()
    {
        Console.WriteLine("Type in a triangle's height");
        string input = Console.ReadLine();
        int height = int.Parse(input);

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < height - i; j++)
            {
               Console.Write(' ');
            }

            for (int j = 0; j < i+1; j++)
            {
                Console.Write((char)('A'+j));
            }
            
            for (int j = i-1; j >= 0; j--)
            {
                Console.Write((char)('A' + j));
            }

            Console.Write('\n');
        }
    }
}
