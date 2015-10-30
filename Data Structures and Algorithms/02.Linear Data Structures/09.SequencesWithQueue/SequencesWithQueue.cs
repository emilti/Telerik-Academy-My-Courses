namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 09.We are given the following sequence:
    /// S1 = N;
    /// S2 = S1 + 1;
    /// S3 = 2*S1 + 1;
    /// S4 = S1 + 2;
    /// S5 = S2 + 1;
    /// S6 = 2*S2 + 1;
    /// S7 = S2 + 2;
    /// ...
    /// Using the Queue<T> class write a program to print its first 50 members for given N.
    /// Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
    /// </summary>
    public class SequencesWithQueue
    {
        public static void Main()
        {
            Console.WriteLine("Enter N:");
            int number = int.Parse(Console.ReadLine());
            Queue<int> numbers = new Queue<int>();
            int counter = 0;
            numbers.Enqueue(number + 1);
            numbers.Enqueue((2 * number) + 1);
            numbers.Enqueue(number + 2);
            while (counter < 50)
            {                
                int next = numbers.Dequeue();
                Console.Write(next + ", ");
                numbers.Enqueue(next + 1);
                numbers.Enqueue((2 * next) + 1);
                numbers.Enqueue(next + 2);
                counter++;
            }            
        }
    }
}
