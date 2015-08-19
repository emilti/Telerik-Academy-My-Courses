using System;
using System.Collections.Generic;

public class MaxSumInArray
{
    public static void Main()
    {
        // For check you can comment the row below and comment the row which have //* above them
        // TESTS:
        int[] arrayOfNumbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        // int[] arrayOfNumbers = { -1, -3, -6, -1, -2, -1, -3, -4, -8, -8 };
        // int[] arrayOfNumbers = { 2, 3, -6, -1, 2, -12, 6, 4, -8, 8 };
        // int[] arrayOfNumbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8,22 };
        int len = 10;

        // *
        // Console.WriteLine("Enter the array length:");
        // int len = int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter the array:");
        // *ALL until the next //*
        // int[] arrayOfNumbers = new int[len];       
        // for (int index = 0; index < len; index++)
        // {
        //     arrayOfNumbers[index] = int.Parse(Console.ReadLine());
        // }
        // *
        int sum = 0;
        int maxSum = int.MinValue;
        int tempCount = 0;
        int posStartCounter = 0;
        int tempPosStartCounter = 0;
        int posEndCounter = 0;
        bool isPreviousOne = false;
        double binaryTop = Math.Pow(2, len) - 1;
        for (int i = 0; i <= binaryTop; i++)
        {
            for (int j = 0; j < len; j++)
            {
                int mask = 1 << j;
                int maskAndI = mask & i;
                int bit = maskAndI >> j;
                if (bit == 1)
                {
                    if (isPreviousOne == false)
                    {
                        tempPosStartCounter = j;     
                    }

                    isPreviousOne = true;                                
                    sum = arrayOfNumbers[j] + sum;
                    if (sum > maxSum)
                    {
                        posStartCounter = tempPosStartCounter;
                        posEndCounter = tempCount + posStartCounter;
                        maxSum = sum;
                    }

                    tempCount++;
                }  
             
                if ((bit == 0 && isPreviousOne == true) || j == len - 1)
                {
                    isPreviousOne = false;
                    break;
                }
            }

            tempCount = 0;            
            sum = 0;
        }   
    
        for (int i = posStartCounter; i <= posEndCounter; i++)
        {
            Console.Write("{0}  ", arrayOfNumbers[i]);           
        }

        Console.WriteLine("Max sum={0}", maxSum);
    }
}