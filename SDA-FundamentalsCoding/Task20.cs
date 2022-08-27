public class Task20
{
    public static void Solution()
    {
        int[] array = new int[] { 7, 256, 9, 0, 1, -1, 13, -273 };

        int temp;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
        }

        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }
}
