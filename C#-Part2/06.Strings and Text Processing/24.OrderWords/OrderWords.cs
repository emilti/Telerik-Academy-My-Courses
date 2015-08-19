using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OrderWords
{
    public static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        string[] separators = new string[] { " " };
        string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words, (x, y) => string.Compare(x, y));
        Console.WriteLine(string.Join(", ", words));
    }
}