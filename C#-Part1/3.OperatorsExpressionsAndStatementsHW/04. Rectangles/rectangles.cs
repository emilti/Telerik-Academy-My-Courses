using System;

// Problem 4. Rectangles
//
//    Write an expression that calculates rectangle’s perimeter and area by given width and height.
public class Rectangles
{
    public static void Main()
    {
        Console.WriteLine("Enter the rextangle sides a and b:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double rectanleArea = a * b;
        double rectanglePerimeter = (2 * a) + (2 * b);
        Console.WriteLine("Rectangle Area: {0}", rectanleArea);
        Console.WriteLine("Rectangle Perimeter: {0}", rectanglePerimeter);
    }
}