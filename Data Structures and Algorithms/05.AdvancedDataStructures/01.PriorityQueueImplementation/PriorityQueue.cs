using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedDataStructures
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        public T[] elements { get; set; }
        public int Size { get; set; }
        public int Capacity { get; set; }
        public int Count { get; set; }
        public PriorityQueue()
        {
            this.Count = 0;
            this.Capacity = 16;
            this.elements = new T[this.Capacity];
        }

        public void Enqueue(T x)
        {
            if (this.Capacity == elements.Length - 1)
            {
                doubleSize();
            }

            // Insert a new item to the end of the array
            int pos = this.Count;
            this.Count++;
            // Percolate up
            this.elements[pos] = x;
            ReorderUp(pos);
        }

        public T Dequeue()
        {
            T detachedElement = this.elements[1];
            ReorderDown();
            this.Count--;
            return detachedElement;
        }

        public T Peek()
        {
            T peekedElement = this.elements[1]; 
            return peekedElement;
        }

        private void ReorderUp(int currentPosition)
        {
            int parentPosition = (currentPosition - 1) / 2;
            while (currentPosition > 0)
            {
                if (this.elements[parentPosition].CompareTo(this.elements[currentPosition]) > 0)
                {
                    Swap(ref this.elements[parentPosition], ref this.elements[currentPosition]);
                }
                else
                {
                    return;
                }
                
                currentPosition = parentPosition;
                if (parentPosition % 2 > 0)
                {
                    parentPosition = (parentPosition - 1) / 2;
                }
                else
                {
                    parentPosition = parentPosition / 2;
                }
            }        
        }

        private void ReorderDown()
        {
            var emptyIndex = 1;
            var leftIndex = 2;
            var rightIndex = 3;
            while (true)
            {
                if (this.Count < leftIndex)
                {
                    this.elements[emptyIndex] = this.elements[this.Count];
                    break;
                }

                if (this.elements[leftIndex].CompareTo(this.elements[rightIndex]) < 0)
                {
                    this.elements[emptyIndex] = this.elements[leftIndex];
                    emptyIndex = leftIndex;
                }
                else
                {
                    this.elements[emptyIndex] = this.elements[rightIndex];
                    emptyIndex = rightIndex;
                }

                leftIndex = emptyIndex * 2;
                rightIndex = emptyIndex * 2 + 1;
            }
        }

        private void doubleSize()
        {
            T[] clonedElements = this.elements.Clone() as T[];
            this.Capacity = this.Capacity * 2;
            this.elements = new T[this.Capacity];
            this.elements = clonedElements.Clone() as T[];
        }

        private void Swap(ref T elementA, ref T elementB)
        {
            T switcher = elementA;
            elementA = elementB;
            elementB = switcher;
        }
    }
}
