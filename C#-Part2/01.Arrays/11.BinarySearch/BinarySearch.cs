using System;

public class BinarySearch
{
    public static void Main()
    {
        Console.WriteLine("Searched number:");
        int searchedNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Length of the array:");        
        int len = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[len];
        Console.WriteLine("Enter the array:");
        for (int i = 0; i < len; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arrayOfNumbers);
        int targetPos = -1;
        int begin = 0;
        int end = arrayOfNumbers.Length - 1;
        int mid;        
        while (begin <= end && targetPos == -1)
        {
            mid = (begin + end) / 2;
            if (arrayOfNumbers[mid] < searchedNumber)
            {
                begin = mid + 1;
                continue;
            }
            else if (arrayOfNumbers[mid] > searchedNumber)
            {
                end = mid - 1;
                continue;
            }
            else
            {
                 targetPos = mid;
            }
        }

        if (targetPos == -1)
        {
            Console.WriteLine("No value found");
        }
        else
        {
            Console.WriteLine("The number {0} is at position {1} at the sorted array.", searchedNumber, targetPos);
        }
    }
}