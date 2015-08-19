using System;

public class TheBiggestOfFiveNumbers
{
    public static void Main()
    {
        Console.WriteLine("Enter five numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double biggest = a;
        Console.WriteLine("The biggest number is:");
        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(biggest);
        }
        else if (b > a && b >= c && b >= d && b >= e)
        {
            biggest = b;
            Console.WriteLine(biggest);
        }
        else if (c > a && c > b && c >= d && c >= e)
        {
            biggest = c;
            Console.WriteLine(biggest);
        }
        else if (d > a && d > b && d > c && d >= e)
        {
            biggest = d;
            Console.WriteLine(biggest);
        }
        else if (e > a && e > b && e > c && e > d)
        {
            biggest = e;
            Console.WriteLine(biggest);
        }
    }
}