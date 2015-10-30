namespace LinearDataStrucures
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 06.Write a program that removes from given sequence all numbers that occur odd number of times.
    // Example:
    // {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
    /// </summary>
    public class RemoveNumbersOccurringOddNumberOfTimes
    {
        public static void Main()
        {          
            List<int> numbers = new List<int>();

            // numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };             
            // numbers = new List<int> { 2, 3, -2, -1, -1 };
            EnterNumbers(numbers);
            RemoveNumbers(numbers);

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void RemoveNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int count = 0;
                int number = numbers[i];
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (number == numbers[j])
                    {
                        count++;
                    }
                }

                if (count % 2 == 1)
                {
                    for (int k = 0; k < numbers.Count; k++)
                    {
                        if (numbers[k] == number)
                        {
                            numbers.RemoveAt(k);
                            if (i == k)
                            {
                                i--;
                            }

                            k--;                            
                        }
                    }
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
