using System;
using System.Linq;

// 7. Sum of 5 Numbers
//
// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
public class SumOf5Numbers
{
    public static void Main()
    {
        Console.WriteLine("Enter five numbers:");
        string input = Console.ReadLine();
        double sum = 0;
        
        // double[] arrayOfNums=input.Split(' ').Select(n => Convert.ToDouble(n)).ToArray();
        double[] arrayOfNums = input.Split(' ').Select(double.Parse).ToArray();
        for (int i = 0; i < arrayOfNums.Length; i++)
        {
            sum = sum + arrayOfNums[i];
        }

        Console.WriteLine(sum);
    }
}