using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SortingArray
{
    public static void Main()
    {
        // *Zero tests
        // int[] arrayOfInts = { 2, 4, -5, -1, 2, 4, -5, 6 };
        int[] arrayOfInts = { 3, 4, 5, 7, 12, 14, 15, 15 }; 
       
        // int[] arrayOfInts = { 2, 1, -5, -1, 2, 4, -5, 6 };
        // For manual entering you can uncomment this code:
        // Console.WriteLine("Enter the length of the array:");
        // int len=int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter the array:");
        // int[] arrayOfInts=new int[len];
        // for (int i=0;i<len;i++)
        // {
        //     arrayOfInts[i] = int.Parse(Console.ReadLine());
        // }      
        Console.WriteLine("Enter start index:");
        int startIndex = int.Parse(Console.ReadLine());
        bool isBig = true;
        while (isBig)
        {
            if (startIndex >= arrayOfInts.Length)
            {
                Console.WriteLine("The index is bigger than the length of the array. Please enter new index again.");
                startIndex = int.Parse(Console.ReadLine());
            }
            else
            {
                isBig = false;
            }           
        }

        int maxNumber = CheckForBiggestNumber(arrayOfInts, startIndex);
        Console.WriteLine("The maximal number in the portion of the array");
        Console.WriteLine("started from {0} is {1}.", startIndex, maxNumber);
    }

    public static int CheckForBiggestNumber(int[] arrayOfInts, int startIndex)
    {
        int maxValue = int.MinValue;
        for (int i = startIndex; i < arrayOfInts.Length; i++)
        {
            if (arrayOfInts[i] > maxValue)
            {
                maxValue = arrayOfInts[i];
            }
        }

        return maxValue;
    }
}