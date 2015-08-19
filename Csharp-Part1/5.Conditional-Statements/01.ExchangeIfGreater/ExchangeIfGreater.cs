using System;

public class ExchangeIfGreater
{
    public static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            double c = b;
            b = a;
            a = c;
            Console.WriteLine("The first one is bigger than the second one, so their values are switched");
            Console.WriteLine(a + " " + b);
        }
        else
        {
            Console.WriteLine("The first one is smaller or equal to the second one, so their values are NOT switched");
            Console.WriteLine(a + " " + b);
        }
    }
}