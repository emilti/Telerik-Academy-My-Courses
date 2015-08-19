using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ExtractSentences
{
    public static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        Console.WriteLine("Enter word for checking:");
        string wordForCheck = Console.ReadLine();
        StringBuilder sb = new StringBuilder();        
        sb.Append(wordForCheck);       
        string[] sentences = input.Split('.');
        bool found = false;
        for (int i = 0; i < sentences.Length; i++)
        {
            found = sentences[i].Substring(0, sentences[i].Length).Contains(sb.ToString() + " ");
           if (found == true)
           {
               Console.Write(sentences[i] + ".");
               found = false;
           }
        }

        Console.WriteLine();
    }
}