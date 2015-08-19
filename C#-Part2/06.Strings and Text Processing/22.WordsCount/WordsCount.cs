using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class WordsCount
{
    public static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();                 
        string[] separators = new string[] { ",", ".", "!", "\'", " ", "\'s" };
        string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        var wordsCollection = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            // 1st solution
            // int count = Regex.Matches(input, words[i]).Count;
            // Console.WriteLine("{0} - {1}",words[i],count);
            // 2-nd solution
            int count = 0;
            if (!wordsCollection.Contains(words[i]))
            {
                wordsCollection.Add(words[i]);
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        count++;
                    }
                }

                Console.WriteLine("{0} - {1}", words[i], count);
                count = 0;
            }           
        }      
    }
}