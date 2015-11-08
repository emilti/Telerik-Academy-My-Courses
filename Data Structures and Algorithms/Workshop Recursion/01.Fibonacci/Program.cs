using System;

public class RecursiveFibonacciMemoization
{
    public const int MOD = 1000000007;

    private static int[] memo;

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        memo = new int[n + 1];
        Console.WriteLine(Fibbonacci(n));
    }

    public static int Fibbonacci(int n)
    {
        if (memo[n] != 0)
        {
            return memo[n];
        }

        if (n == 1 || n == 2)
        {
            return 1;
        }

        int number = Fibbonacci(n - 1) + Fibbonacci(n - 2);
        number %= MOD;
        memo[n] = number;
        return number;
    }
}