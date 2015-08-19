using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DateDifference
{
    public static void Main()
    {
        Console.Write("Enter the first date:");
        string firstDate = Console.ReadLine();
        Console.Write("Enter the second date:");
        string secondDate = Console.ReadLine();
        string[] firstDateArray = firstDate.Split('.');
        DateTime firstDateFormatted = new DateTime(int.Parse(firstDateArray[2]), int.Parse(firstDateArray[1]), int.Parse(firstDateArray[0]));
        string[] secondDateArray = secondDate.Split('.');
        DateTime secondDateFormatted = new DateTime(int.Parse(secondDateArray[2]), int.Parse(secondDateArray[1]), int.Parse(secondDateArray[0]));
        TimeSpan diff = secondDateFormatted - firstDateFormatted;
        Console.WriteLine("Distance: {0} days", diff.Days);
    }
}