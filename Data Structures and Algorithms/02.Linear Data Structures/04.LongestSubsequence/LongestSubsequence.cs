

namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 04.Write a method that finds the longest subsequence of equal numbers in given List and
    /// returns the result as new List<int>.
    /// Write a program to test whether the method works correctly.
    /// </summary>
    public class LongestSubsequence
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();
            numbers = new List<int> { 2, 3, -2, -1, -1 };

            // EnterNumbers(numbers);
            int equalNumber;
            int maxLength;
            SearchLongestSequenceOfEqualNumbers(numbers, out equalNumber, out maxLength);
            PrintSequence(equalNumber, maxLength);
        }

        private static void PrintSequence(int equalNumber, int maxLength)
        {
            for (int i = 0; i < maxLength; i++)
            {
                if (i < maxLength - 1)
                {
                    Console.Write(equalNumber + ", ");
                }
                else
                {
                    Console.Write(equalNumber);
                }
            }

            Console.WriteLine();
        }

        private static void SearchLongestSequenceOfEqualNumbers(List<int> numbers, out int equalNumber, out int maxLength)
        {
            int length = 1;
            int number = numbers[0];
            equalNumber = numbers[0];
            maxLength = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    length++;
                }

                if (numbers[i] != numbers[i - 1] && length > 0)
                {
                    maxLength = length;
                    equalNumber = numbers[i - 1];
                    length = 1;
                }

                if (length >= maxLength &&
                    numbers[i] == numbers[i - 1] &&
                    i == numbers.Count - 1)
                {
                    equalNumber = numbers[i];
                    maxLength = length;
                    length = 1;
                }
            }
        }

        private static void EnterNumbers(List<int> numbers)
        {
            Console.WriteLine("Enter numbers:");
            while (true)
            {
                string input = Console.ReadLine();
                if (input != string.Empty)
                {
                    int parsedInput = int.Parse(input);
                    numbers.Add(parsedInput);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
