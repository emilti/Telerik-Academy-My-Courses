namespace RefactorCsharp2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Task02c
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            long[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            List<long> diffs = FindDiffs(numbers);
            long oddSum = FindOddSum(diffs);
            Console.WriteLine(oddSum);
        }

        private static List<long> FindDiffs(long[] numbers)
        {
            List<long> diffs = new List<long>();
            int i = 1;
            long absoluteDifference = 0;
            while (i < numbers.Length)
            {
                absoluteDifference = AbsoluteCalc(numbers, i);
                diffs.Add(absoluteDifference);
                if (absoluteDifference % 2 > 0)
                {
                    i++;
                }
                else
                {
                    i += 2;
                }
            }

            return diffs;
        }

        private static long FindOddSum(List<long> diffs)
        {
            long oddSum = 0;
            for (int j = 0; j < diffs.Count; j++)
            {
                if (diffs[j] % 2 > 0)
                {
                    oddSum += diffs[j];
                }
            }

            return oddSum;
        }

        private static long AbsoluteCalc(long[] numbers, int i)
        {
            long absoluteDifference = numbers[i] > numbers[i - 1] ? numbers[i] - numbers[i - 1] : numbers[i - 1] - numbers[i];
            return absoluteDifference;
        }
    }
}