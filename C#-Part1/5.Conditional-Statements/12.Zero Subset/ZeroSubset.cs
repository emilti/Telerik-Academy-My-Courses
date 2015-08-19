using System;
using System.Collections.Generic;
using System.Linq;

public class ZeroSubset
{
    public static void Main()
    {
        Console.WriteLine("Enter 5 numebrs:");
        string input = Console.ReadLine();
        int[] arrayOfInts = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        List<int> listOfResults = new List<int>();
        int sum = 0;
        int countOfResults = 0;
        for (int i = 1; i <= 31; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                int mask = 1 << j;
                int maskAndI = mask & i;
                int bit = maskAndI >> j;
                if (bit == 1)
                {
                    listOfResults.Add(arrayOfInts[j]);
                    sum = arrayOfInts[j] + sum;                    
                }

                if (sum == 0 && j == 4)
                {
                    for (int z = 0; z < listOfResults.Count; z++)
                    {
                        Console.Write("{0} ", listOfResults[z]);
                        countOfResults++;
                    }

                    Console.WriteLine();
                }                
            }

            listOfResults.Clear();
            sum = 0;
        }

        if (countOfResults == 0)
        {
            Console.WriteLine("no zero subset");
        }
    }
}