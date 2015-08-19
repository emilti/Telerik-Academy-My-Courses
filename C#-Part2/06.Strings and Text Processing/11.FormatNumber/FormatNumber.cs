using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FormatNumber
{
    public static void Main()
    {
        Console.WriteLine("Enter number:");
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine("Decimal number:");
        string formatDecimal = string.Format("{0,15}", number);
        Console.WriteLine(formatDecimal);       
        Console.WriteLine("Hex numbers:");
        string formatHexadecimal = string.Format("{0,15:X}", (int)number);
        Console.WriteLine(formatHexadecimal);
        Console.WriteLine("Percentages:");
        string formatPercentages = string.Format("{0,15:P1}", number / 100);
        Console.WriteLine(formatPercentages);
        Console.WriteLine("Scientific notation:");
        string formatScienceNotification = string.Format("{0,15:e}", number);
        Console.WriteLine(formatScienceNotification);
    }
}