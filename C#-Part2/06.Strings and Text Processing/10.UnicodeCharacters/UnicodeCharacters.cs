using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UnicodeChararacters
{
    public static void Main()
    {
        Console.WriteLine("Enter your string:");
        string input = Console.ReadLine();   
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("\\u{0:X4}", (int)input[i]);
        }

        Console.WriteLine();
    }
}