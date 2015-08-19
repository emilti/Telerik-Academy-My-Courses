using System;
using System.Collections.Generic;

public class MaxIncreasingSequence
{
    public static void Main()
    {
        // For thorough check you can comment the row below and uncomment the row which have //* above them
        int[] numbers = { 3, 2, 3, 4, 2, 2, 4 };
        
        // int[] numbers = { 3, 2, 3, 4,5, 2, 2, 4,5,6,7 };
        int len = numbers.Length;
        
        // *
        // Console.WriteLine("Enter the lenght of the array:");
        // int len = int.Parse(Console.ReadLine());         
        // Console.WriteLine("Enter the lenght of the array:");
        // int len = int.Parse(Console.ReadLine());   
        // int[] numbers = new int[len];
        int diff = 0;
        int maxDiff = 0;
        int increasingElementsStart = 0;
        int increasingElementsEnd = 0;
        for (int index = 0; index < len; index++)
        {          
            // numbers[index] = int.Parse(Console.ReadLine());
            if (index > 0 && numbers[index] > numbers[index - 1])
            {
                diff++;
            }

            if ((diff > maxDiff && numbers[index] <= numbers[index - 1]) || (diff > maxDiff && index == len - 1))
            {
                int beforeEnd = numbers[index] <= numbers[index - 1] ? 1 : 0;
                increasingElementsStart = index - diff - beforeEnd;
                increasingElementsEnd = index - beforeEnd;
                maxDiff = diff;
                diff = 0;
            }

            if (diff > 0 && numbers[index] <= numbers[index - 1])
            {
                diff = 0;
            }                      
        }

        Console.WriteLine("The maximal increasing sequence in the array is:");
        for (int counter = increasingElementsStart; counter <= increasingElementsEnd; counter++)
        {
            if (counter < increasingElementsEnd)
            {
                Console.Write("{0}, ", numbers[counter]);
            }
            else
            {
                Console.WriteLine("{0}", numbers[counter]);
            }
        }
    }
}