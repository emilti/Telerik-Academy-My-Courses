namespace LinearDataStructures
{
    public class MyStack<T>
    {
        public T[] Array { get; set; }

        public int Capacity { get; set; }

        public int Count { get; set; }

        public MyStack()
        {
            this.Count = 0;
            this.Capacity = 4;
            this.Array = new T[this.Capacity];
        }

        public void Push(T Element)
        {
            if (this.Count + 1 >= this.Capacity)
            {
                this.Capacity = this.Capacity * 2;
                T[] storedArray = this.Array;
                this.Array = new T[this.Capacity];

                for (int j = 0; j < storedArray.Length; j++)
                {
                    this.Array[j] = storedArray[j];
                }
                // this.Array = storedArray;
            }

            this.Array[this.Count] = Element;
            Count++;
        }

        public T Pop()
        {
            this.Count--;
            T currentItem = this.Array[this.Count];

            return currentItem;
        }
    }
}
