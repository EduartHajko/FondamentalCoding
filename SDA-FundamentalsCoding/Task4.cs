using System;
using System.Text;

public class Task4
{
    public static void Solution()
    {
        StringBuilder sb = new StringBuilder();


        Console.WriteLine("Type in text");
        string  input = Console.ReadLine();

        if  (input.ToLower()!="stop")
        {


            sb.Append(input+"");
        }
        else
        {
            Console.WriteLine("rezultati i string builderit  " + sb.ToString());
        }
       

    }
}
