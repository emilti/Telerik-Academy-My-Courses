using System;

// Problem 3. Circle Perimeter and Area
// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
public class CirclePerimeterandArea
{
    public static void Main()
    {
        Console.Write("Radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter of the circle: {0:f2}", 2 * Math.PI * radius);
        Console.WriteLine("Area of the circle: {0:f2}",  Math.PI * radius * radius);
    }
}