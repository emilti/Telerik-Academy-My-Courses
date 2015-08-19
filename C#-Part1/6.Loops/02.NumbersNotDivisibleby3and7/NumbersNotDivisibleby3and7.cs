using System;

public class NumbersNotDivisibleby3and7
{
    public static void Main()
    {
        Console.WriteLine("Enter number:");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("All numbers fom 1 to n not divisible by 3 and 7");
        for (int i = 0; i < n; i++)
        {
            if ((i + 1) % 3 > 0 && (i + 1) % 7 > 0)
            {
                Console.Write("{0} ", i + 1);
            }
        }

        Console.WriteLine();
    }
}