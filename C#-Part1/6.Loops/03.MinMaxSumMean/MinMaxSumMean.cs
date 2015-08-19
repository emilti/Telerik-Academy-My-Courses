using System;

public class MinMaxSumMean
{
    public static void Main()
    {
        int sum = 0;
        int min = 0;
        int max = 0;
        Console.WriteLine("Enter number");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the sequence of n numbers");
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            sum += a;
            if (i == 0)
            {
                min = a;
            }

            if (min > a)
            {
                min = a;
            }

            if (i == 0)
            {
                max = a;
            }

            if (max < a)
            {
                max = a;
            }
        }

        double avg = (double)sum / n;
        Console.WriteLine("min={0}", min);
        Console.WriteLine("max={0}", max);
        Console.WriteLine("sum={0}", sum);
        Console.WriteLine("avg={0:F2}", avg);
    }
}