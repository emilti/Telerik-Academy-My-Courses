using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LeapYear
{
    public static void Main()
    {        
       Console.WriteLine("Enter date for checking in format:");
       DateTime date = DateTime.Parse(Console.ReadLine());
       if (DateTime.IsLeapYear(date.Year))
       {
           Console.WriteLine("{0} is leap year.", date.Year);
       }
       else
       {
           Console.WriteLine("{0} is not leap year.", date.Year);
       }
    }
}