using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SortingArrayB
{
    public static void Main()
    {
        // *Zero tests
        int[] integers = { 2, 4, -5, -1, 2, 4, -5, 6 };

        // int[] integers = { 3, 4, 5, 7, 12, 14, 15, 15 };
        // int[] integers = { 2, 1, -5, -1, 2, 4, -5, 6 };
        // For manual entering you can uncomment this code:
        // Console.WriteLine("Enter the length of the array:");
        // int len=int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter the array:");
        // int[] integers=new int[len];
        // for (int i=0;i<len;i++)
        // {
        //     integers[i] = int.Parse(Console.ReadLine());
        // }  
        int[] intsClone = integers.Clone() as int[];
        int[] sortedArrayDescending = SortDescending(integers);
        int[] sortedArrayAscending = SortAscending(intsClone);
        Console.WriteLine("Sorted array:");
        Console.WriteLine("{0}", string.Join(", ", sortedArrayDescending));
        Console.WriteLine("{0}", string.Join(", ", sortedArrayAscending));
    }

    public static int[] SortDescending(int[] arrayOfIntsDesc)
    {
        int start = 0;
        int maxValueIndex = 0;
        int maxValue = int.MinValue;        
        for (int i = 0; i < arrayOfIntsDesc.Length; i++)
        {
            for (int j = start; j < arrayOfIntsDesc.Length; j++)
            {
                if (arrayOfIntsDesc[j] > maxValue)
                {
                    maxValue = arrayOfIntsDesc[j];
                    maxValueIndex = j;
                }

                if (j == arrayOfIntsDesc.Length - 1)
                {
                    int temp = arrayOfIntsDesc[i];
                    arrayOfIntsDesc[i] = maxValue;
                    arrayOfIntsDesc[maxValueIndex] = temp;
                    maxValue = int.MinValue;
                    start++;
                }
            }
        }

        return arrayOfIntsDesc;
    }

    public static int[] SortAscending(int[] arrayOfIntsAsc)
    {
        int start = 0;
        int minValueIndex = 0;
        int minValue = int.MaxValue;
        for (int i = 0; i < arrayOfIntsAsc.Length; i++)
        {
            for (int j = start; j < arrayOfIntsAsc.Length; j++)
            {
                if (arrayOfIntsAsc[j] < minValue)
                {
                    minValue = arrayOfIntsAsc[j];
                    minValueIndex = j;
                }

                if (j == arrayOfIntsAsc.Length - 1)
                {
                    int temp = arrayOfIntsAsc[i];
                    arrayOfIntsAsc[i] = minValue;
                    arrayOfIntsAsc[minValueIndex] = temp;
                    minValue = int.MaxValue;
                    start++;
                }
            }
        }

        return arrayOfIntsAsc;
    }
}
