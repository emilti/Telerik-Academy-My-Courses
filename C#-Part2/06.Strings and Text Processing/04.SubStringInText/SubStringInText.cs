using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class SubStringInText
{
    public static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        Console.WriteLine("Enter the substring which will be searched at the text:");
        string searchedText = Console.ReadLine();
        int count = Regex.Matches(input, searchedText).Count;
        Console.WriteLine("The count of occurencies of the searched sub string in the text is:");
        Console.WriteLine(count);
    }
}