using System;
using System.Collections.Generic;

public class FillTheMatrixD
{
    public static void Main()
    {
        Console.WriteLine("Enter the n for a matrix(n,n):");
        int n = int.Parse(Console.ReadLine());
        int[,] matrixD = new int[n, n];
        bool isGoingDown = true;       
        bool isGoingRight = false;
        bool isGoingUp = false;
        bool isGoingLeft = false; 
        int isDown = 0;
        int isRight = 0;
        int isUp = 0; 
        int isLeft = 0; 
        int row = -1;
        int col = 0;
        int counter = 1;
        bool finished = false;
        while (finished == false)
        {
            while (isGoingDown == true)
            {
                row++;
                matrixD[row, col] = counter;
                if (counter == n * n)
                {
                    finished = true;
                    break;
                }

                counter++;                
                if (row == n - isRight - 1)
                {
                    isGoingDown = false;
                    isGoingRight = true;
                    isDown = isDown + 1;                   
                }
            }

            while (isGoingRight == true)
            {
                col++;
                matrixD[row, col] = counter;
                if (counter == n * n)
                {
                    finished = true;
                    break;
                }

                counter++;                
                if (col == n - isUp - 1)
                {
                    isGoingRight = false;
                    isGoingUp = true;
                    isRight = isRight + 1;                   
                }
            }

            while (isGoingUp == true)
            {
                row--;
                matrixD[row, col] = counter;
                if (counter == n * n)
                {
                    finished = true;
                    break;
                }

                counter++;
                if (row == 0 + isLeft)
                {
                    isGoingUp = false;
                    isGoingLeft = true;
                    isUp = isUp + 1;                    
                }
            }

            while (isGoingLeft == true)
            {
                col--;
                matrixD[row, col] = counter;
                if (counter == n * n)
                {
                    finished = true;
                    break;
                }

                counter++;
                if (col == 0 + isDown)
                {
                    isGoingLeft = false;
                    isGoingDown = true;
                    isLeft = isLeft + 1;
                }
            } 
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {     
                 Console.Write("{0,3}", matrixD[i, j]);              
            }

            Console.WriteLine();
        }
    }
}