using System;

// 1.Write a program that reads 3 real numbers from the console and prints their sum.
public class Sumof3Numbers
{
    public static void Main()
    {
        Console.WriteLine("Add three numbers which sum will be calculated:");
        double x1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the 3 numbers is: {0}", x1 + x2 + x3);
    }
}