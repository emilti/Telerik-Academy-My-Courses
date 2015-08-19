using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class ReplaceTags
{
    public static void Main()
    {
        Console.WriteLine("Enter your text:");
        string input = Console.ReadLine();
        string pattern = "<a href=\"";
        string replacement = "[URL=";
        string patternB = "\">";
        string replacementB = "]";
        string patternC = "</a>";
        string replacementC = "[/URL]";
        string result = Regex.Replace(input, pattern, replacement);
        result = Regex.Replace(result, patternB, replacementB);
        result = Regex.Replace(result, patternC, replacementC);
        Console.WriteLine("The cnahged text is:");
        Console.WriteLine(result);
    }
}