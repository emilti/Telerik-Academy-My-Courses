using System;
using System.Collections.Generic;

public class SumInArray
{
    public static void Main()
    {
        // For thorough check you can comment the row below and uncomment the row which have //* above them
        int[] arrayOfNumbers = { 4, 3, 1, 4, 2, 5, 8 };

        // int[] arrayOfNumbers = { 4, 3, 1, 4, 2, 4, -12,10,1 };
        int sum = 11;
        
        // *coment ALL until the next for THOROUGH check//*       
        // Console.WriteLine("Sum S:");
        // int sum = int.Parse(Console.ReadLine());
        // Console.WriteLine("Length of the array:");
        // int len = int.Parse(Console.ReadLine());
        // int[] arrayOfNumbers = new int[len];
        // for (int i = 0; i < len; i++)
        // {
        //     arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        // }
        // *
        int setStart = 0;
        int setEnd = 0;
        int checkingSum = 0;
        int diff = 0;
        int start = 0;
        bool isApparent = false;
        for (int k = start; k < arrayOfNumbers.Length; k++)
        {
            diff++;
            checkingSum = arrayOfNumbers[k] + checkingSum;
            if (checkingSum == sum)
            {
                setStart = k - diff + 1;
                setEnd = k;
                isApparent = true;
            }

            if (checkingSum > sum)
            {
                start++;
                k = start - 1;
                diff = 0;
                checkingSum = 0;
            }

            if (checkingSum < sum && start <= arrayOfNumbers.Length - 1 && k == arrayOfNumbers.Length - 1)
            {
                start++;
                k = start - 1;
                diff = 0;
                checkingSum = 0;
            }
        }

        if (isApparent)
        {
            Console.WriteLine("The sequence of elements in the array equal to S is:");

            for (int counter = setStart; counter <= setEnd; counter++)
            {
                if (counter < setEnd)
                {
                    Console.Write("{0}, ", arrayOfNumbers[counter]);
                }
                else
                {
                    Console.WriteLine("{0}", arrayOfNumbers[counter]);
                }
            }
        }
        else
        {
            Console.WriteLine("There isn't sequence equal to S in the given array.");
        }
    }
}
