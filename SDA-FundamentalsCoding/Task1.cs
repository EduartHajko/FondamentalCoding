using System;

    public class Task1
    {
        public static void Solution()
        {
            Console.WriteLine("Type in circle diameter:");
            string input = Console.ReadLine();
            double diameter = double.Parse(input);
            double perimeter = 2 * Math.PI * diameter;
            Console.WriteLine($"Circle perimeter is {perimeter}");
        }
    }
