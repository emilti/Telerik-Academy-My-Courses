using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class QuickSortAlgorithm
{
    public static void Main(string[] args)
    {
        var input = new int[] { 12, 23, -20, 5, 200 };
        QuickSort(0, 0, input.Length - 1, input);
        Console.WriteLine("Sorted output: :");
        new List<int>(input).ForEach(x => Console.Write(x + ","));
        Console.ReadLine();
    } 

    public static void QuickSort(int pivotIndex, int startIndex, int endIndex, int[] numbers)
    {
        if (startIndex == endIndex)
        {
            return;
        }

        int pivotNumber = numbers[pivotIndex];
        var lowerThanPivot = new List<int>();
        var higherThanPivot = new List<int>();

        for (int i = startIndex; i <= endIndex; i++)
        {
            if (i != pivotIndex)
            {
                if (numbers[i] <= pivotNumber)
                {
                    lowerThanPivot.Add(numbers[i]);
                }
                else
                {
                    higherThanPivot.Add(numbers[i]);
                }
            }
        }

        // put the pivot number in the correct place
        numbers[startIndex + lowerThanPivot.Count] = pivotNumber;

        // reinsert the numbers lower than pivot in the right place
        int z = startIndex;
        lowerThanPivot.ForEach(x => numbers[z++] = x);
        z++; // *** skip over the new pivot index ***

        // reinsert the numbers higher than pivot in the right place
        higherThanPivot.ForEach(x => numbers[z++] = x);

        // recursively call to sort each remaining elements
        int newLeftPivot = startIndex;
        int newEndLeftIndex = newLeftPivot + lowerThanPivot.Count - 1;

        int newRightPivot = lowerThanPivot.Count + 1;
        int newEndRightIndex = newRightPivot + higherThanPivot.Count - 1;

        if (lowerThanPivot.Count > 0)
        {
            QuickSort(newLeftPivot, newLeftPivot, newEndLeftIndex, numbers);
        }

        if (higherThanPivot.Count > 0)
        {
            QuickSort(newRightPivot, newRightPivot, newEndRightIndex, numbers);
        }
    }
}