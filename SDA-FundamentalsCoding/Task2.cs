using System;
    public class Task2
    {
        public static int Solution()
        {
            Console.WriteLine("Type in number");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                    Console.WriteLine("FizzBuzz");

                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");

                else if (i % 7 == 0)
                    Console.WriteLine("Buzz");

                else
                    Console.WriteLine(i);
            }
            return number;   
        }
    }
