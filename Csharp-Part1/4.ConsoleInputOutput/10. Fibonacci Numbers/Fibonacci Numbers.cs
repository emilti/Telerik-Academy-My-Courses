using System;

// Problem 10. Fibonacci Numbers
//    Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
// (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
public class FibonacciNumbers
{
    public static void Main()
    {
        Console.WriteLine("Enter the number the count of the numbers from the Fibunacci sequence :");
        int len = int.Parse(Console.ReadLine());
        int x1 = 0;
        int x2 = 1;
        int x3 = 0;
        Console.WriteLine("The numbers from the Fibunacci sequence are:");
        if (len == 1)
        {
            Console.Write("{0} ", x1);
        }
        else
        {
            Console.Write("{0} {1}", x1, x2);

            for (int i = 2; i < len; i++)
            {
                x3 = x1 + x2;
                Console.Write(" {0}", x3);
                x1 = x2;
                x2 = x3;
            }
        }
    }
}