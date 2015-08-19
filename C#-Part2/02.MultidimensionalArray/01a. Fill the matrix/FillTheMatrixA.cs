using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FillTheMatrixA
{
    public static void Main()
    {
       Console.WriteLine("Enter the n for a matrix(n,n):");
       int n = int.Parse(Console.ReadLine());
       int[,] matrixA = new int[n, n];
       for (int i = 0; i < n; i++)
       {
           for (int j = 0; j < n; j++)
           {
               matrixA[i, j] = i + 1 + (n * j);
               Console.Write("{0,3}", matrixA[i, j]);
           }

           Console.WriteLine();
       }

       Console.WriteLine();        
    }
}