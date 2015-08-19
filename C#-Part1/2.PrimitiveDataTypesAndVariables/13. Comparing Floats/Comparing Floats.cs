using System;

// Problem 13.* Comparing Floats
//
//    Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
public class ComparingFloats
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double diff = Math.Abs(a - b);
        if (diff <= 0.000001)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }        
    }
}