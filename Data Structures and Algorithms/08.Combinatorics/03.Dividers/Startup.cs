namespace Dividers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Startup
    {
        private static List<long> numbers = new List<long>();
        private static List<int> counts = new List<int>();

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] initialNumbers = new int[number];
            for (int i = 0; i < number; i++)
            {
                initialNumbers[i] = int.Parse(Console.ReadLine());
            }

            GeneratePermutations(initialNumbers, 0);
            int minValue = int.MaxValue;
            int minIndex = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (counts[i] < minValue)
                {
                    minValue = counts[i];
                    minIndex = i;
                }
                else if (counts[i] == minValue)
                {
                    if (numbers[i] < numbers[minIndex])
                    {
                        minIndex = i;
                    }
                }
            }

            Console.WriteLine(numbers[minIndex]);
        }

        public static void GeneratePermutations<T>(T[] arr, int k)
        {
            if (k >= arr.Length)
            {
                // Print(arr);
                ConvertIntArrayToNumber(arr);
            }
            else
            {
                GeneratePermutations(arr, k + 1);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    GeneratePermutations(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        private static void ConvertIntArrayToNumber<T>(T[] arr)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < arr.Length; j++)
            {
                sb.Append(arr[j].ToString());
            }

            int number = int.Parse(sb.ToString());
            numbers.Add(number);

            int currentCount = 0;
            double divided = numbers[numbers.Count - 1] / 2;
            int bound = (int)divided;
            for (int i = 1; i <= bound; i++)
            {
                if (numbers[numbers.Count - 1] % i == 0)
                {
                    currentCount++;
                }
            }

            counts.Add(currentCount);
        }

        private static void Print<T>(T[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        private static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}
