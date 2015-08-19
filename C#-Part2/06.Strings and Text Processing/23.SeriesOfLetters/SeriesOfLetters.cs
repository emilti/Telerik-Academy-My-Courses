using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SeriesOfLetters
{
    public static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        char previosChar = ' ';
        StringBuilder sb = new StringBuilder();
        foreach (char chr in input)
        {
            if (chr != previosChar)
            {
                sb.Append(chr);
                previosChar = chr;
            }
        }

        Console.WriteLine(sb.ToString());
    }
}