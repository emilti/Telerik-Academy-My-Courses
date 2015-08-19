using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LargestThanNeighbours
{
    public static void Main()
    {
        // *Zero tests
        // int[] arrayOfInts = { 2, 4, 5, 1, 2, 4, 5, 6 };        
        int[] arrayOfInts = { 2, 4, -5, -1, 2, 4, -5, 6 };

        // For manual entering you can uncomment this code:
        // Console.WriteLine("Enter the length of the array:");
        // int len=int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter the array:");
        // int[] arrayOfInts=new int[len];
        // for (int i=0;i<len;i++)
        // {
        //     arrayOfInts[i] = int.Parse(Console.ReadLine());
        // }
        bool invalid = true;
        int position = 0;
        Console.WriteLine("Enter the checked position:");      
        while (invalid)
        {           
            position = int.Parse(Console.ReadLine());
            invalid = CheckForValidPosition(arrayOfInts, position);
            if (invalid == true)
            {
                Console.WriteLine("Not a valid position in the array. Please try again:");
            }
        }

        bool isBigger = CheckPosition(arrayOfInts, position);
        if (isBigger == true)
        {
            Console.WriteLine("The number {0} at position {1} is bigger than its neighbouring numbers in the array.", arrayOfInts[position], position);
        }
        else
        {
            Console.WriteLine("The number {0} at position {1} is NOT bigger than its neighbouring numbers in the array.", arrayOfInts[position], position);
        }
    }

    public static bool CheckPosition(int[] array, int pos)
    {
        bool checkedArray;
        if (pos == array.Length - 1)
        {          
             checkedArray = array[pos] > array[pos - 1];           
        }
        else if (pos == 0)
        {
             checkedArray = array[pos] > array[1];          
        }
        else 
        {
            checkedArray = array[pos - 1] < array[pos] && array[pos + 1] < array[pos];
        }

        return checkedArray;       
    }

    public static bool CheckForValidPosition(int[] array, int pos)
    {
        bool invalid;
        if (pos < 0 || array.Length - 1 < pos)
        {
            invalid = true;
           return invalid;
        }
        else
        {
            invalid = false;
            return invalid;
        }
    }
}