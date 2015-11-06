namespace AdvancedDataStructures
{
    /// <summary>
    /// Implement a class PriorityQueue<T> based on the data structure "binary heap".
    /// </summary>
    public class PriorityQueue
    {
        static void Main()
        {
            PriorityQueue<int> myPriorityQueue = new PriorityQueue<int>();
            for (int i = 0; i < 10; i++)
            {
                if (i != 2)
                {
                    myPriorityQueue.Enqueue(i);
                }
            }

            myPriorityQueue.Enqueue(2);
            myPriorityQueue.Dequeue();
        }
    }
}
