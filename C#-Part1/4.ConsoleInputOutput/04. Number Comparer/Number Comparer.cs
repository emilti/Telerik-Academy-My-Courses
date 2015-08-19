using System;

// 4. Number Comparer
//
//    Write a program that gets two numbers from the console and prints the greater of them.
//    Try to implement this without if statements.
public class NumberComparer
{
    public static void Main()
    {
        Console.WriteLine("Add two numbers which will be compared:");
        double x1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double greater = x1 > x2 ? x1 : x2;
        Console.WriteLine("The greater number is: {0}", greater);
    }
}