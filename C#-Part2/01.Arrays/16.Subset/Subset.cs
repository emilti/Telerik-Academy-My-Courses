using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Subset
{
    public static void Main()
    {
        // For quick check you can uncomment the row below and comment the row which have //* above them
        // int[] arrayOfNumbers = { 2, 1, 2, 4, 3, 5, 2, 6 };
        Console.WriteLine("Enter number S:");
        int numberS = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of the array");
        int len = int.Parse(Console.ReadLine());

        // *
        int[] arrayOfNumbers = new int[len];
        List<int> listOfResults = new List<int>();
        int sum = 0;
        bool isFirst = true;       
        int countOfResults = 0;
        Console.WriteLine("Enter the array");

        // *Comment All until the next//*
        for (int i = 0; i < len; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }

        // *
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
                    listOfResults.Add(arrayOfNumbers[j]);
                    sum = arrayOfNumbers[j] + sum;
                }               
            }

            if (sum == numberS)
            {
                if (isFirst)
                {
                    Console.WriteLine("Yes");
                    isFirst = false;
                }

                for (int z = 0; z < listOfResults.Count; z++)
                {
                    Console.Write("{0} ", listOfResults[z]);
                    countOfResults++;
                }

                if (countOfResults > 0)
                {
                    Console.WriteLine();
                }
            }   
        
            listOfResults.Clear();
            sum = 0;
        }

        if (countOfResults == 0)
        {
            Console.WriteLine("No");
        }
    }
}