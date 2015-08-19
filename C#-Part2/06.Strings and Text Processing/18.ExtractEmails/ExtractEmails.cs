using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class ExtractEmails
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Regex rgx = new Regex(@"\b[a-z0-9]+\@[a-z0-9]+\.[a-z]{2,3}\b", RegexOptions.None);
        MatchCollection emails = rgx.Matches(input);
        foreach (var match in emails)
        {
            Console.WriteLine(match);
        }
    }
}