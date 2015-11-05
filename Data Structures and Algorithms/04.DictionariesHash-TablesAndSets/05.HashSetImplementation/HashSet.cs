namespace HashSetImplementation
{
    using HashTableImplementation;
    using System.Collections;
    using System.Collections.Generic;

    public class HashSet<T> : IEnumerable<T>
    {
        private HashTable<int, T> data;
        private int count;

        public HashSet()
        {
            this.Clear();
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Clear()
        {
            this.count = 0;
            this.data = new HashTable<int, T>();
        }

        public void Add(T value)
        {
            int key = this.GetHashCode(value);
            this.data.Add(key, value);
            this.count++;
        }

        public T Find(T value)
        {
            int key = this.GetHashCode(value);
            return this.data[key];
        }

        public void Remove(T value)
        {
            var key = this.GetHashCode(value);
            this.data.Remove(key);
            --this.count;
        }


        public HashSet<T> Intersect(HashSet<T> other)
        {
            var result = new HashSet<T>();

            foreach (var item in this.data)
            {
                foreach (var otherItem in other.data)
                {
                    if (item.Key == otherItem.Key)
                    {
                        result.Add(item.Value);
                    }
                }
            }

            return result;
        }

        public HashSet<T> Union(HashSet<T> other)
        {
            var result = new HashSet<T>();

            foreach (var item in this.data)
            {
                result.Add(item.Value);
            }

            foreach (var item in other.data)
            {
                if (!result.data.Contains(item.Key))
                {
                    result.Add(item.Value);
                }
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.data)
            {
                yield return item.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(", ", this);
        }

        private int GetHashCode(T value)
        {
            int hash = value.GetHashCode();

            if (hash < 0)
            {
                hash *= -1;
            }

            return hash;
        }
    }
}
