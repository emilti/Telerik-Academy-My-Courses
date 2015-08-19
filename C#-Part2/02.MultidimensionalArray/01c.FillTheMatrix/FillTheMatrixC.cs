using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FillTheMatrixC
{
    public static void Main()
    {
        Console.WriteLine("Enter the n for a matrix(n,n):");
        int n = int.Parse(Console.ReadLine());
        int[,] matrixC = new int[n, n];
        int[,] diffs = new int[n, n - 1];
        List<int> startNumbers = new List<int>();
        startNumbers.Add(1);
        List<int> nPos = new List<int>();
        for (int i = 1; i < n; i++)
        {
            startNumbers.Add(startNumbers[i - 1] + i);           
        }

        int middle = n / 2;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (j + 1 == i || j == i)
                {
                    diffs[i, j] = n;                   
                }              
            }           
         }

        bool isChecked = false;
        bool isLeftFinished = false;
        bool isRightFinished = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (isLeftFinished == true && isRightFinished == false && diffs[i, j] == 0)
                {
                    diffs[i, j] = diffs[n - 1 - i, n - 2 - j];
                    if (i == n - 1 && j == n - 2)
                    {                        
                        isRightFinished = true;
                    }
                }

                if (isLeftFinished == false && isRightFinished == false)
                {
                    if (diffs[i, j] == n && j > 0 && diffs[i, j - 1] != n && isChecked == false)
                    {
                        nPos.Add(j);
                        j = 0;
                        isChecked = true;
                    }

                    if (isChecked == true && j < nPos[0])
                    {
                        diffs[i, j] = n - nPos[0] + j;
                    }
                    else
                    {
                        isChecked = false;
                        nPos.Clear();
                        if (i == n - 1 && j == n - 2)
                        {
                            i = 0;
                            j = 0;
                            isLeftFinished = true;
                        }
                    }
                }
            }            
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0)
                {
                    matrixC[i, j] = startNumbers[n - 1 - i];
                    Console.Write("{0,3}", matrixC[i, j]);
                }
                else
                {
                    matrixC[i, j] = matrixC[i, j - 1] + diffs[i, j - 1];
                    Console.Write("{0,3}", matrixC[i, j]);
                }
            }

            Console.WriteLine();
        }
    }
}