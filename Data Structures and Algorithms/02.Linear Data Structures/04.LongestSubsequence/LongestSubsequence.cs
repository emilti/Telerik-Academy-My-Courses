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
            // numbers = new List<int> { 2, 3, -2, -2, -2, -1, -1 };
            // numbers = new List<int> { 2, 3, -2, -1};
            // numbers = new List<int> { 2 };
            // numbers = new List<int> { 2, 2, 2, 3, -2, -1, -1 };
            // EnterNumbers(numbers);
            Sequence sequence = new Sequence();
            Searcher searcher = new Searcher();
            sequence = searcher.SearchLongestSequenceOfEqualNumbers(numbers, sequence);            
            PrintSequence(sequence.EqualNumber, sequence.Length);
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
