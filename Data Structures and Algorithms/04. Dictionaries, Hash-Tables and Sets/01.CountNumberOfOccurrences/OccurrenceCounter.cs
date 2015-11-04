namespace DataStructuresHomework
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Write a program that counts in a given array of double values the number of occurrences of each value. Use Dictionary<TKey,TValue>.
    /// Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
    /// -2.5 -> 2 times
    /// 3 -> 4 times
    /// 4 -> 3 times
    /// </summary>
    public class OccurrenceCounter
    {
        public static void Main()
        {
            double[] numbers = new[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Dictionary<double, int> countOfValues = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (countOfValues.ContainsKey(numbers[i]))
                {
                    countOfValues[numbers[i]] = countOfValues[numbers[i]] + 1;
                }
                else
                {
                    countOfValues.Add(numbers[i], 1);
                }
            }

            foreach (var key in countOfValues.Keys)
            {
                Console.WriteLine(key + "-->" + countOfValues[key]);
            }
        }
    }
}
