using System;
using System.Diagnostics;
using System.Linq;

public class AssertionsHomework
{
    public static void Main()
    {
        // char[] arr2 = new char[0];
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);

        // SelectionSort(arr2);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }

    // Add precondition - assert whether passed array is empty
    // Add precondition - assert whether all members of the array are numbers
    // Add postcondition - assert whether the the received array is sorted ascending
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array should not be empty!");
        bool isArrayOfNumbers = Array.TrueForAll(arr, CheckForNumbers);
        Debug.Assert(isArrayOfNumbers, "All members of the array should be numbers!");
        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        CheckForAsceindingSort<T>(arr);
    }

    // Add precondition - assert whether the array is sorted ascending
    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        CheckForAsceindingSort(arr);
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static void CheckForAsceindingSort<T>(T[] arr) where T : IComparable<T>
    {
        bool isSorted = true;
        for (int checkIndex = 1; checkIndex < arr.Length - 1; checkIndex++)
        {
            if (arr[checkIndex - 1].CompareTo(arr[checkIndex]) > 0)
            {
                isSorted = false;
                break;
            }
        }

        Debug.Assert(isSorted, "The array is not sorted ascending");
    }

    private static bool CheckForNumbers<T>(T value)
    {
        int s;
        return int.TryParse(value.ToString(), out s);
    }

    // Add precondtion - assert whether the startIndex is positive    
    // Add precondtion - assert whether the startIndex value is less than the array length
    // Add precondtion - assert whether the endIndex is positive    
    // Add precondtion - assert whether the endIndex value is less than the array length
    // Add precondition - assert whether the startIndex is smaller than the endIndex
    // Add postcondition - assert whether the found element is indeed the smallest one
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        CheckForIndecesArrangement(startIndex, endIndex, arr);
        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }
        
        for (int i = startIndex + 1; i < endIndex; i++)
        {
            Debug.Assert(arr[minElementIndex].CompareTo(arr[i]) <= 0, "The element" + arr[minElementIndex] + " is not the smallest!");
        }

        return minElementIndex;
    }

    private static void CheckForIndecesArrangement<T>(int startIndex, int endIndex, T[] arr)
    {
        Debug.Assert(startIndex >= 0, "Start index should be positive");
        Debug.Assert(startIndex < arr.Length, "Start index should be smaller than the length of the array");
        Debug.Assert(endIndex >= 0, "End index should be positive");
        Debug.Assert(endIndex < arr.Length, "End index should be smaller than the length of the array");
        bool isStartIndexSmallerOrEqualThanEndIndex = startIndex <= endIndex;
        Debug.Assert(isStartIndexSmallerOrEqualThanEndIndex, "Start index should be smaller than end index!");
    }    
   
    // Add precondtion - assert whether the startIndex is positive    
    // Add precondtion - assert whether the startIndex value is less than the array length
    // Add precondtion - assert whether the endIndex is positive    
    // Add precondtion - assert whether the endIndex value is less than the array length
    // Add precondition - assert whether the startIndex is smaller than the endIndex
    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        CheckForIndecesArrangement(startIndex, endIndex, arr);
        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }    
}
