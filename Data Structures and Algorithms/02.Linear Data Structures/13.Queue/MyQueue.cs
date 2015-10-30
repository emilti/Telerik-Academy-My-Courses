namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;

    public class MyQueue<T>
    {
        private LinkedList<T> objects;

        public MyQueue()
        {
            this.Objects = new LinkedList<T>();
        }

        public LinkedList<T> Objects
        {
            get
            {
                return this.objects;
            }

            set
            {
                this.objects = value;
            }
        }

        public void Enqueue(T value)
        {
            this.objects.AddLast(value);
        }

        public T Dequeue()
        {
            if (this.objects.Count == 0)
            {
                throw new ArgumentNullException("Queue is empty!");
            }

            T value = this.objects.First.Value;
            this.objects.RemoveFirst();

            return value;
        }
    }
}
