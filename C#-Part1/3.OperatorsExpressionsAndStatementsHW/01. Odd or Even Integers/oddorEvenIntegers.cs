using System;

// Problem 1. Odd or Even Integers
//
//    Write an expression that checks if given integer is odd or even.
public class OddorEvenIntegers
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if (number % 2 > 0)
        {
            bool isOdd = true;
            Console.WriteLine("Is the number odd? {0}", isOdd);
        }
        else
        {
            bool isOdd = false;
            Console.WriteLine("Is the number odd? {0}", isOdd);
        }
    }
}