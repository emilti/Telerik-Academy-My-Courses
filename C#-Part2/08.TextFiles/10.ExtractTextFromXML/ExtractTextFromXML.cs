using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class ExtractTextFromXML
{
    public static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\letter.xml");
        string alltext = string.Empty;
        using (reader)
        {
            alltext = reader.ReadToEnd();
        }
        
        Regex rgx = new Regex(@"\<(?<=<).*?(?=>)\>");
        string result = rgx.Replace(alltext, string.Empty);
        Console.WriteLine(result);
        StreamWriter writer = new StreamWriter(@"..\..\letter_amended.xml");
        using (writer)
        {
            writer.Write(result);
        }
    }
}