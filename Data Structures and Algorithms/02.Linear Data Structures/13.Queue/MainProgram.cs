namespace LinearDataStructures
{
    using System;

    /// <summary>
    /// Implement the ADT queue as dynamic linked list.
    /// Use generics (LinkedQueue<T>) to allow storing different data types in the queue.
    /// </summary>
    public class MainProgram
    {
        public static void Main()
        {
            MyQueue<int> myQueue = new MyQueue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Dequeue();

            Console.WriteLine(string.Join(" ,", myQueue.Objects));
        }
    }
}
