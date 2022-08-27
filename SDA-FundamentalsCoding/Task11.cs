using System;
using System.Text;

public class Task11

{
    public static void Solution()
    {
        char[] arr1 = new char[] { 'a', 'b' };
        char[] arr2 = new char[] { 'c', 'd', 'e', 'f' };
        char[] arr3 = new char[] { 'g', 'h', 'j' };

        List<char> result = new List<char>();
        int longestArrayLength = new int[] { arr1.Length, arr2.Length, arr3.Length }.Max();
        char[][] arrays = new[] { arr1, arr2, arr3 };

        for (int i = 0; i < longestArrayLength; i++)
        {
            foreach (char[] array in arrays)
            {
                if (i < array.Length)
                    result.Add(array[i]);
            }
        }

        Console.WriteLine(result.ToArray());
    }
}
