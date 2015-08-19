using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class ReplaceWholeWord
{
    public static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\start.txt");
        Console.WriteLine("Enter word for change:");
        string word = Console.ReadLine();
        string output = string.Empty;
        using (reader)
        {
            StringBuilder sb = new StringBuilder();
            string allText = reader.ReadToEnd();
            Regex rgx = new Regex(@"\bstart\b");
            output = rgx.Replace(allText, "finish");
        }

        StreamWriter streamWriter = new StreamWriter(@"..\..\End.txt");
        using (streamWriter)
        {
            streamWriter.Write(output);
        }

        Console.WriteLine(output);
    }
}