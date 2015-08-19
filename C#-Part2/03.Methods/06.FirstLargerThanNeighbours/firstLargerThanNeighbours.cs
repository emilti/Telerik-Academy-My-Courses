using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FirstLargerThanNeighbours
{
    public static void Main()
    {
        // *Zero tests
        int[] arrayOfInts = { 2, 4, -5, -1, 2, 4, -5, 6 };

        // int[] arrayOfInts = { 3, 4, 5, 7, 12, 14, 15, 15 };        
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
        int firstBiggerIndex = CheckPosition(arrayOfInts);
        Console.WriteLine("The index of the first number bigger than its neighbouring numbers is:");
        Console.WriteLine("{0}", firstBiggerIndex);
    }

    public static int CheckPosition(int[] array)
    {
        int firstBigger = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0 && (array[i + 1] < array[i]))
            {
                firstBigger = i;
                break;
            }
            else if (i > 0 && i < array.Length - 1 && array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                firstBigger = i;
                break;
            }
            else if (i == array.Length - 1 && (array[i - 1] < array[i]))
            {
                firstBigger = i;
                break;
            }
        }

        return firstBigger;
    }
}