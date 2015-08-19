using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FillTheMatrixB
{
    public static void Main()
    {
        int count = 1;
        Console.WriteLine("Enter the n for matrix(n,n):");
        int n = int.Parse(Console.ReadLine());
        int[,] matrixB = new int[n, n];
        int[] diffs = new int[n - 1];
        for (int m = 0; m < diffs.Length; m++)
        {
            diffs[m] = m % 2 == 0 ? (2 * n) - 1 : 1;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0)
                {
                    matrixB[i, j] = count;
                    count++;
                }
                else
                {
                    matrixB[i, j] = matrixB[i, j - 1] + diffs[j - 1];                    
                }

                if (j > 0 && j < n)
                {
                    diffs[j - 1] = (j - 1) % 2 == 0 ? diffs[j - 1] - 2 : diffs[j - 1] + 2;
                }

                Console.Write("{0,3}", matrixB[i, j]);
            }

            Console.WriteLine();
        }
    }
}
