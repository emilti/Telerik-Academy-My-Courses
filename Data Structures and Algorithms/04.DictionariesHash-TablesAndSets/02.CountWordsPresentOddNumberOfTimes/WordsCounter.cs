namespace DataStructuresHomework
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Write a program that extracts from a given sequence of strings all
    ///  elements that present in it odd number of times. Example:
    /// {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
    /// </summary>
    public class WordsCounter
    {
        public static void Main()
        {
            string input = "C#, SQL, PHP, PHP, SQL, SQL";
            var words = 
                input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> countOfValues = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (countOfValues.ContainsKey(words[i]))
                {
                    countOfValues[words[i]] = countOfValues[words[i]] + 1;
                }
                else
                {
                    countOfValues.Add(words[i], 1);
                }
            }

            Dictionary<string, int> oddCountOfValues = new Dictionary<string, int>();
            foreach (var key in countOfValues.Keys)
            {
                if (countOfValues[key] % 2 != 0)
                {
                    oddCountOfValues.Add(key, countOfValues[key]);
                    Console.WriteLine(key + "-->" + countOfValues[key]);
                }
            }
        }
    }
}
