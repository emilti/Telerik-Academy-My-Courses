namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 10.We are given numbers N and M and the following operations:
    /// N = N+1
    /// N = N+2
    /// N = N*2// 
    /// Write a program that finds the shortest sequence of operations from the list
    /// above that starts from N and finishes in M.
    /// Hint: use a queue.
    /// Example: N = 5, M = 16
    /// Sequence: 5 → 7 → 8 → 16 
    /// </summary>
    public class OperationsSequence
    {
        public static void Main()
        {
            int numberN;
            int numberM;
            EnterNumbers(out numberN, out numberM);
            Queue<int> numbers = new Queue<int>();
            int currentNumber = numberM;
            currentNumber = TransformMToN(numberN, numbers, currentNumber);

            Console.WriteLine("Count of operations to trnasform N to M: {0}", numbers.Count);
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void EnterNumbers(out int numberN, out int numberM)
        {
            Console.WriteLine("Enter N:");
            numberN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter M:");
            numberM = int.Parse(Console.ReadLine());
        }

        private static int TransformMToN(int numberN, Queue<int> numbers, int currentNumber)
        {
            while (currentNumber > numberN)
            {
                if (currentNumber % 2 > 0)
                {
                    currentNumber = currentNumber - 1;
                    numbers.Enqueue(currentNumber);
                }
                else if (currentNumber / 2 >= numberN)
                {
                    currentNumber = currentNumber / 2;
                    numbers.Enqueue(currentNumber);
                }
                else if (currentNumber / 2 < numberN &&
                    currentNumber - 2 >= numberN)
                {
                    currentNumber = currentNumber - 2;
                    numbers.Enqueue(currentNumber);
                }
                else if (currentNumber / 2 < numberN &&
                   currentNumber - 2 < numberN)
                {
                    currentNumber--;
                    numbers.Enqueue(currentNumber);
                }
            }

            return currentNumber;
        }
    }
}
