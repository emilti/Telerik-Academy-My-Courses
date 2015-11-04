namespace DataStructuresHomework
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Write a program that counts how many times each word from given text file words.txt appears in it.
    /// The character casing differences should be ignored. The result words should be ordered by 
    /// their number of occurrences in the text. Example:
    /// This is the TEXT.Text, text, text – THIS TEXT! Is this the text?
    /// is -> 2
    /// the -> 2
    /// this -> 3
    /// text -> 6
    /// </summary>
    public class WordsInTextCounter
    {
        public static void Main()
        {
            string text;
            using (StreamReader reader = new StreamReader("../../input.txt"))
            {
                string line;
                StringBuilder sb = new StringBuilder();
                while ((line = reader.ReadLine()) != null)
                {
                    sb.Append(line);
                }

                text = sb.ToString();
                reader.Close();
            }

            var words = text.Split(
                new char[] { ' ', '.', ',', '?', '!', '-' },
                StringSplitOptions.RemoveEmptyEntries);
            OrderedDictionaryImplementation(words);
            DictionaryImplementation(words);
        }

        private static void OrderedDictionaryImplementation(string[] words)
        {   
            var result = new SortedDictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                string keyToAdd = words[i].ToLower();
                if (result.ContainsKey(keyToAdd))
                {
                    result[keyToAdd] = result[keyToAdd] + 1;
                }
                else
                {
                    result.Add(keyToAdd, 1);
                }
            }

            Console.WriteLine("Ordered dictionay implementation:");
            foreach (var key in result.Keys)
            {
                Console.WriteLine(key + "-->" + result[key]);
            }

            Console.WriteLine();
        }

        private static void DictionaryImplementation(string[] words)
        {
            Dictionary<string, int> countOfValues = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string keyToAdd = words[i].ToLower();
                if (countOfValues.ContainsKey(keyToAdd))
                {
                    countOfValues[keyToAdd] = countOfValues[keyToAdd] + 1;
                }
                else
                {
                    countOfValues.Add(keyToAdd, 1);
                }
            }

            Dictionary<string, int> orderedvalues =
                countOfValues.OrderBy(x => x.Value)
                .ToDictionary(pair => pair.Key, pair => pair.Value);
            Console.WriteLine("Dictionary Implementation:");
            foreach (var key in orderedvalues.Keys)
            {
                Console.WriteLine(key + "-->" + orderedvalues[key]);
            }           
        }
    }
}
