using System;

public class BonusScore
{
    public static void Main()
    {
        Console.WriteLine("Enetr your score:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("The bonus score is:");
        if (a >= 1 && a <= 3)
        {
            a = a * 10;
            Console.WriteLine(a);
        }
        else if (a >= 4 && a <= 6)
        {
            a = a * 100;
            Console.WriteLine(a);
        }
        else if (a >= 7 && a <= 9)
        {
            a = a * 1000;
            Console.WriteLine(a);
        }
        else if (a <= 0 || a > 9)
        {
            Console.WriteLine("Invalid score");
        }
    }
}