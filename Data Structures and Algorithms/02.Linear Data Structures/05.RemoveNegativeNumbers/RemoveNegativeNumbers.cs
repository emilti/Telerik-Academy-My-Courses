
namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 05.Write a program that removes from given sequence all negative numbers.
    /// </summary>
    public class RemoveNegativeNumbers
    {
        public static void Main()
        {         
            List<int> numbers = new List<int>();
            numbers = new List<int> { 2, -2, 1, -1, -1 };
            
            // EnterNumbers(numbers);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {                    
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine("Sequence with removed negative:");
            Console.WriteLine(string.Join(", ", numbers));        
        }

        private static void EnterNumbers(List<int> numbers)
        {
            Console.WriteLine("Enter numbers:");
            int sum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input != string.Empty)
                {
                    int parsedInput = int.Parse(input);
                    numbers.Add(parsedInput);
                    sum += parsedInput;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
