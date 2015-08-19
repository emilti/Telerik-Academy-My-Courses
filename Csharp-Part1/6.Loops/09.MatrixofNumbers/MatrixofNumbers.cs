using System;

public class MatrixofNumbers
{
    public static void Main()
    {
        int result = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result = i + j;
                Console.Write(result);
                if (j == n - 1)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}