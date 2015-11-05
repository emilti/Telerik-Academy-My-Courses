namespace HashTableImplementation
{
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<K, T>
    {
        private int count;

        public HashTable()
        {
            this.Count = 0;
            this.Capacity = 16;
            this.Data = new LinkedList<KeyValuePair<K, T>>[this.Capacity];
        }

        public LinkedList<KeyValuePair<K, T>>[] Data { get; set; }

        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return this.count;
            }

            set
            {
                this.count = value;
            }
        }

        public K[] Keys
        {
            get
            {
                var listOfKeys = new List<K>(this.count);

                foreach (var pair in this)
                {
                    listOfKeys.Add(pair.Key);
                }

                return listOfKeys.ToArray();
            }
        }

        public T this[K key]
        {
            get
            {
                T valueToReturn = this.FindValue(key);

                return valueToReturn;
            }
        }

        public void Add(K key, T value)
        {
            KeyValuePair<K, T> pair = new KeyValuePair<K, T>(key, value);

            var index = this.GetIndex(key);

            if (this.Contains(key))
            {
                this.Data[index].AddLast(pair);
            }
            else
            {
                LinkedList<KeyValuePair<K, T>> currentRecord = new LinkedList<KeyValuePair<K, T>>();
                currentRecord.AddLast(pair);
                this.Data[index] = currentRecord;
            }

            this.Count = this.Count + 1;
            if (this.Count > this.Capacity * 0.75)
            {
                this.Resize();
            }
        }
        
        public LinkedList<KeyValuePair<K, T>> Find(K key)
        {
            var index = this.GetIndex(key);
            var pairs = this.Data[index];
            foreach (var pair in pairs)
            {
                if (pair.Key.ToString().CompareTo(key) == 0)
                {
                    LinkedList<KeyValuePair<K, T>> currentRecord = new LinkedList<KeyValuePair<K, T>>();
                    currentRecord.AddLast(pair);
                    return currentRecord;
                }
            }

            return null;
        }
        
        public void Resize()
        {
            this.Capacity = this.Capacity * 2;
            LinkedList<KeyValuePair<K, T>>[] cloned = new LinkedList<KeyValuePair<K, T>>[this.Capacity];
            cloned = this.Data.Clone() as LinkedList<KeyValuePair<K, T>>[];
            this.Data = new LinkedList<KeyValuePair<K, T>>[this.Capacity];
            this.Data = cloned.Clone() as LinkedList<KeyValuePair<K, T>>[];
        }

        public bool Contains(K key)
        {
            var index = this.GetIndex(key);
            if (this.Data[index] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public T FindValue(K key)
        {
            int index = this.GetIndex(key);          

            var pairs = this.Data[index];
            foreach (var pair in pairs)
            {
                if (pair.Key.ToString().CompareTo(key) == 0)
                {                    
                    return pair.Value;
                }
            }

            return default(T);
        }

        public void Remove(K key)
        {
            var index = this.GetIndex(key);
            var pairs = this.Data[index];
            var valueToRemove = this.Data[index].First(item => item.Key.ToString() == key.ToString());
            this.Data[index].Remove(valueToRemove);
            --this.count;
        }

        public void Clear()
        {
            this.Capacity = 16;
            this.count = 0;
            this.Data = new LinkedList<KeyValuePair<K, T>>[this.Capacity];
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var valuesList in this.Data)
            {
                if (valuesList == null)
                {
                    continue;
                }

                foreach (var item in valuesList)
                {
                    yield return item;
                }
            }
        }

        private int GetIndex(K key)
        {
            var hash = key.GetHashCode();

            if (hash < 0)
            {
                hash *= -1;
            }

            var index = hash % this.Data.Length;

            return index;
        }
    }
}
