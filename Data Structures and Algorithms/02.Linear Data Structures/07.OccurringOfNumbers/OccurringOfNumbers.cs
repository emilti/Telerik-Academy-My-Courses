namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 07.Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
    /// Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
    /// 2 → 2 times
    /// 3 → 4 times
    /// 4 → 3 times
    /// </summary>
    public class OccurringOfNumbers
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();

            // numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            numbers = new List<int> { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            // EnterNumbers(numbers);
            List<int> differentNumbers = new List<int>();
            List<int> countOfDifferentNumbers = new List<int>();
            FindCountOfEachNumber(numbers, differentNumbers, countOfDifferentNumbers);

            Print(differentNumbers, countOfDifferentNumbers);
        }

        private static void FindCountOfEachNumber(List<int> numbers, List<int> differentNumbers, List<int> countOfDifferentNumbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (differentNumbers.IndexOf(numbers[i]) == -1)
                {
                    differentNumbers.Add(numbers[i]);
                    int count = 0;
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (numbers[j] == numbers[i])
                        {
                            count++;
                        }
                    }

                    countOfDifferentNumbers.Add(count);
                }
            }
        }

        private static void Print(List<int> differentNumbers, List<int> countOfDifferentNumbers)
        {
            for (int k = 0; k < differentNumbers.Count; k++)
            {
                Console.WriteLine("{0} --> {1}", differentNumbers[k], countOfDifferentNumbers[k]);
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
