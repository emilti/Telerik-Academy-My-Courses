namespace TestSorting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortingAlgorithms
    {
        public static void InsertionSort<T>(T[] inputArray) where T : IComparable<T>
        {
            for (int i = 1; i < inputArray.Length; i++)
            {
                int j = i;
                while (j > 0 && inputArray[j - 1].CompareTo(inputArray[j]) > 0)
                {
                    var swap = inputArray[j];
                    inputArray[j] = inputArray[j - 1];
                    inputArray[j - 1] = swap;
                    j = j - 1;
                }
            }
        }

        public static void SelectingSort<T>(T[] inputArray) where T : IComparable<T>
        {
            int iMin;
            for (int j = 0; j < inputArray.Length - 1; j++)
            {
                iMin = j;
                for (int i = j + 1; i < inputArray.Length; i++)
                {
                    if (inputArray[i].CompareTo(inputArray[iMin]) < 0)
                    {
                        iMin = i;
                    }
                }

                if (iMin != j)
                {
                    Swap(inputArray, j, iMin);
                }
            }
        }

        public static void Swap<T>(T[] inputArray, int j, int iMin)
        {
            T swappedValue = inputArray[j];
            inputArray[j] = inputArray[iMin];
            inputArray[iMin] = swappedValue;
        }

        public static void QuickSortRecursive<T>(T[] elements, int left, int right) where T : IComparable<T>
        {
            int i = left, j = right;
            T pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    T tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QuickSortRecursive(elements, left, j);
            }

            if (i < right)
            {
                QuickSortRecursive(elements, i, right);
            }
        }
    }
}
