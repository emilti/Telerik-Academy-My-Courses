using System;

public class CatalanNumbers
{
    public static void Main()
    {
        Console.WriteLine("Enter n:");
        double factN = 1;
        double fact2n = 1;
        double factN1 = 1;
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 2 * n; i++)
        {
            fact2n = fact2n * i;
            if (i <= n + 1)
            {
                factN1 = factN1 * i;
            }

            if (i <= n)
            {
                factN = factN * i;
            }
        }

        double result = fact2n / (factN1 * factN);
        Console.WriteLine("Catalan (n)={0:F5}", result);
    }
}