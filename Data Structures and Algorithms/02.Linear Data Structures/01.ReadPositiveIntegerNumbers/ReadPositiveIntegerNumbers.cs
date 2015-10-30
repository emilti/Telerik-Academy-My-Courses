namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///  01.Write a program that reads from the console a sequence of positive integer numbers.
    /// The sequence ends when empty line is entered.
    /// Calculate and print the sum and average of the elements of the sequence.
    /// Keep the sequence in List<int>.  
    /// </summary>
    public class ReadPositiveIntegerNumbers
    {
        public static void Main()
        {
            Console.WriteLine("Enter numbers:");
            List<int> numbers = new List<int>();
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

            Console.WriteLine("The sum is: {0}", sum);
            Console.WriteLine("The average is {0}: ", (double)sum / numbers.Count);
        }
    }
}
