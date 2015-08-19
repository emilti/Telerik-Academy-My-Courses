using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MaxSum
{
    public static void Main()
    {
        // int numberN = int.Parse(Console.ReadLine());
        // int numberM = int.Parse(Console.ReadLine());
       int numberN = 4;
       int numberM = 4;
       int[,] matrix = new int[,]
       {
           { 2, 1, 4, -7 },
           { 3, 6, 9, -4 },
           { 5, 4, 2, -12 },
           { 12, 12, 12, -4 }
       };

       // int[,] matrix = new int[,]
       // {
       //     {2,1,4,-7,1},
       //     {3,6,9,-4,44},
       //     {5,4,2,-12,55},
       //     {12,12,12,-4,55}
       // };          
        int sum = int.MinValue;
        int maxSum = int.MinValue;

        // for (int i = 0; i < numberN; i++)
        // {
        //     for (int j = 0; j < numberM; j++)
        //     {
        //         matrix[i, j] = int.Parse(Console.ReadLine());
        //         //Console.Write("{0,3} ",matrix[i, j]);
        //     }
        //    // Console.WriteLine();
        // }
        for (int i = 0; i < numberN; i++)
        {
            for (int j = 0; j < numberM; j++)
            {              
                Console.Write("{0,3} ", matrix[i, j]);
            }

            Console.WriteLine();
        }

        int indexI = 0;
        int indexJ = 0;
        for (int i = 0; i < numberN; i++)
        {
            for (int j = 0; j < numberM; j++)
            {
                if (i < matrix.GetLength(0) - 2 && j  < matrix.GetLength(1) - 2)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                        matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                        matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        indexI = i;
                        indexJ = j;
                        sum = 0;
                    }
                }
            }
        }

        Print(indexI, indexJ, matrix);
        Console.WriteLine("Max sum={0}", maxSum);
    }

    public static void Print(int i, int j, int[,] matrixCopy)
    {
        int[,] maxPlatform = new int[3, 3];
        int startI = i;
        int startJ = j;
        Console.WriteLine("The 3x3 max platform:");
        for (int m = 0; m < 3; m++)
        {
            for (int n = 0; n < 3; n++)
            {
                maxPlatform[m, n] = matrixCopy[startI, startJ];                
                startJ++;
                Console.Write("{0,3}", maxPlatform[m, n]);
            }

            startI++;
            startJ = j;
            Console.WriteLine();
        } 
    }
}