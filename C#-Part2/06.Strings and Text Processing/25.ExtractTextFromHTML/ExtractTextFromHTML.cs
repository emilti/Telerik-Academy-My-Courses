using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class ExtractTextFromHTML
{
    public static void Main()
    {
        Console.WriteLine("Enter text:");

        // string input = Console.ReadLine();
        string input = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">
Telerik Academy</a> aims to provide free real-world practical training 
for young people who want to turn into skilful .NET software engineers.</p></body></html>";
        string interim = Regex.Replace(input, "<title>", "Title:");
        string interim2 = Regex.Replace(interim, "<body>", "\nText:");
        Regex rgx = new Regex(@"\<(?<=<).*?(?=>)\>");

        // Regex rgx = new Regex(@"\<\w+\>|\<\/\w+\>|\<a.*");
        string result = rgx.Replace(interim2, string.Empty);       
        Console.WriteLine(result);
    }
}