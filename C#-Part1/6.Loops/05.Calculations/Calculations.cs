using System;

public class Calculations
{
    public static void Main()
    {
        double factI = 1;
        double calc = 0;
        double sum = 0;
        double finalSum = 0;
        Console.WriteLine("Enter two integers n and x (S = 1 + 1!/x + 2!/x2 + … + n!/x^n)");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x=");
        int x = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            factI = factI * i;
            calc = Math.Pow(x, i);
            sum = factI / calc;
            finalSum = sum + finalSum;
        }

        double result = finalSum + 1;
        Console.WriteLine("S={0:F5}", result);
    }
}