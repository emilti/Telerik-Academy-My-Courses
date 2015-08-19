using System;

// 6. Quadratic Equation
// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
public class QuadraticEquation
{
    public static void Main()
    {
        Console.WriteLine("Enter a,b and c:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());        
        double discr = (b * b) - (4 * a * c);
        if (discr >= 0)
        {
            double x1 = (-b - Math.Sqrt(discr)) / ((double)2 * a);
            double x2 = (-b + Math.Sqrt(discr)) / ((double)2 * a);
            Console.WriteLine("x1={0}, x2={1}", x1, x2);
        }
        else
        {
            Console.WriteLine("No real roots");
        }
    }
}