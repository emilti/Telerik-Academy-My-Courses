using System;

public class Sort3NumbersWithNestedIfs
{
    public static void Main()
    {
        Console.WriteLine("Enter three numbers");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Sorted numbers:");
        if (a >= b && a >= c)
        {
            Console.Write("{0} ", a);
            if (b >= c)
            {
                Console.Write("{0} {1}", b, c);
            }
            else
            {
                Console.Write("{0} {1}", c, b);
            }
        }
        else
        {
            if (b >= c)
            {
                Console.Write("{0} ", b);
                if (a >= c)
                {
                    Console.Write("{0} {1}", a, c);
                }
                else
                {
                    Console.Write("{0} {1}", c, a);
                }
            }
            else
            {
                Console.Write("{0} ", c);

                if (a >= b)
                {
                    Console.Write("{0} {1}", a, b);
                }
                else
                {
                    Console.Write("{0} {1}", b, a);
                }
            }
        }
    }
}