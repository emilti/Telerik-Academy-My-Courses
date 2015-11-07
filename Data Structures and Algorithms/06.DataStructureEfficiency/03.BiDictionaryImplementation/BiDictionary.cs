namespace BiDictionaryImplementation
{
    using System.Collections.Generic;
    using Wintellect.PowerCollections;
    using System.Linq;

    /// <summary>
    /// Implement a class BiDictionary<K1,K2,T> that allows adding triples {key1, key2, value} and 
    /// fast search by key1, key2 or by both key1 and key2.
    /// Note: multiple values can be stored for given key.
    /// </summary>
    /// <typeparam name="K1">First key</typeparam>
    /// <typeparam name="K2">Second key</typeparam>
    /// <typeparam name="T">Template value</typeparam>
    public class BiDictionary<K1, K2, T>
    {

        private MultiDictionary<K1, T> keysFirst;
        private MultiDictionary<K2, T> keysSecond;
        private MultiDictionary<string, T> keysBoth;

        public BiDictionary()
        {
            this.keysFirst = new MultiDictionary<K1, T>(true);
            this.keysSecond = new MultiDictionary<K2, T>(true);
            this.keysBoth = new MultiDictionary<string, T>(true);
        }

        public void Add(K1 keyFirst,K2 keySecond, T element)
        {
            keysFirst.Add(keyFirst, element);
            keysSecond.Add(keySecond, element);
            string keysConcatenated = keyFirst.ToString() + keySecond.ToString();
            keysBoth.Add(keysConcatenated, element);
        }

        public void Remove(K1 keyFirst, K2 keySecond, T element)
        {
            keysFirst.Remove(keyFirst);
            keysSecond.Remove(keySecond);
            string keysConcatenated = keysFirst.ToString() + keysSecond.ToString();
            keysBoth.Remove(keysConcatenated, element);
        }

        public T[] FindByFirstKey(K1 keyFirst)
        {
            var students = this.keysFirst[keyFirst].ToArray();
            return students;
        }

        public T[] FindBySecondKey(K2 keySecond)
        {
            return this.keysSecond[keySecond].ToArray();
        }

        public T[] FindByBothKeys(K1 keyFirst, K2 keySecond)
        {
            string keysConcatenated = keyFirst.ToString() + keySecond.ToString();
            var students = this.keysBoth[keysConcatenated].ToArray();
            return students;
        }
    }
}
