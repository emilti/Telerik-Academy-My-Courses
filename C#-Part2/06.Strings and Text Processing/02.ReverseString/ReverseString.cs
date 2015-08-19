using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReverseString
{
    public static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }

        string finalStr = sb.ToString();
        Console.WriteLine("The reversed string is:");
        Console.WriteLine(finalStr);
    }
}