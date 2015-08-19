using System;

public class NumbersFrom1toN
{
    public static void Main()
    {
        Console.WriteLine("Enter number:");
        uint n = uint.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", i + 1);
        }

        Console.WriteLine();
    }
}