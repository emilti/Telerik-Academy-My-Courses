using System;

// 11.* Numbers in Interval Dividable by Given Number
//
// Write a program that reads two positive integer numbers and prints how many numbers
// p exist between them such that the reminder of the division by 5 is 0.
public class NumbersIntervalDividableGivenNumber
{
    public static void Main()
    {
        Console.WriteLine("Write the start and the end of the interval:");
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = start; i <= end; i++)
        {
            p = i % 5 == 0 ? p + 1 : p;            
        }

        Console.WriteLine(p);
    }
}