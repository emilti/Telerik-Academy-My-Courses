using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MaxSequence
{
    public static void Main()
    {
        // For other check you can comment the row below and uncomment the row which have //* above them
        int[] numbers = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 2, 2, 2 };    
    
        // int[] numbers = { 2, 1, 1,  3, 2, 2, 2, 1, 2, 2, 2,2,2 };        
        int len = 13;     
   
        // *
        // Console.WriteLine("Enter the lenght of the array:");
        // int len = int.Parse(Console.ReadLine());
        // int[] numbers = new int[len];
        int equalElementsStart = 0;
        int equalElementsEnd = 0;
        int diff = 0;
        int maxDiff = 0;
        for (int index = 0; index < len; index++)
        {          
            // numbers[index] = int.Parse(Console.ReadLine());
            if (index > 0 && numbers[index] == numbers[index - 1])
            {
                diff++;
            }

            if ((diff > maxDiff && numbers[index] != numbers[index - 1]) || (diff > maxDiff && index == len - 1))
            {
                int beforeEnd = numbers[index] != numbers[index - 1] ? 1 : 0;
                equalElementsStart = index - diff - beforeEnd;
                equalElementsEnd = index - beforeEnd;
                maxDiff = diff;
                diff = 0;
            }

            if (diff > 0 && numbers[index] != numbers[index - 1])
            {
                diff = 0;
            }
        }

        Console.WriteLine("The maximal sequence of equal elements in the array is:");
        for (int counter = equalElementsStart; counter <= equalElementsEnd; counter++)
        {
            if (counter < equalElementsEnd)
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