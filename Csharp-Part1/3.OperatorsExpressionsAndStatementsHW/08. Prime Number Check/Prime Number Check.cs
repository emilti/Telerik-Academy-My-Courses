using System;

// Problem 8. Prime Number Check
//
//    Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
public class PrimeNumberCheck
{
    public static void Main()
    {
        Console.WriteLine("Enter number between 1 and 100");
        int a = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= 100 && i <= a; i++)
        {
            if (a % i == 0 && a > 0)
            {
                count++;
            }
        }

        if (count > 2 || a == 1 || a < 0)
        {
            Console.WriteLine("{0} is not a prime number", a);
        }
        else
        {
            Console.WriteLine("{0} is a prime number", a);
        }
    }
}