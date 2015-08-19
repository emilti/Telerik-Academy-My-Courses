using System;

public class CalculateNK
{
    public static void Main()
    {
        double factN = 1;
        double factK = 1;
        Console.WriteLine("Enter two numbers n and k :");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());
        int max = n > k ? n : k;
        for (int i = 1; i <= max; i++)
        {
            if (i <= n)
            {
                factN = factN * i;
            }

            if (i <= k)
            {
                factK = factK * i;
            }
        }

        double result = factN / factK;
        Console.WriteLine("n! / k!= {0:F5}", result);
    }
}