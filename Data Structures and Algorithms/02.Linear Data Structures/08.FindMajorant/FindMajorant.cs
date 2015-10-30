namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///  08*.The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
    /// Write a program to find the majorant of given array (if exists).
    /// Example:
    /// {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3
    /// </summary>
    public class FindMajorant
    {
        public static void Main()
        {           
            List<int> numbers = new List<int>();

            // numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            numbers = new List<int> { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            // EnterNumbers(numbers);
            List<int> differentNumbers = new List<int>();
            List<int> countOfDifferentNumbers = new List<int>();
            FindCountOfEachNumber(numbers, differentNumbers, countOfDifferentNumbers);
            bool isPresentMajorant = false;
            for (int i = 0; i < differentNumbers.Count; i++)
            {
                if (countOfDifferentNumbers[i] > numbers.Count / 2)
                {
                    isPresentMajorant = true;
                    Console.WriteLine("The majorant is {0} --> {1} times.", differentNumbers[i], countOfDifferentNumbers[i]);
                }               
            }

            if (isPresentMajorant == false)
            {
                Console.WriteLine("There isn't a majorant.");
            }
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
