using System;

// Problem 7. Point in a Circle
//
//    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
public class PointInACircle
{
    public static void Main()
    {
        Console.WriteLine("Enter x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y:");
        double y = double.Parse(Console.ReadLine());
        double distanceToCenter = (x * x) + (y * y);
        distanceToCenter = Math.Sqrt(distanceToCenter);
        Console.WriteLine("Is the point inside a circle K({0, 0}, 2):");
        if (distanceToCenter - 2 <= 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}