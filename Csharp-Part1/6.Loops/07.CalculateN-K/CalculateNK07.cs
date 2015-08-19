using System;

public class CalculateNK07
{
    public static void Main()
    {
        double factN = 1;
        double factK = 1;
        double factDiff = 1;
        Console.WriteLine("Enter n and k (N! / (K! * (N-K)!))");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());
        double diff = n - k;
        for (int i = 1; i <= n; i++)
        {
            factN = factN * i;
            if (i <= k)
            {
                factK = factK * i;
            }

            if (i <= diff)
            {
                factDiff = factDiff * i;
            }
        }

        double result = factN / (factK * factDiff);
        Console.WriteLine("{0:F5}", result);
    }
}