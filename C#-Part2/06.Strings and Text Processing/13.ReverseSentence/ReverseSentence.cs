using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class ReverseSentence
{
    public static void Main()
    {
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');        
        StringBuilder sb = new StringBuilder(); 
        string finalWord = string.Empty;
        char finalSymbol = ' ';
        for (int i = words.Length - 1; i >= 0; i--)
        {            
            // sbList.Add(new StringBuilder(words[i]));
            if (words[i].Contains('.') || words[i].Contains('!') || words[i].Contains('?'))
            {
                finalWord = words[i];
                finalSymbol = finalWord[finalWord.Length - 1];
                string final = Regex.Replace(words[i].ToString(), @"[^\w+]", string.Empty, RegexOptions.None);
                sb.Insert(0, final);
                sb.Insert(final.Length, ' ');
            }
            else
            {
                sb.Append(words[i]);
                sb.Append(' ');
            }

            if (i == 0)
            {
                sb.Remove(sb.Length - 1, 1);
                sb.Append(finalSymbol);
            }
        }

        Console.WriteLine(sb.ToString());    
    }
}