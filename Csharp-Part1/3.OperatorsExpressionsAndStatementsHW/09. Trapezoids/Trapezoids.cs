using System;

// Problem 9. Trapezoids
//
//    Write an expression that calculates trapezoid's area by given sides a and b and height h.
public class Trapezoids
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Area of the Trapezoid: {0}", ((a + b) / 2.0) * h);
    }
}