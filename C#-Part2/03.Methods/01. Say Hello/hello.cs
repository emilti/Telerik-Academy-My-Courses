using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Hello
{
    public static void Main()
    {
        string input = Say();
        StringCheck(input);
    }

    public static string Say()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        return name;
    }

    public static void StringCheck(string check)
    {
        int coundOfValidLetters = Regex.Matches(check, @"[a-zA-Z]").Count;
        if (coundOfValidLetters == check.Length)
        {
            Console.WriteLine("Hello, {0}!", check);
        }
        else
        {
            Console.WriteLine("Not a valid name.");
        }
    }
}