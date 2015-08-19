using System;

// Problem 9. Exchange Variable Values
//
//    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//    Print the variable values before and after the exchange.
public class ExchangeVariableValues
{
    public static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before change {0}", a);
        Console.WriteLine("Before change {0}", b);
        int newA = b;
        int newB = a;
        a = newA;
        b = newB;
        Console.WriteLine("After change {0}", a);
        Console.WriteLine("After change {0}", b);
    }
}