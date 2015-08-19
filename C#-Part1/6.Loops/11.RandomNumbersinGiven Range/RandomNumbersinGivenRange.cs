using System;

public class RandomNumbersinGivenRange
{
    public static void Main()
    {
        Console.WriteLine("Enter sequence of three numbers which will be n, min and max of the new sequence:");
        string numbers = Console.ReadLine();
        string[] words = numbers.Split(' ');
        int length = words.Length;

        int[] newNumbers = new int[length];
        int n = int.Parse(words[0]);
        int min = int.Parse(words[1]);
        int max = int.Parse(words[2]);
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            int random = rnd.Next(min, max + 1);
            Console.Write("{0} ", random);
        }
    }
}