using System;
using System.Text;
using System.Text.RegularExpressions;

public class Homework2
{
    public static void Solution()
    {
        Console.WriteLine("Type in text");
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');

        Dictionary<char, List<string>> dictionary = new Dictionary<char, List<string>>();
        
        foreach (string s in inputs)
        {
            char firstChar = s.ToUpper()[0];
            if(!dictionary.ContainsKey(firstChar))
                dictionary[firstChar] = new List<string>();
            dictionary[firstChar].Add(s);
        }

        foreach (KeyValuePair<char, List<string>> pair in dictionary)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{pair.Key}: [");
            foreach (string s in pair.Value)
                sb.Append($"{s}, ");
            sb.Remove(sb.Length - 2, 2);
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }
    }
}
