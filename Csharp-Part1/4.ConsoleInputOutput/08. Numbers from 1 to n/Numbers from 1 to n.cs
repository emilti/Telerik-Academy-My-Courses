using System;

// 8. Numbers from 1 to n
//
// Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
public class NumbersFrom1ton
{
    public static void Main()
    {
        Console.WriteLine("Enter the number n:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("All numbers from 1 to n:");
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("{0}", i);
        }
    }
}