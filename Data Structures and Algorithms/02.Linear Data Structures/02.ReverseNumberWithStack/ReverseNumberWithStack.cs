namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 02.Write a program that reads N integers from the console and reverses them using a stack.
    /// Use the Stack<int> class.
    /// </summary>
    public class ReverseNumberWithStack
    {
        public static void Main()
        {
            Stack<int> numbers = new Stack<int>();        
            EnterNumbers(numbers);
            PrintNumbers(numbers);
        }

        private static void PrintNumbers(Stack<int> numbers)
        {
            while (true)
            {
                int outNumber = numbers.Pop();
                if (numbers.Count > 0)
                {
                    Console.Write(outNumber + ", ");
                }
                else
                {
                    Console.Write(outNumber);
                }

                if (numbers.Count == 0)
                {
                    break;
                }
            }

            Console.WriteLine();
        }

        private static void EnterNumbers(Stack<int> numbers)
        {
            Console.WriteLine("Enter numbers:");
            while (true)
            {
                string input = Console.ReadLine();
                if (input != string.Empty)
                {
                    int parsedInput = int.Parse(input);
                    numbers.Push(parsedInput);
                }
                else
                {
                    break;
                }
            }
        }
    }
}