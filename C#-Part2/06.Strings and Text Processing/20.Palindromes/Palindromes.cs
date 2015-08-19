using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Palindromes
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Regex rgx = new Regex(@"[\w]+", RegexOptions.None);
        MatchCollection match = rgx.Matches(input);
        var wordsCollection = new List<string>();
        foreach (var matched in match)
        {
            wordsCollection.Add(matched.ToString());            
        }

        var palindromes = new List<string>();
        Console.WriteLine("Palindromes are:");
        foreach (var word in wordsCollection)
        {
            bool palindrome = true;
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - i - 1])
                {
                    palindrome = false;
                    break;
                }

                if (palindrome && i == (length / 2) - 1)
                {                    
                    Console.WriteLine(word);
                }
            }
        }   
    }
}